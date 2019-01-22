using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.CommandPattern
{
    class KlimaAc : IKomut
    {
        LobiKlima lobiKlima;
        public KlimaAc(LobiKlima lobiKlima)
        {
            this.lobiKlima = lobiKlima;
        }
        public void Execute()
        {
            lobiKlima.Ac();
        }
        public void Undo()
        {
            lobiKlima.Kapat();
        }
    }
}
