using System.Drawing;

namespace MyJukebox_EF
{
    public class Colors
    {
        public static Color Playing { get; set; }
        public static Color NotFound { get; set; }
        public static Color Nutreal { get; set; }
        public static Color Played { get; set; }
        public static Color Standard { get; set; }

        public Colors()
        {
            Playing = Color.FromArgb(116, 237, 255);
            NotFound = Color.FromArgb(255, 199, 206);
            Nutreal = Color.FromArgb(255, 235, 156);
            Played = Color.FromArgb(198, 239, 206);
            Standard = Color.Black;
        }

        public static void Initialize()
        {
            Playing = Color.FromArgb(116, 237, 255);
            NotFound = Color.FromArgb(255, 199, 206);
            Nutreal = Color.FromArgb(255, 235, 156);
            Played = Color.FromArgb(198, 239, 206);
            Standard = Color.Black;
        }
    }
}
