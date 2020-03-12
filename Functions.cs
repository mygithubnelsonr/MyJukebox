using System;
using System.IO;
//using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using Microsoft.Win32;

namespace MyJukebox
{
    public partial class Renamer
    {
		public string ToProperCase(string sText)
		{
			//Get the culture property of the thread.
			CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
			//Create TextInfo object.
			TextInfo textInfo = cultureInfo.TextInfo;

			return textInfo.ToTitleCase(sText) ;
		}

        public bool IsNumeric(object ValueToCheck)
        {
            double Dummy = new double();
            string InputValue = Convert.ToString(ValueToCheck);

            bool Numeric = double.TryParse(InputValue, System.Globalization.NumberStyles.Any, null, out Dummy);

            return Numeric;
        }

		public void SaveSetting(string subkey, string keyname, string keyvalue)
		{
			RegistryKey rkCurrentUser = Registry.CurrentUser;
			rkCurrentUser.CreateSubKey("Software\\" + gstrProductKey + "\\" + subkey);
			RegistryKey rkSet = rkCurrentUser.OpenSubKey("Software\\" + gstrProductKey + "\\" + subkey, true);
			rkSet.SetValue(keyname, keyvalue, RegistryValueKind.String);
		}


		public string GetSetting(string subkey, string keyname, string keyvalue)
		{
			string regval = "";

			RegistryKey rkCurrentUser = Registry.CurrentUser;
			rkCurrentUser.CreateSubKey("Software\\" + gstrProductKey + "\\" + subkey);
			RegistryKey rkGet = rkCurrentUser.OpenSubKey("Software\\" + gstrProductKey + "\\" + subkey, true);

            try
            {
                RegistryValueKind rvk = rkGet.GetValueKind(keyname);

                if (rvk == RegistryValueKind.String)
                {
                    regval = rkGet.GetValue(keyname).ToString();
                }
                return regval;
            }
            catch
            {
                return keyvalue;
            }
		}

		public bool TouchFile(string fileName, string newfiletime)
		{
			string oldDate;
			bool success = false;

			FileInfo fi = new FileInfo(fileName);

			if (fi.Exists)
			{
				oldDate = fi.CreationTime.ToString();
				//string sT1 = oldDate.Substring(0, oldDate.Length - 2);
				//string sT2 = (sT1 + counter.ToString("00"));
				DateTime dnewDate = DateTime.Parse(newfiletime);

				fi.CreationTime = dnewDate;
				fi.LastAccessTime = dnewDate;
				fi.LastWriteTime = dnewDate;
				//counter++;
				success = true;
			}
			else
			{
				success = false;
			}

			return success;
		}

		//// If the data object in args is a single file, this method will return the filename.
		//// Otherwise, it returns null.
		//public string IsSingleFile(DragEventArgs args)
		//{
		//    // Check for files in the hovering data object.
		//    if (args.Data.GetDataPresent(DataFormats.FileDrop, true))
		//    {
		//        string[] fileNames = args.Data.GetData(DataFormats.FileDrop, true) as string[];
		//        // Check fo a single file or folder.
		//        if (fileNames.Length == 1)
		//        {
		//            // Check for a file (a directory will return false).
		//            if (File.Exists(fileNames[0]))
		//            {
		//                // At this point we know there is a single file.
		//                return fileNames[0];
		//            }
		//        }
		//    }
		//    return null;
		//}
    }
}
