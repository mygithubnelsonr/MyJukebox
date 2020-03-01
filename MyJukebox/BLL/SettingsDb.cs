using MyJukebox_EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyJukebox_EF.BLL
{
    public class SettingsDb
    {
        private static List<Setting> _settings = new List<Setting>();

        #region public properties

        public static SortedList<string, int> DatagridColums = new SortedList<string, int>();
        // Query
        public static List<string> QueryList = new List<string>();
        //public static string LastQuery { get; set; }
        //public static int QueryCount { get; set; }
        //public static string QueryLastQuery { get; set; }
        //public static int QueryLastSelected { get; set; }
        // DatagridView
        public static int DatagridLastSelectedRow { get; set; }
        // Filescanner
        public static int FilescannerHeight { get; set; }
        public static int FilescannerLeft { get; set; }
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
        // Treeview
        public static string LastAlbum { get; set; }
        public static string LastGenre { get; set; }
        public static string LastInterpret { get; set; }
        public static string LastCatalog { get; set; }
        // PlayList
        public static int PlaylistCurrentID { get; set; }
        public static string PlaylistCurrentName { get; set; }
        public static int PlaylistCurrentSelected { get; set; }
        // other settings
        public static int LastTab { get; set; }
        public static string laceHolderText = $"< Input SQL like Album='V8-A-1' >";
        public static bool IsRandom { get; set; }
        public static string ImagePath = "_Image";
        public static string RootImagePath { get; set; }
        public static int Volume { get; set; }

        #endregion public properties

        #region CTOR
        static SettingsDb()
        {
            var context = new MyJukeboxEntities();
            var result = context.tSettings
                            .Select(s => s).ToList();

            foreach (var s in result)
                _settings.Add(new Setting { Name = s.Name, Value = s.Value });

        }
        #endregion

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

        public static void Initalaze()
        {
            var firstRun = GetSetting("FirstRunDate");

            if (String.IsNullOrEmpty(firstRun.ToString()))
            {
                SetSetting("FirstRunDate", DateTime.UtcNow.ToString());
                SetSetting("LastSelectedTab", "0");
                SetSetting("ImagePath", "_Images");
                SetSetting("RootImagePath", @"\\win2k16dc01\FS012");
                SetSetting("LastGenre", "");
                SetSetting("LastCatalog", "");
                SetSetting("LastAlbum", "");
                SetSetting("LastInterpret", "");
                SetSetting("LastQuery", "");
                SetSetting("DatagridLastSelectedRow", "1");
            }
        }

        public static void Load()
        {
            LastTab = Convert.ToInt16(GetSetting("LastSelectedTab", "0"));
            DatagridLastSelectedRow = Convert.ToInt16(GetSetting("DatagridLastSelectedRow", "1"));
            //LastQuery = Convert.ToString(GetSetting("LastQuery", ""));
            IsRandom = Convert.ToBoolean(GetSetting("IsRandom", "False"));
            Volume = Convert.ToInt32(GetSetting("Volume", "0"));
            LastAlbum = Convert.ToString(GetSetting("LastAlbum", "Alle"));
            LastCatalog = Convert.ToString(GetSetting("LastCatalog", "Alle"));
            LastGenre = Convert.ToString(GetSetting("LastGenre", "Alle"));
            LastInterpret = Convert.ToString(GetSetting("LastInterpret", "Alle"));
            FormTop = Convert.ToInt16(GetSetting("FormTop", "100"));
            FormLeft = Convert.ToInt16(GetSetting("FormLeft", "100"));
            FormWidth = Convert.ToInt16(GetSetting("FormWidth", "836"));
            FormHeight = Convert.ToInt16(GetSetting("FormHeight", "580"));
            FormSplitterLeft = Convert.ToInt16(GetSetting("FormSplitterLeft", "200"));
            FormState = Convert.ToString(GetSetting("FormState", "Normal"));
            RootImagePath = Convert.ToString(GetSetting("RootImagePath", "C:\\"));

            QueryList = DataGetSet.GetQueryList();
        }

        public static void Save()
        {
            var context = new MyJukeboxEntities();
            foreach (Setting s in _settings)
            {
                var update = context.tSettings.SingleOrDefault(n => n.Name == s.Name);
                update.Value = s.Value;
            }
            context.SaveChanges();

            var result = DataGetSet.TruncateTableQueries();
            foreach (string query in QueryList)
            {
                context.tQueries.Add(new tQuery { Query = query });
            }

            context.SaveChanges();
        }

        public static void SetSetting(string name, object value)
        {
            var setting = _settings.Single(s => s.Name == name);
            setting.Value = value.ToString();
        }

        internal static object GetSetting(string name, string init = "0")
        {
            var result = _settings.SingleOrDefault(n => n.Name == name);

            if (result != null)
                return result.Value;
            else
                SetSetting(name, init);

            return init;
        }
    }

    internal class Setting
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

}
