using MyJukebox_EF.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyJukebox_EF.BLL
{
    public static class DataGetSet
    {
        #region MyjukeBox
        public static async Task<List<string>> GetGenresAsync()
        {
            List<string> genres = null;
            var context = new MyJukeboxEntities();
            await Task.Run(() =>
            {
                genres = context.vSongs
                    .Select(g => g.Genre).Distinct().OrderBy(g => g).ToList();
            });
            return genres;
        }

        public static async Task<List<string>> GetCatalogsAsync()
        {
            List<string> catalogues = null;

            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    catalogues = context.vSongs
                                        .Where(c => c.Genre == Settings.LastGenre)
                                        .Select(c => c.Catalog)
                                        .Distinct().OrderBy(c => c).ToList();
                });

                return catalogues;
            }
        }

        public static async Task<List<string>> GetAlbumsAsync()
        {
            List<string> albums = null;

            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    albums = context.vSongs
                                    .Where(a => a.Genre == Settings.LastGenre && a.Catalog == Settings.LastKatalog)
                                    .Select(a => a.Album)
                                    .Distinct().OrderBy(a => a).ToList();
                });

                return albums;
            }
        }

        public static async Task<List<string>> GetInterpretenAsync()
        {
            List<string> interprer = null;

            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    interprer = context.vSongs
                                    .Where(i => i.Genre == Settings.LastGenre && i.Catalog == Settings.LastKatalog)
                                    .Select(i => i.Interpret)
                                    .Distinct().OrderBy(i => i).ToList();
                });

                return interprer;
            }
        }

        public static async Task<List<Playlist>> GetPlaylistsAsync()
        {
            List<Playlist> playLists = new List<Playlist>();

            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    var playlists = context.tPlaylists
                                 .OrderBy(p => p.Name)
                                 .Select(p => new { p.ID, p.Name, p.Pos });

                    foreach (var p in playlists)
                    {
                        playLists.Add(new Playlist { ID = p.ID, Name = p.Name, Pos = p.Pos });
                    }

                });

                return playLists;
            }
        }

        public static async Task<List<vSong>> GetTablogicalResultsAsync()
        {
            List<vSong> songs = null;

            try
            {
                var genre = Settings.LastGenre == "Alle" ? "" : Settings.LastGenre;
                var album = Settings.LastAlbum == "Alle" ? "" : Settings.LastAlbum;
                var catalog = Settings.LastKatalog == "Alle" ? "" : Settings.LastKatalog;
                var artist = Settings.LastInterpret == "Alle" ? "" : Settings.LastInterpret;

                var context = new MyJukeboxEntities();
                await Task.Run(() =>
                {
                    songs = context.vSongs
                        .Where(s => (s.Genre.Contains(genre)) &&
                            (s.Catalog.Contains(catalog)) &&
                            (s.Album.Contains(album)) &&
                            (s.Interpret.Contains(artist))
                            ).ToList();
                });

                return songs;

            }
            catch
            {
                return null;
            }
        }

        public static async Task<List<vSong>> GetQueryResultAsync(string queryText)
        {
            List<vSong> songs = null;
            string sql = "";
            string[] arTokens;
            bool findExplizit = false;

            try
            {
                arTokens = queryText.Split('=');

                if (queryText.IndexOf("==") != 0)
                {
                    findExplizit = true;
                    arTokens = arTokens.Where(w => w != arTokens[1]).ToArray();
                }
                else
                    findExplizit = false;

                var search = arTokens[0];
                var argument = arTokens[1];

                if (argument.Substring(0, 1) == "'")
                    argument = argument.Substring(1);

                if (argument.Substring(argument.Length - 1, 1) == "'")
                    argument = argument.Substring(0, argument.Length - 1);

                if (findExplizit == true)
                    sql = $"select * from vSongsNewShort where {search} = '{argument}'";
                else
                    sql = $"select * from vSongsNewShort where {search} like '%{argument}%'";

                var context = new MyJukeboxEntities();
                await Task.Run(() =>
                {
                    try
                    {
                        songs = context.vSongs
                            .SqlQuery(sql).ToList();
                    }
                    catch
                    {

                    }

                });

                return songs;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<List<vPlaylistSong>> GetPlaylistEntries()
        {
            List<vPlaylistSong> songs = null;

            try
            {
                var context = new MyJukeboxEntities();

                await Task.Run(() =>
                {
                    songs = context.vPlaylistSongs
                        .Where(i => i.PLID == Settings.PlaylistCurrentID).ToList();
                });

                return songs;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region FileScanner
        public static bool TruncateTableImportTest()
        {
            try
            {
                var context = new MyJukeboxEntities();
                var result = context.Database.ExecuteSqlCommand("truncate table [tTestImport]");

                return true;
            }
            catch
            {
                return false;
            }

        }

        public static int SaveNewRecords(List<MP3Record> mP3Records, bool testImport)
        {
            int recordsImporteds = 0;

            Logging.Flush();

            if (testImport == true)
            {
                var result = DataGetSet.TruncateTableImportTest();
                Debug.Print($"TruncateTableImportTest result = {result}");
            }

            foreach (MP3Record record in mP3Records)
            {
                recordsImporteds += SaveNewRecord(record, testImport);
            }

            return recordsImporteds;
        }

        private static int SaveNewRecord(MP3Record record, bool testImport)
        {
            int recordsImported = 0;

            if (testImport == true)
                recordsImported += SetNewTestRecord(record);
            else
            {
                if (MD5Exist(record.MD5) == false)
                {
                    recordsImported += SetNewRecord(record);
                }
            }
            return recordsImported;
        }

        private static bool MD5Exist(string MD5)
        {
            var context = new MyJukeboxEntities();
            var result = context.tMd5
                            .Where(m => m.MD5 == MD5)
                            .Select(m => m.MD5).ToList();

            if (result.Count > 0)
            {
                Debug.Print("title allready exist!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int SetNewRecord(MP3Record record)   // productiv
        {
            try
            {
                var context = new MyJukeboxEntities();

                var song = new tSong();
                song.Album = record.Album;
                song.Interpret = record.Interpret;
                song.Titel = record.Titel;
                song.Pfad = record.Path;
                song.FileName = record.FileName;

                context.tSongs.Add(song);
                context.SaveChanges();

                int songID = (int)GetLastSongID("tSongs");

                // tMd5
                var md5 = new tMD5();
                md5.ID_Song = songID;
                md5.MD5 = record.MD5;

                context.tMd5.Add(md5);
                context.SaveChanges();

                // tInfo
                var info = new tInfo();
                info.ID_Song = songID;
                info.Media = record.Media;
                info.Sampler = record.IsSample;
                context.tInfos.Add(info);
                context.SaveChanges();

                // tFileInfo
                var file = new tFileInfo();
                file.ID_Song = songID;
                file.FileDate = record.FileDate;
                file.FileSize = record.FileSize;
                file.ImportDate = DateTime.Now;
                context.tFileInfoes.Add(file);
                context.SaveChanges();

                int catalogID = GetCatalogFromString(record.Catalog);
                int genreID = GetGenreFromString(record.Genre);

                // tSong
                song.ID_Catalog = catalogID;
                song.ID_Genre = genreID;
                context.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return 0;
            }
        }

        private static int SetNewTestRecord(MP3Record record)
        {
            try
            {
                var context = new MyJukeboxEntities();

                var media = new tMedia();
                var medium = context.tMedias
                    .Where(m => m.ID == record.Media)
                    .Select(m => m.Type).FirstOrDefault();

                var import = new tTestImport();
                import.Album = record.Album;
                import.FileDate = record.FileDate;
                import.FileName = record.FileName;
                import.FileSize = record.FileSize;
                import.Genre = record.Genre;
                import.Interpret = record.Interpret;
                import.Katalog = record.Catalog;
                import.MD5 = record.MD5;
                import.Medium = medium;
                import.Pfad = record.Path;
                import.IsSampler = record.IsSample;
                import.Titel = record.Titel;
                import.ImportDate = DateTime.Now;

                context.tTestImports.Add(import);
                context.SaveChanges();

                Logging.Log("1 record added");
                return 1;
            }
            catch (Exception ex)
            {
                //Debug.Print(ex.Message);
                Logging.Log(ex.Message);
                return 0;
            }
        }
        #endregion

        #region EditForm
        public static async Task<List<string>> GetGenresFullAsync()
        {
            List<string> genres = null;
            var context = new MyJukeboxEntities();
            await Task.Run(() =>
            {
                genres = context.tGenres
                    .Select(g => g.Name).ToList();
            });
            return genres;
        }

        public static List<string> GetSongRecord(int id)
        {
            var context = new MyJukeboxEntities();
            var songs = context.vSongs
                        .Where(s => s.ID == id)
                        .Select(s => new { s.ID, s.Genre, s.Catalog, s.Album, s.Interpret, s.Titel, s.Pfad, s.FileName }).ToList();

            List<string> list = new List<string>();
            list.Add(songs[0].ID.ToString());
            list.Add(songs[0].Genre);
            list.Add(songs[0].Catalog);
            list.Add(songs[0].Album);
            list.Add(songs[0].Interpret);
            list.Add(songs[0].Titel);
            list.Add(songs[0].Pfad);
            list.Add(songs[0].FileName);

            return list;
        }

        public static List<string> GetFileRecord(int id)
        {
            var context = new MyJukeboxEntities();
            var file = context.tFileInfoes
                            .Where(f => f.ID_Song == id)
                            .Select(f => new { f.FileSize, f.FileDate, f.Duration }).ToList();

            List<string> list = new List<string>();
            list.Add(file[0].FileSize.ToString());
            list.Add(file[0].FileDate.ToString());
            list.Add(file[0].Duration.ToString());

            return list;
        }

        public static bool EditSaveSongChanges(int id, MP3Record record)
        {
            try
            {
                var context = new MyJukeboxEntities();
                var songs = context.tSongs.Find(id);

                if (songs.ID_Genre != GetGenreFromString(record.Genre))
                    songs.ID_Genre = GetGenreFromString(record.Genre);

                if (songs.ID_Catalog != GetCatalogFromString(record.Catalog))
                    songs.ID_Catalog = GetCatalogFromString(record.Catalog);

                if (songs.Album != record.Album) songs.Album = record.Album;
                if (songs.Interpret != record.Interpret) songs.Interpret = record.Interpret;
                if (songs.Titel != record.Titel) songs.Titel = record.Titel;
                if (songs.Pfad != record.Path) songs.Pfad = record.Path;
                if (songs.FileName != record.FileName) songs.FileName = record.FileName;

                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EditSaveFileinfoChanges(int id, MP3Record record)
        {
            try
            {
                var context = new MyJukeboxEntities();
                var file = context.tFileInfoes.Find(id);

                if (file.FileSize != record.FileSize) file.FileSize = record.FileSize;
                if (file.FileDate != record.FileDate) file.FileDate = record.FileDate;
                if (file.Duration != record.Duration) file.Duration = record.Duration;

                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Generell
        public static int? GetLastSongID(string tableName)
        {
            int? lastId = -1;
            int recCount = -1;

            try
            {
                var context = new MyJukeboxEntities();

                if (recCount != 0 && tableName == "tTestImport")
                {
                    recCount = context.tTestImports
                                    .Select(i => i.ID).Count();

                    if (recCount != 0)
                        lastId = context.tTestImports.Max(x => x.ID);
                }

                if (tableName == "tSongs")
                {
                    recCount = context.tSongs
                                    .Select(i => i.ID).Count();

                    if (recCount != 0)
                        lastId = context.tSongs.Max(x => x.ID);
                }

                return lastId;
            }
            catch
            {
                return null;
            }
        }

        public static int GetGenreFromString(string genre)
        {
            List<int> genres;
            var context = new MyJukeboxEntities();
            genres = context.tGenres
                        .Where(g => g.Name == genre)
                        .Select(g => g.ID).ToList();

            return genres[0];
        }

        public static int GetCatalogFromString(string catalog)
        {
            List<int> catalogs;
            try
            {
                var context = new MyJukeboxEntities();
                catalogs = context.tCatalogs
                            .Where(c => c.Name == catalog)
                            .Select(c => c.ID).ToList();

                return catalogs[0];
            }
            catch
            {
                return -1;
            }
        }

        public static async Task RefillMD5Table()
        {
            List<tMD5> rec = new List<tMD5>();
            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    var result = context.tSongs
                                    .OrderBy(s => s.ID)
                                    .Select(s => new { s.ID, s.Pfad, s.FileName });

                    foreach (var s in result)
                    {
                        string hash = Methods.MD5($"{s.Pfad}{s.FileName}");
                        Debug.Print($"ID_Song={s.ID}, md5={hash}");


                        rec.Add(new tMD5 { ID_Song = s.ID, MD5 = hash });

                    }

                    context.tMd5.AddRange(rec);
                    context.SaveChanges();
                });
            }
        }
        #endregion
    }
}
