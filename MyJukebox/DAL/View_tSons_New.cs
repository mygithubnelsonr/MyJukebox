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
    
    public partial class View_tSons_New
    {
        public int ID { get; set; }
        public string Pfad { get; set; }
        public string FileName { get; set; }
        public Nullable<int> ID_File { get; set; }
        public int ID_Song { get; set; }
        public Nullable<int> FileSize { get; set; }
        public Nullable<System.DateTime> FileDate { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public string Link { get; set; }
        public int ID_F { get; set; }
        public Nullable<int> ID_Media { get; set; }
        public string Name { get; set; }
        public int Expr1 { get; set; }
        public Nullable<int> Played { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<int> Beat { get; set; }
        public Nullable<bool> Error { get; set; }
        public Nullable<bool> Sampler { get; set; }
        public string Comment { get; set; }
    }
}
