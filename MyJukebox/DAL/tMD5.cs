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
    
    public partial class tMD5
    {
        public int ID { get; set; }
        public int ID_Song { get; set; }
        public string MD5 { get; set; }
    
        public virtual tSong tSong { get; set; }
    }
}
