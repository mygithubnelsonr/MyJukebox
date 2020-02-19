﻿using MyJukebox_EF.BLL;
using NRSoft.FunctionPool;
using System;
using System.Collections.Generic;

namespace MyJukebox_EF.NotUsed
{
    [Serializable]
    public class Settings
    {
        private static MyJukebox form = new MyJukebox();
        private static RegistryH rh;

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

        public Settings()
        {
            CompanyName = "NoName";
            ProductName = "NRSoft";

            rh = new RegistryH(
                Properties.Settings.Default.CompanyName,
                Properties.Settings.Default.ProductName
            );
        }

        public static void FilescannerLoad()
        {
            FilescannerTop = Convert.ToInt16(rh.GetSetting(@"Settings\Filescanner", "Top", "100"));
            FilescannerLeft = Convert.ToInt16(rh.GetSetting(@"Settings\Filescanner", "Left", "100"));
            FilescannerWidth = Convert.ToInt16(rh.GetSetting("Settings\\Filescanner", "Width", "440"));
            FilescannerHeight = Convert.ToInt16(rh.GetSetting("Settings\\Filescanner", "Height", "540"));
        }

        public static void Initialize()
        {

            rh = new RegistryH(
                Properties.Settings.Default.CompanyName,
                Properties.Settings.Default.ProductName
            );

            //string firstRunDate = rh.GetSetting("", "FirstRunDate", "");
            string firstRunDate = DataGetSet.GetSetting("FirstRunDate").ToString();
            if (string.IsNullOrEmpty(firstRunDate))
            {
                DataGetSet.SetSetting("CompanyName", Properties.Settings.Default.CompanyName);
                DataGetSet.SetSetting("ProductName", Properties.Settings.Default.ProductName);
                DataGetSet.SetSetting("FirstRunDate", DateTime.UtcNow.ToString());
                DataGetSet.SetSetting("LastTab", "0");
                DataGetSet.SetSetting("ImagePath", "_Images");
                DataGetSet.SetSetting("RootImagePath", @"\\win2k16dc01\FS012");
                DataGetSet.SetSetting("LastGenre", "");
                DataGetSet.SetSetting("LastKatalog", "");
                DataGetSet.SetSetting("LastAlbum", "");
                DataGetSet.SetSetting("LastInterpret", "");
                DataGetSet.SetSetting("LastQuery", "");
                DataGetSet.SetSetting("QueryCount", "0");
            }
        }

        public static void Load()
        {
            #region public properties

            CompanyName = Properties.Settings.Default.CompanyName;
            ProductName = Properties.Settings.Default.ProductName;
            Version = Properties.Settings.Default.Version;

            #endregion public properties

            #region Form Settings

            // minwidth=836; minheight=580
            FormState = rh.GetSetting(@"Settings\Form", "State", "Normal");
            FormTop = Convert.ToInt16(rh.GetSetting(@"Settings\Form", "Top", "100"));
            FormLeft = Convert.ToInt16(rh.GetSetting(@"Settings\Form", "Left", "100"));
            FormWidth = Convert.ToInt16(rh.GetSetting("Settings\\Form", "Width", "836"));
            FormHeight = Convert.ToInt16(rh.GetSetting("Settings\\Form", "Height", "580"));
            FormSplitterLeft = Convert.ToInt16(rh.GetSetting("Settings\\Form", "Splitter", "200"));

            #endregion Form Settings

            #region Treeview Settings

            //LastGenre = rh.GetSetting("Settings\\Logical\\Genre", "LastGenre", "");
            //LastKatalog = rh.GetSetting("Settings\\Logical\\Katalog", "LastKatalog", "");
            //LastAlbum = rh.GetSetting("Settings\\Logical\\Album", "LastAlbum", "");
            //LastInterpret = rh.GetSetting("Settings\\Logical\\Interpret", "LastInterpret", "");
            //PlaylistCurrentName = rh.GetSetting("Settings\\Playlists", "LastPlaylist", "");
            //PlaylistCurrentID = Convert.ToInt16(rh.GetSetting("Settings\\Playlists", "LastID", "0"));
            //PlaylistCurrentSelected = Convert.ToInt16(rh.GetSetting("Settings\\Playlists", "LastSelected", "0"));

            #endregion Treeview Settings

            #region DatagridView Settings

            DatagridLastSelectedRow = Convert.ToInt16(rh.GetSetting("Settings\\Logical", "LastSelected", "0"));

            //string[,] arReg = rh.GetAllSettings("Settings\\Grid\\ColDefs");
            //for (int x = 0; x < (arReg.Length / 2) - 1; x++)
            //{
            //    string columnName = arReg[x, 0];
            //    int columnWidth = Convert.ToInt16(arReg[x, 1]);
            //    DatagridColums.Add(columnName, columnWidth);
            //}

            #endregion DatagridView Settings

            #region Query Settings

            //QueryCount = Convert.ToInt16(rh.GetSetting("Settings\\Queries", "Count", "0"));
            //QueryLastQuery = rh.GetSetting("Settings\\Queries", "LastQuery", "");
            QueryList = rh.GetAllSettings("Settings\\Queries\\List", true);

            #endregion Query Settings

            #region Other Settings

            Volume = Convert.ToInt32(rh.GetSetting(@"Settings", "Volume", "0"));
            IsRandom = Convert.ToBoolean(rh.GetSetting(@"Settings", "Random", "false"));
            LastTab = Convert.ToInt16(rh.GetSetting(@"Settings", "LastTab", "0"));
            ForbChars = rh.GetSetting("Settings", "ForbChars", @"\\/:?");
            ImagePath = rh.GetSetting("Settings", "ImagePath", "_Images");
            //RootImagePath = rh.GetSetting("Settings", "RootImagePath", @"\\win2k16dc01\FS012");
            RootImagePath = rh.GetSetting("Settings", "RootImagePath", @"A:\Temp");

            #endregion Other Settings
        }

