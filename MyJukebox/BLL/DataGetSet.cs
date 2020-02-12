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


        // ToDo: check this !
        public static void AddSongToPlaylist(int id, string playlistName)
        {
            var context = new MyJukeboxEntities();
            var playlist = context.tPlaylists
                                .Where(p => p.Name == playlistName)
                                .Select(p => p.ID).ToList();

            if (playlist == null)
                throw new Exception("Wrong playlist!");

            var entry = new tPLentry()
            {
                PLID = playlist[0],
                SongID = id,
                Pos = 1
            };

            context.tPLentries.Add(entry);
            context.SaveChanges();
        }

        public static void DeleteSong(int id)
        {
            var context = new MyJukeboxEntities();
            var songs = context.tSongs.First(s => s.ID == id);
            context.tSongs.Remove(songs);
            context.SaveChanges();

        }

        public static async Task<List<string>> GetGenresAsync()
        {
            List<string> genres = null;
            var context = new MyJukeboxEntities();
            await Task.Run(() =>
            {
                genres = context.tGenres
                    .Select(g => g.Name).ToList();  // .Distinct().OrderBy(g => g).ToList();
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
                                        .Where(c => c.Genre == TreeViewLogicStates.Genre)
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
                                    .Where(a => a.Genre == TreeViewLogicStates.Genre && a.Catalog == TreeViewLogicStates.Catalog)
                                    .Select(a => a.Album)
                                    .Distinct().OrderBy(a => a).ToList();
                });

                return albums;
            }
        }

        public static List<string> GetInterpretenAsyncTest(string genre, string catalog, string album)
        {
            List<string> interpretes = null;

            using (var context = new MyJukeboxEntities())
            {
                try
                {
                    interpretes = context.vSongs
                                    .Where(i => i.Genre == genre && i.Catalog == catalog && i.Album.Contains(album))
                                    .Select(i => i.Interpret)
                                    .Distinct().OrderBy(i => i).ToList();

                    return interpretes;

                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public static async Task<List<string>> GetInterpretenAsync()
        {
            List<string> interpreter = null;

            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    interpreter = context.vSongs
                                    .Where(i => i.Genre == TreeViewLogicStates.Genre && i.Catalog == TreeViewLogicStates.Catalog && i.Album.Contains(TreeViewLogicStates.Album))
                                    .Select(i => i.Interpret)
                                    .Distinct().OrderBy(i => i).ToList();
                });

                return interpreter;
            }
        }

        public static List<vPlaylistSong> GetPlaylistEntries(int playlistID)
        {
            List<vPlaylistSong> songs = null;
            try
            {
                var context = new MyJukeboxEntities();
                songs = context.vPlaylistSongs
                    .Where(i => i.PLID == playlistID).ToList();

                return songs;
            }
            catch (Exception ex)
            {
                Debug.Print($"GetPlaylistEntries_Error: {ex.Message}");
                return null;
            }
        }

        public static async Task<List<vPlaylistSong>> GetPlaylistEntriesAsync(int playlistID)
        {
            List<vPlaylistSong> songs = null;
            try
            {
                var context = new MyJukeboxEntities();
                await Task.Run(() =>
                {
                    songs = context.vPlaylistSongs
                        .Where(i => i.PLID == playlistID).ToList();
                });

                return songs;
            }
            catch (Exception ex)
            {
                Debug.Print($"GetPlaylistEntries_Error: {ex.Message}");
                return null;
            }
        }

        public static List<Playlist> GetPlaylists()
        {
            List<Playlist> playLists = new List<Playlist>();

            using (var context = new MyJukeboxEntities())
            {
                var playlists = context.tPlaylists
                                .OrderBy(p => p.Name)
                                .Select(p => new { p.ID, p.Name, p.Row });

                foreach (var p in playlists)
                {
                    playLists.Add(new Playlist { ID = p.ID, Name = p.Name, Pos = p.Row });
                }

                return playLists;
            }
        }


        public static async Task<List<vSong>> GetQueryResultAsync(string queryText)
        {
            List<vSong> songs = null;

            try
            {
                string sql = Methods.GetQueryString(queryText);

                var context = new MyJukeboxEntities();
                await Task.Run(() =>
                        {
                            songs = context.vSongs
                                      .SqlQuery(sql).ToList();

                        });

                return songs;
            }
            catch (Exception ex)
            {
                Debug.Print($"GetQueryResultAsync: {ex.Message}");
                return null;
            }
        }

        public static async Task<List<vSong>> GetTablogicalResultsAsync()
        {
            List<vSong> songs = null;

            try
            {
                var context = new MyJukeboxEntities();
                await Task.Run(() =>
                {
                    songs = context.vSongs
                        .Where(s =>
                            (s.Genre.Contains(TreeViewLogicStates.Genre)) &&
                            (s.Catalog.Contains(TreeViewLogicStates.Catalog)) &&
                            (s.Album.Contains(TreeViewLogicStates.Album)) &&
                            (s.Interpret.Contains(TreeViewLogicStates.Interpret))
                            ).ToList();
                });

                return songs;

            }
            catch (Exception ex)
            {
                Debug.Print($"GetTablogicalResultsAsync: {ex.Message}");
                return null;
            }
        }

        public static List<vSong> GetTablogicalResults()
        {
            List<vSong> songs = null;

            try
            {
                var context = new MyJukeboxEntities();
                songs = context.vSongs
                    .Where(s =>
                        (s.Genre.Contains(TreeViewLogicStates.Genre)) &&
                        (s.Catalog.Contains(TreeViewLogicStates.Catalog)) &&
                        (s.Album.Contains(TreeViewLogicStates.Album)) &&
                        (s.Interpret.Contains(TreeViewLogicStates.Interpret))
                        ).ToList();

                return songs;
            }
            catch (Exception ex)
            {
                Debug.Print($"GetTablogicalResultsAsync: {ex.Message}");
                return null;
            }
        }

        internal static List<tColumn> GetColumsWidth()
        {
            var context = new MyJukeboxEntities();
            var result = context.tColumns
                            .Select(c => c).ToList();

            return result;
        }

        public static void SetRating(int id, int rating)
        {
            var context = new MyJukeboxEntities();
            var result = context.tInfos.SingleOrDefault(s => s.ID_Song == id);

            if (result != null)
            {
                result.Rating = rating;
                context.SaveChanges();
            };
        }

        public static void SetColumnWidth(string name, int width)
        {
            var context = new MyJukeboxEntities();
            var result = context.tColumns.SingleOrDefault(n => n.Name == name);

            if (result != null)
                result.Width = width;
            else
                context.tColumns.Add(new tColumn { Name = name, Width = width });

            context.SaveChanges();
        }

        internal static void SetPlaylistLastSelected(int id)
        {
            var context = new MyJukeboxEntities();

            int last = GetLastselectedPlaylist();
            var result = context.tPlaylists.SingleOrDefault(n => n.ID == last);
            if (result != null) result.Last = false;

            result = context.tPlaylists.SingleOrDefault(n => n.ID == id);
            if (result != null) result.Last = true;

            context.SaveChanges();
        }

        internal static int GetLastselectedPlaylist()
        {
            var context = new MyJukeboxEntities();
            var result = context.tPlaylists.SingleOrDefault(n => n.Last == true);

            if (result != null)
                return result.ID;
            else
                return 1;
        }

        internal static PlaylistInfo GetPlaylistInfos(int id)
        {
            PlaylistInfo info = null;

            var context = new MyJukeboxEntities();
            var result = context.tPlaylists.SingleOrDefault(n => n.ID == id);

            if (result != null)
            {
                return info = new PlaylistInfo
                {
                    ID = result.ID,
                    Name = result.Name,
                    Row = result.Row != null ? (int)result.Row : 2,
                    Last = result.Last != null ? (bool)result.Last : false
                };
            }
            else
                return null;
        }

        internal static void SetPlaylistInfos(PlaylistInfo playlist)
        {
            var context = new MyJukeboxEntities();
            var result = context.tPlaylists.SingleOrDefault(n => n.ID == playlist.ID);

            if (result != null)
            {
                if (playlist.Name != null) result.Name = playlist.Name;
                if (playlist.Row != null) result.Row = playlist.Row;
                if (playlist.Last != null) result.Last = playlist.Last;

                context.SaveChanges();
            }
        }

        internal static int GetLastselectedPlaylistRow(int currentPlaylist)
        {
            var context = new MyJukeboxEntities();
            var result = context.tPlaylists.SingleOrDefault(n => n.ID == currentPlaylist);

            if (result != null && result.Row != null)
                return (int)result.Row;
            else
                return 2;
        }

        #endregion

        #region FileScanner
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

        public static bool TruncateTableImportTest()
        {
            try
            {
                var context = new MyJukeboxEntities();
                var result = context.Database.ExecuteSqlCommand("truncate table [tTestImport]");

                return true;
            }
            catch (Exception ex)
            {
                Debug.Print($"TruncateTableImportTest_Error: {ex.Message}");
                return false;
            }

        }
        private static bool MD5Exist(string MD5)
        {
            var context = new MyJukeboxEntities();
            var result = context.tMD5
                            .Where(m => m.MD5 == MD5)
                            .Select(m => m.MD5).ToList();

            if (result.Count > 0)
            {
                Debug.Print($"title allready exist! (MD5={result[0]})");
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int SaveNewRecord(MP3Record record, bool testImport)
        {
            int recordsImported = 0;

            if (testImport == true)
                recordsImported += SetNewTestRecord(record);
            else
            {
                var exist = MD5Exist(record.MD5);

                if (MD5Exist(record.MD5) == false)
                {
                    recordsImported += SetNewRecord(record);
                }
            }
            return recordsImported;
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

                context.tMD5.Add(md5);
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
                Debug.Print("SetNewRecord_Error: {ex.Message}");
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
                //import.Medium = medium;
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
                Debug.Print($"SetNewTestRecord_Error: {ex.Message}");
                Logging.Log(ex.Message);
                return 0;
            }
        }
        #endregion

        #region EditForm
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
            catch (Exception ex)
            {
                return false;
            }
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

        public static List<string> GetFileRecord(int id)
        {
            var context = new MyJukeboxEntities();
            var files = context.tFileInfoes
                            .Where(f => f.ID_Song == id)
                            .Select(f => new { f.FileSize, f.FileDate, f.Duration }).ToList();

            List<string> list = new List<string>();
            list.Add(files[0].FileSize.ToString());
            list.Add(files[0].FileDate.ToString());
            list.Add(files[0].Duration.ToString());

            return list;
        }

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

        public static List<string> GetInfoRecord(int id)
        {
            var context = new MyJukeboxEntities();
            var infos = context.tInfos
                            .Where(i => i.ID_Song == id)
                            .Select(i => new { i.Beat, i.Comment, i.Media, i.Played, i.Rating, i.Sampler, i.Error }).ToList();

            List<string> list = new List<string>();
            list.Add(infos[0].Beat.ToString());
            list.Add(infos[0].Comment.ToString());
            list.Add(infos[0].Media.ToString());
            list.Add(infos[0].Played.ToString());
            list.Add(infos[0].Rating.ToString());
            list.Add(infos[0].Sampler.ToString());
            list.Add(infos[0].Error.ToString());

            return list;
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
        #endregion

        #region Settings

        public static async Task<List<string>> GetAllSettings()
        {
            // ToDo: implement GetAllSettings
            return null;
        }

        internal static object GetSetting(string name, string init = "0")
        {
            var context = new MyJukeboxEntities();
            var result = context.tSettings.SingleOrDefault(s => s.Name == name);

            if (result != null)
                return result.Value;
            else
                DataGetSet.SetSetting(name, init);
            return init;
        }

        internal static void SetSetting(string name, string value)
        {
            var context = new MyJukeboxEntities();
            var setting = context.tSettings.SingleOrDefault(s => s.Name == name);

            if (setting == null)
                context.tSettings.Add(new tSetting { Name = name, Value = value });
            else
                setting.Value = value;

            context.SaveChanges();
        }
        #endregion

        #region Generell
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

        public static int GetGenreFromString(string genre)
        {
            List<int> genres;
            var context = new MyJukeboxEntities();
            genres = context.tGenres
                        .Where(g => g.Name == genre)
                        .Select(g => g.ID).ToList();

            return genres[0];
        }

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

                    context.tMD5.AddRange(rec);
                    context.SaveChanges();
                });
            }
        }

        #endregion
    }
}
