using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Abstract_Factory_Pattern
{
    internal class KadikoySube : Iicindekiler
    {
        public IKasar CreateKasar()
        {
            return new BlokKasar();
        }

        public ISalam CreateSalam()
        {
            return new HindiSalam();
        }

        public ISucuk CreateSucuk()
        {
            return new VartanyaSucuk();
        }

        IEnumerable<IEkstralar> Iicindekiler.CreateEkstra()
        {
            IEkstralar[] eks = { new Ketcap(), new Mayonez() };
            return eks;
        }
    }
}
