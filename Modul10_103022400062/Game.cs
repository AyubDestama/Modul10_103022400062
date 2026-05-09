namespace Modul10_103022400062
{
    public class Game
        {
            public int id { get; set; }
            public string Nama { get; set; }
            public string Developer { get; set; }
            public int TahunRilis { get; set; }
            public string Genre { get; set; }
            public double Rating { get; set; }
            public string[] Platform { get; set; }
            public string[] Mode { get; set; }
            public bool IsOnline { get; set; }
            public int Harga { get; set; }

            public Game(int id, string Nama, string Developer, int TahunRilis, string Genre, double Rating, string[] Platform, string[] Mode, bool IsOnline, int Harga)
        {
            this.id = 0;
            this.Nama = Nama;
            this.Developer = Developer;
            this.TahunRilis = TahunRilis;
            this.Genre = Genre;
            this.Rating = Rating;
            this.Platform = Platform;
            this.Mode = Mode;
            this.IsOnline = IsOnline;
            this.Harga = Harga;
            }
        }
}
