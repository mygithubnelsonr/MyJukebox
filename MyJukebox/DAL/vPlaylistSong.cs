//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyJukebox_EF.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class vPlaylistSong
    {
        public int ID { get; set; }
        public string Titel { get; set; }
        public string Interpret { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public string Katalog { get; set; }
        public string Medium { get; set; }
        public Nullable<int> Gespielt { get; set; }
        public string Pfad { get; set; }
        public string FileName { get; set; }
        public int PLID { get; set; }
        public int Pos { get; set; }
    }
}
