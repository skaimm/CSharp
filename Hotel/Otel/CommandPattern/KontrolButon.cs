using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.CommandPattern
{
    public class KontrolButon
    {
        IKomut komut;

        public KontrolButon(IKomut komut)
        {
            this.komut = komut;
        }

        public void islemYap()
        {
            komut.Execute();
        }
    }
}
