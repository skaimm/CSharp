using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.CommandPattern
{
    public class KlimaKapat : IKomut
    {
        LobiKlima lobiKlima;
        public KlimaKapat(LobiKlima lobiKlima)
        {
            this.lobiKlima = lobiKlima;
        }
        public void Execute()
        {
            lobiKlima.Kapat();
        }
        public void Undo()
        {
            lobiKlima.Ac();
        }
    }
}
