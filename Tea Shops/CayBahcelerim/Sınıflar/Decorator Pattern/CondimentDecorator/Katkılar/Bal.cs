using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Decorator_Pattern.CondimentDecorator.İcerikler
{
    class Bal : IcecekSinif
    {
        IcecekSinif icecek;

        public Bal(IcecekSinif icecek)
        {
            this.icecek = icecek;
        }

        public override string Aciklama
        {
            get
            {
                return "Ballı " + icecek.Aciklama;
            }
        }

        public override double Ucret()
        {
            return 0.35 + icecek.Ucret();
        }

        public override string ToString()
        {
            return Aciklama;
        }
    }
}
