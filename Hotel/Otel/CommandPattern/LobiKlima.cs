using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.CommandPattern
{
    public class LobiKlima
    {
        bool durum;
        private int derece = 0;

        public void Ac()
        {
            durum = true;
        }

        public void Kapat()
        {
            durum = false;
        }

        public void DereceArtir()
        {
            if(derece != 30)
                derece++;
        }
        public void DereceAzalt()
        {
            if (derece != 0)
                derece--;
        }

        public bool getDurum()
        {
            return durum;
        }

        public int getderece()
        {
            return derece;
        }
    }
}
