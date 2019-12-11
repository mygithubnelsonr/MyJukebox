using NRSoft.FunctionPool;
using System;
using System.Collections;
using System.Configuration;

namespace MyJukebox_EF
{
    public class LocalFunctions
    {
        public string GetDatasourceSettings()
        {
            string strPath = "";
            string strName;

            // how to use the app.config file ?
            string cfgFile = ConfigurationManager.AppSettings.Get("Configfile");

            if (cfgFile == String.Empty) cfgFile = "MyJukebox.config";

            XmlH xh = new XmlH();
            // XML File laden
            // this suppose the configfile is located in the root dir
            // and is named MyJukebox.config
            xh.SetFile = cfgFile;
            // Console.WriteLine("ausgabe der daten per helper class\n");
            xh.SetNode = "Database/Name";
            strName = xh.GetNodeValue;

            // Console.WriteLine("Databasename = {0}", strName);
            xh.SetNode = "Database/Path";
            strPath = xh.GetNodeValue;
            string strFullPath;

            if (strPath == String.Empty || strPath == ".")
            {
                strPath = AppDomain.CurrentDomain.BaseDirectory;
            }

            if (strPath.IndexOf(":") == -1)     // database path is relative, start dir is appsdir
            {
                strFullPath = AppDomain.CurrentDomain.BaseDirectory + strPath;
            }
            else
            {
                strFullPath = strPath;
            }

            xh = null;
            // MyFunctions mf = new MyFunctions();
            GeneralH gh = new GeneralH();
            string datasource = gh.ValidatePath(strFullPath) + strName;
            // mf = null;
            return datasource;
        }

        public ArrayList GetDbColumnsNames()
        {
            ArrayList cols = new ArrayList();
            string cfgFile = ConfigurationManager.AppSettings.Get("Configfile");
            if (cfgFile == String.Empty) cfgFile = "MyJukebox.config"; // standart config file name

            XmlH xh = new XmlH();
            // XML File laden
            // this suppose the configfile is located in the root dir
            // and is named MyJukebox.config
            xh.SetFile = cfgFile;
            // Console.WriteLine("ausgabe der daten per helper class\n");
            xh.SetNode = "Database/Columns/Captions";
            string strCols = xh.GetNodeValue;
            xh = null;
            string[] ar = strCols.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            cols.AddRange(ar);

            return cols;
        }

        public string GetDatasbaseName()
        {
            // how to use the app.config file ?
            string cfgFile = ConfigurationManager.AppSettings.Get("Configfile");
            if (cfgFile == String.Empty) cfgFile = "MyJukebox.config";

            XmlH xh = new XmlH();
            // XML File laden
            // this suppose the configfile is located in the application root
            // and is named MyJukebox.config
            xh.SetFile = cfgFile;
            // Console.WriteLine("ausgabe der daten per helper class\n");
            xh.SetNode = "Database/Name";
            string strName = xh.GetNodeValue;
            return strName; // string xh.getNodeValue;
        }

    }
}
