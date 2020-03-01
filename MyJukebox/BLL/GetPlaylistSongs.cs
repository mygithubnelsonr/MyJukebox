using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyJukebox_EF.DAL;

namespace MyJukebox_EF.BLL
{
    public class GetPlaylistSongs
    {
        public delegate void GetPlaylistSongsEventHandler(object source, EventArgs args);

        public static event GetPlaylistSongsEventHandler GetPlaylistSongsFinished;

        public async Task<List<vPlaylistSong>> GetPlaylistEntriesAsync(int playlistID)
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


        protected virtual void OnGetPlaylistsongsFinished()
        {
            if (GetPlaylistSongsFinished != null)
                GetPlaylistSongsFinished(this, EventArgs.Empty);
        }


    }
}
