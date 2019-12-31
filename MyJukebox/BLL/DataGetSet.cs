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
                genres = context.vSongsNewShorts
                    .Select(g => g.Genre).Distinct().OrderBy(g => g).ToList();
            });
            return genres;
        }

        public static async Task<List<string>> GetKatalogsAsync()
        {
            List<string> catalogues = null;

            using (var context = new MyJukeboxEntities())
            {
                await Task.Run(() =>
                {
                    catalogues = context.vSongsNewShorts
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
                    albums = context.vSongsNewShorts
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
                    interprer = context.vSongsNewShorts
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

        public static async Task<List<vSongsNewShort>> GetTablogicalResultsAsync()
        {
            List<vSongsNewShort> songs = null;

            try
            {
                var genre = Settings.LastGenre == "Alle" ? "" : Settings.LastGenre;
                var album = Settings.LastAlbum == "Alle" ? "" : Settings.LastAlbum;
                var catalog = Settings.LastKatalog == "Alle" ? "" : Settings.LastKatalog;
                var artist = Settings.LastInterpret == "Alle" ? "" : Settings.LastInterpret;

                var context = new MyJukeboxEntities();
                await Task.Run(() =>
                {
                    songs = context.vSongsNewShorts
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

        public static bool SaveNewRecord(MP3Record record, bool testImport)
        {
            bool results = false;

            if (testImport == true)
                results = SetNewTestRecord(record);
            else
                results = SetNewRecord(record);
            return results;
        }

        private static bool SetNewRecord(MP3Record record)
        {
            try
            {
                var context = new MyJukeboxEntities();
                var import = new tSong();

                import.Album = record.Album;
                import.FileDate = record.FileDate;
                import.FileName = record.FileName;
                import.FileSize = record.FileSize;
                import.Genre = record.Genre;
                import.Interpret = record.Interpret;
                import.Katalog = record.Katalog;

                import.Medium = record.Media;
                import.Pfad = record.Path;
                import.Titel = record.Titel;
                import.ImportDate = DateTime.Now;

                context.tSongs.Add(import);
                context.SaveChanges();


                // get last tSong ID needed for tMd5 and tInfos

                //import.MD5 = record.MD5;
                //import.IsSampler = record.IsSample;


                return true;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }
        }

        private static bool SetNewTestRecord(MP3Record record)
        {
            try
            {
                var context = new MyJukeboxEntities();
                var import = new tTestImport();

                import.Album = record.Album;
                import.FileDate = record.FileDate;
                import.FileName = record.FileName;
                import.FileSize = record.FileSize;
                import.Genre = record.Genre;
                import.Interpret = record.Interpret;
                import.Katalog = record.Katalog;
                import.MD5 = record.MD5;
                import.Medium = record.Media;
                import.Pfad = record.Path;
                import.IsSampler = record.IsSample;
                import.Titel = record.Titel;
                import.ImportDate = DateTime.Now;

                context.tTestImports.Add(import);
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }
        }

        #endregion

        // Generell
        public static int GetLastSongID(string tableName)
        {
            int lastId = -1;

            var context = new MyJukeboxEntities();

            if (tableName == "tTestImport")
                lastId = context.tTestImports.Max(x => x.ID);

            if (tableName == "tSongs")
                lastId = context.tSongs.Max(x => x.ID);

            return lastId;
        }
    }
}
