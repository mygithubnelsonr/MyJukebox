using MyJukebox_EF.BLL;
using MyJukebox_EF.DAL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oldstuff
{
    public class Oldstuff
    {
        private async Task FillDatagridViewAsynk(string filter = "")
        {
            //    int lastRow = 0;

            //    #region FillDatagridByQuery

            //    if (Methods.IsQuery(filter) == true)
            //    {
            //        await FillDatagridByQueryAsync();
            //        return;
            //    }

            //    #endregion FillDatagridByQuery

            //    #region FillDatagrid by Logical Tab

            //    if (tabControl.SelectedTab == tabLogical)
            //        await FillDatagridByTabLogicalAsync();

            //    #endregion FillDatagrid by Logical Tab

            //    #region Fill Datagrid by Playlist

            //    var x = tabControl.SelectedTab.Text;
            //    var y = tabPlayLists.Text;

            //    if (tabControl.SelectedTab == tabPlayLists)
            //    {
            //        Debug.Print("calling FillDatagridByTabPlaylist");
            //        await FillDatagridByTabPlaylistAsync();

            //        int playlistID = (int)tvplaylist.SelectedNode.Tag;

            //        PlaylistInfo info = new PlaylistInfo();
            //        info = DataGetSet.GetLastselectedPlaylistInfos(playlistID);
            //        lastRow = (int)info.Row;
            //    }
            //    #endregion Fill Datagrid by Playlist

            //    Debug.Print("back from FillDatagridByTabPlaylist");

            //    #region format datagridview

            //    try
            //    {

            //        if (dataGridView.RowCount > 0)
            //        {
            //            GridViewSetColumsWidth();
            //            dataGridView.Rows[lastRow].Selected = true;
            //        }

            //        if (dataGridView.CurrentRow != null)
            //        {
            //            dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.SelectedRows[0].Index;
            //            statusStripRow.Text = Convert.ToString(dataGridView.CurrentRow.Index + 1);
            //            statusStripRowcount.Text = dataGridView.RowCount.ToString();
            //        }

            //        dataGridView.Columns["ID"].Visible = false;
            //        dataGridView.ResumeLayout();
            //    }
            //    catch (Exception ex)
            //    {
            //        Debug.Print($"FillDatagridView_Error: {ex.Message}");
            //    }

            //    Settings.QueryLastQuery = "";
            //    statusStripTitel.Text = "";
            //    random.InitRandomNumbers(dataGridView.RowCount - 1);

            //    #endregion format datagridview

        }

        private async Task FillDatagridByTabLogicalAsync()
        {
            //var results = await DataGetSet.GetTablogicalResultsAsync();

            //dataGridView.SuspendLayout();
            //dataGridView.DataSource = results;
            //dataGridView.ResumeLayout();

            //int lastselectedRow = Convert.ToInt32(DataGetSet.GetSetting("DatagridLastSelectedRow"));
            //dataGridView.Rows[lastselectedRow].Selected = true;
        }

        private async Task FillDatagridByQueryAsync()
        {
            //int currentDatagrigRow = 0;
            //if (Settings.LastTab == (int)TabcontrolTab.Logical)
            //    currentDatagrigRow = 1;

            //var results = await DataGetSet.GetQueryResultAsync(textBoxSearch.Text);
            //dataGridView.DataSource = results;

            //if (dataGridView.RowCount > 0)
            //{
            //    dataGridView.Columns["ID"].Visible = false;
            //    GridViewSetColumsWidth();
            //    dataGridView.CurrentCell = dataGridView[1, currentDatagrigRow];
            //    statusStripRow.Text = Convert.ToString(currentDatagrigRow + 1);
            //}
        }

        public async Task<List<Playlist>> GetPlaylistsAsync()
        {
            return null;

            //List<Playlist> playLists = new List<Playlist>();

            //using (var context = new MyJukeboxEntities())
            //{
            //    await Task.Run(() =>
            //    {
            //        var playlists = context.tPlaylists
            //                     .OrderBy(p => p.Name)
            //                     .Select(p => new { p.ID, p.Name, p.Row });

            //        foreach (var p in playlists)
            //        {
            //            playLists.Add(new Playlist { ID = p.ID, Name = p.Name, Pos = p.Row });
            //        }

            //    });

            //    return playLists;
            //}
        }

        public static async Task<List<vSong>> GetQueryResultAsync(string queryText)
        {
            return null;

            //List<vSong> songs = null;

            //try
            //{
            //    string sql = Methods.GetQueryString(queryText);

            //    var context = new MyJukeboxEntities();
            //    await Task.Run(() =>
            //    {
            //        songs = context.vSongs
            //                  .SqlQuery(sql).ToList();

            //    });

            //    return songs;
            //}
            //catch (Exception ex)
            //{
            //    Debug.Print($"GetQueryResultAsync: {ex.Message}");
            //    return null;
            //}
        }

    }
}