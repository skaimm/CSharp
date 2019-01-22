﻿using CayBahcelerim.Sınıflar.Observer_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Decorator_Pattern
{
    class Ihlamur : IcecekSinif,IObserver
    {
        FiyatListesi fy;
        double ucret;

        public Ihlamur()
        {
            aciklama = "Ihlamur";
            fy = new FiyatListesi();
            fy.RegisterObserver(this);
        }

        public override string Aciklama => aciklama;

        public void guncelle(double kar, double kas, double ayv, double cay, double ora, double ihl)
        {
            ucret = ihl;
        }

        public override double Ucret()
        {
            return ucret;
        }

        public override string ToString()
        {
            return "Ihlamur"; 
        }
    }
}
