using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Abstract_Factory_Pattern
{
    internal class TaksimSube : Iicindekiler
    {
        public IKasar CreateKasar()
        {
            return new EskiKasar();
        }

        public ISalam CreateSalam()
        {
            return new PilicSalam();
        }

        public ISucuk CreateSucuk()
        {
            return new KangalSucuk();
        }

        IEnumerable<IEkstralar> Iicindekiler.CreateEkstra()
        {
            IEkstralar[] eks = { new Hardal(), new Tursu() };
            return eks;
        }
    }
}
