using CayBahcelerim.Sınıflar.Abstract_Factory_Pattern;
using CayBahcelerim.Sınıflar.Observer_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Tost
{
    class KasarliTost : TostSinif, IObserver
    {
        readonly Iicindekiler icindekiler;
        FiyatListesi fy;
        double ucret;

        public KasarliTost(Iicindekiler ici)
        {
            icindekiler = ici;
            aciklama = "Kasarli Tost";
            fy = new FiyatListesi();
            fy.RegisterObserver(this);
        }

        public override string Aciklama => aciklama;
        

        public void guncelle(double kar, double kas, double ayv, double cay, double ora, double ihl)
        {
            ucret= kas;
        }

        public override double Ucret()
        {
            return ucret;
        }

        public override string ToString()
        {
            return "Kaşarlı Tost";
        }
    }
}
