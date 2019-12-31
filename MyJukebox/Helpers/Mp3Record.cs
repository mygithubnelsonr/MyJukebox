using System;

namespace MyJukebox_EF
{
    public class MP3Record
    {
        public string Katalog { get; set; }
        public string Owner { get; set; }
        public string Media { get; set; }
        public string Album { get; set; }
        public string Interpret { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public DateTime FileDate { get; set; }
        public string MD5 { get; set; }
        public bool IsSample { get; set; }
    }
}
