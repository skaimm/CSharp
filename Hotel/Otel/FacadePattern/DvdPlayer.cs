namespace Otel.AbstractFactoryPattern
{
    public class DvdPlayer
    {
        private Dvd dvd;
        public string On() {
            return "PLayer Açıldı.";
        }

        public void FilmKoy(Dvd dvd)
        {
            this.dvd = dvd;
        }

        public string Oynat() {
            return "Devam Ediyor..";
        }

        public string Durdur()
        {
            return "Film Duraklatildi.";
        }

        public string DevamEt()
        {
            return "Film Devam Ediyor.";
        }
    }
}