using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.CommandPattern
{
    class KlimaDereceAzalt : IKomut
    {
        LobiKlima lobiKlima;
        public KlimaDereceAzalt(LobiKlima lobiKlima)
        {
            this.lobiKlima = lobiKlima;
        }
        public void Execute()
        {
            lobiKlima.DereceAzalt();
        }

        public void Undo()
        {
            lobiKlima.DereceArtir();
        }
    }
}
