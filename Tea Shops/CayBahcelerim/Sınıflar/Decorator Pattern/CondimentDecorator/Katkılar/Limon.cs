using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Decorator_Pattern.CondimentDecorator.İcerikler
{
    class Limon : KatkiDecorator
    {
        IcecekSinif icecek;

        public Limon(IcecekSinif icecek)
        {
            this.icecek = icecek;
        }

        public override string Aciklama
        {
            get
            {
                    return "Limonlu " + icecek.Aciklama;

            }
        }

        public override double Ucret()
        {
            return 0.20 + icecek.Ucret();
        }

        public override string ToString()
        {
            return Aciklama;
        }
    }
}