        public static void Save()
        {
            #region Form Settings

            rh.SaveSetting("Settings\\Form", "Width", FormWidth.ToString());
            rh.SaveSetting("Settings\\Form", "Height", FormHeight.ToString());
            rh.SaveSetting("Settings\\Form", "Top", FormTop.ToString());
            rh.SaveSetting("Settings\\Form", "Left", FormLeft.ToString());
            rh.SaveSetting("Settings\\Form", "State", FormState.ToString());
            rh.SaveSetting("Settings\\Form", "Splitter", FormSplitterLeft.ToString());

            #endregion Form Settings

            #region Treeview Settings

            //rh.SaveSetting("Settings\\Logical\\Genre", "LastGenre", LastGenre);
            //rh.SaveSetting("Settings\\Logical\\Katalog", "LastKatalog", LastKatalog);
            //rh.SaveSetting("Settings\\Logical\\Album", "LastAlbum", LastAlbum);
            //rh.SaveSetting("Settings\\Logical\\Interpret", "LastInterpret", LastInterpret);
            //rh.SaveSetting("Settings\\Logical", "LastQuery", QueryLastQuery);
            //rh.SaveSetting("Settings\\Logical", "LastSelected", QueryLastSelected.ToString());
            //rh.SaveSetting("Settings\\Playlists", "LastID", PlaylistCurrentID.ToString());
            //rh.SaveSetting("Settings\\Playlists", "LastPlaylist", PlaylistCurrentName);
            //rh.SaveSetting("Settings\\Playlists", "LastSelected", PlaylistCurrentSelected.ToString());

            #endregion Treeview Settings

            #region DatagridView Settings

            rh.SaveSetting("Settings\\Logical", "LastSelected", DatagridLastSelectedRow.ToString());
            //foreach (var c in DatagridColums) rh.SaveSetting("Settings\\Grid\\ColDefs", c.Key, c.Value.ToString());

            #endregion DatagridView Settings

            #region Query Settings

            //rh.SaveSetting("Settings\\Queries", "Count", QueryCount.ToString());
            rh.SaveSetting("Settings\\Queries", "LastQuery", QueryLastQuery);
            //rh.SaveSetting(@"Settings\Queries", "LastSelected", QueryLastSelected.ToString());
            foreach (var q in QueryList) rh.SaveSetting("Settings\\Queries\\List", q);

            #endregion Query Settings

            #region Other Settings

            rh.SaveSetting("Settings", "Random", IsRandom.ToString());
            rh.SaveSetting(@"Settings", "LastTab", LastTab.ToString());
            rh.SaveSetting("Settings", "Volume", Volume.ToString());
            rh.SaveSetting("Settings", "ForbChars", ForbChars);
            rh.SaveSetting("Settings", "ImagePath", ImagePath);
            rh.SaveSetting("Settings", "RootImagePath", RootImagePath);

            #endregion Other Settings
        }
    }
}