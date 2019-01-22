using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.CommandPattern
{
    class KlimaDereceArtir : IKomut
    {
        LobiKlima lobiKlima;
        public KlimaDereceArtir(LobiKlima lobiKlima)
        {
            this.lobiKlima = lobiKlima;
        }
        public void Execute()
        {
            lobiKlima.DereceArtir();
        }

        public void Undo()
        {
            lobiKlima.DereceAzalt();
        }
    }
}
