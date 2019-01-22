namespace Otel.AbstractFactoryPattern
{
    public class SinemaOdasi
    {
        private OrtamIsigi ortamIsigi;
        private Dvd dvd;
        private DvdPlayer dvdPlayer;

        public SinemaOdasi(OrtamIsigi ortamIsigi, Dvd dvd, DvdPlayer dvdPlayer)
        {
            dvd.Film = "Film Secilmedi";
            this.dvd = dvd;
            this.ortamIsigi = ortamIsigi;
            this.dvdPlayer = dvdPlayer;
        }

        public void FilmSec(string isim)
        {
            dvd.Film = isim;
        }


        public void Filmİzle()
        {
            ortamIsigi.Isik(5);
            dvdPlayer.On();
            dvdPlayer.FilmKoy(dvd);
            dvdPlayer.Oynat();
        }

        public void Durdur()
        {
            ortamIsigi.Isik(10);
            dvdPlayer.Durdur();
        }

        public void DevamEt()
        {
            ortamIsigi.Isik(5);
            dvdPlayer.DevamEt();
        }
    }
}