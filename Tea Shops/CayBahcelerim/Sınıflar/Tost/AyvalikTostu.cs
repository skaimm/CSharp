using CayBahcelerim.Sınıflar.Abstract_Factory_Pattern;
using CayBahcelerim.Sınıflar.Observer_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Tost
{
    class AyvalikTostu : TostSinif,IObserver
    {
        FiyatListesi fy;
        readonly Iicindekiler icindekiler;
        double ucret;

        public AyvalikTostu(Iicindekiler ici)
        {
            icindekiler = ici;
            aciklama = "Ayvalık Tostu";
            fy = new FiyatListesi();
            fy.RegisterObserver(this);
        }

        public override string Aciklama => aciklama;

        public override double Ucret()
        {
            return ucret;
        }

        public void guncelle(double kar, double kas, double ayv, double cay, double ora, double ihl)
        {
            ucret = ayv;
        }

        public override string ToString()
        {
            return "Ayvalık Tost";
        }
    }
}
