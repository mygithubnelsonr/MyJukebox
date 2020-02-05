namespace MyJukebox_EF.BLL
{
    public class PlaylistInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool? Last { get; set; }
        public int? Row { get; set; }
    }
}
