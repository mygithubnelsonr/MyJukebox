using MyJukebox_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyJukebox_EF.BLL
{
    public class SettingsDb
    {
        public static int Formstate(string state)
        {
            int _state = 0;

            switch (state)
            {
                case "Normal":
                    _state = 0;
                    break;
                case "Minimized":
                    _state = 1;
                    break;
                case "Maximized":
                    _state = 2;
                    break;
            }
            return _state;
        }

        public static List<Setting> Settings = new List<Setting>();

        #region public properties
        public static string PlaceHolderText = $"< Input SQL like Album='V8-A-1' >";
        public static SortedList<string, int> DatagridColums = new SortedList<string, int>();
        // Query
        public static List<string> QueryList = new List<string>();

        public static string CompanyName { get; set; }
        // DatagridView
        public static int DatagridLastSelectedRow { get; set; }

        public static int FilescannerHeight { get; set; }
        public static int FilescannerLeft { get; set; }
        // Filescanner
        public static int FilescannerTop { get; set; }
        public static int FilescannerWidth { get; set; }
        public static string ForbChars { get; set; }
        // Form
        public static int FormHeight { get; set; }
        public static int FormLeft { get; set; }
        public static int FormSplitterLeft { get; set; }
        public static string FormState { get; set; }
        public static int FormTop { get; set; }
        public static int FormWidth { get; set; }
        public static string ImagePath { get; set; }
        // other settings
        public static bool IsRandom { get; set; }

        public static string LastAlbum { get; set; }
        // Treeview
        public static string LastGenre { get; set; }

        public static string LastInterpret { get; set; }
        public static string LastKatalog { get; set; }
        public static string LastRunDate { get; set; }
        public static int LastTab { get; set; }
        public static int PlaylistCurrentID { get; set; }
        // PlayList
        public static string PlaylistCurrentName { get; set; }

        public static int PlaylistCurrentSelected { get; set; }
        public static string ProductName { get; set; }
        public static int QueryCount { get; set; }
        public static string QueryLastQuery { get; set; }
        public static int QueryLastSelected { get; set; }
        public static string RootImagePath { get; set; }
        public static string Version { get; set; }
        public static int Volume { get; set; }
        #endregion public properties

        public SettingsDb()
        {
            var context = new MyJukeboxEntities();

            var result = context.tSettings
                            .Select(s => s).ToList();

            foreach (var s in result)
                Settings.Add(new Setting { ID = s.ID, Name = s.Name, Value = s.Value });
        }

        public static void Initalaze()
        {
            var firstRun = DataGetSet.GetSetting("FirstRunDate");

            if (String.IsNullOrEmpty(firstRun.ToString()))
            {
                DataGetSet.SetSetting("FirstRunDate", DateTime.UtcNow.ToString());
                DataGetSet.SetSetting("LastSelectedTab", "0");
                DataGetSet.SetSetting("ImagePath", "_Images");
                DataGetSet.SetSetting("RootImagePath", @"\\win2k16dc01\FS012");
                DataGetSet.SetSetting("LastGenre", "");
                DataGetSet.SetSetting("LastCatalog", "");
                DataGetSet.SetSetting("LastAlbum", "");
                DataGetSet.SetSetting("LastInterpret", "");
                DataGetSet.SetSetting("LastQuery", "");
                DataGetSet.SetSetting("DatagridLastSelectedRow", "1");
            }
        }

        public static void Load()
        {
            #region Form Settings

            // minwidth=836; minheight=580
            FormState = DataGetSet.GetSetting("FormState", "Normal").ToString();
            FormTop = Convert.ToInt16(DataGetSet.GetSetting("FormTop", "100"));
            FormLeft = Convert.ToInt16(DataGetSet.GetSetting("FormLeft", "100"));
            FormWidth = Convert.ToInt16(DataGetSet.GetSetting("FormWidth", "836"));
            FormHeight = Convert.ToInt16(DataGetSet.GetSetting("FormHeight", "580"));
            FormSplitterLeft = Convert.ToInt16(DataGetSet.GetSetting("FormSplitterLeft", "200"));
            DatagridLastSelectedRow = Convert.ToInt16(DataGetSet.GetSetting("DatagridLastSelectedRow", "1"));

            #endregion Form Settings
        }

        public static void Save()
        {

        }
    }

    public class Setting
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
