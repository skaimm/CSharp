using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.SignletonPattern
{
    public class Menu
    {
        public string Isim { get; }
        public string Aciklama { get; }
        public double Ucret { get; }

        public Menu(string isim, string aciklama, double ucret)
        {
            Isim = isim;
            Aciklama = aciklama;
            Ucret = ucret;
        }

        public string getIsim()
        {
            return Isim;
        }

    }
}
