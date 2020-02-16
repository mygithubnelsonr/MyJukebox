using MyJukebox_EF.BLL;
using System.Collections.Generic;
using System.IO;

namespace MyJukebox_EF
{
    public class ImageCollector
    {
        private string _imagePath = "";
        private string _artist = "";
        private List<string> _pathList;

        public ImageCollector(List<string> pathlist, string artist)
        {
            _pathList = pathlist;
            _artist = artist.ToLower();
            _imagePath = DataGetSet.GetSetting("ImagePath", "_Images").ToString();
        }

        public List<string> GetImagesFullName()
        {
            List<string> artists = new List<string>();

            foreach (var path in _pathList)
            {
                var di = new DirectoryInfo(path);
                if (di.Exists)
                {
                    var files = di.GetFiles();
                    var isImagePath = (di.Name.ToLower().IndexOf(_imagePath.ToLower()) > -1) ? true : false;

                    foreach (var file in files)
                    {
                        if (isImagePath)
                        {
                            if (file.Name.ToLower().IndexOf(_artist) > -1)
                                artists.Add(file.FullName);
                        }
                        else
                        {
                            var fileName = file.Name.ToLower();
                            var extension = file.Extension.ToLower();

                            if (extension == ".jpg" || extension == ".png" || extension == ".bmp")
                            {
                                artists.Add(file.FullName);
                            }
                        }
                    }
                }
            }
            return artists;
        }
    }
}
