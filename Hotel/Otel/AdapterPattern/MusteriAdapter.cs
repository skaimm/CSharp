using Otel.AbstractFactoryPattern;
using Otel.SignletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.AdapterPattern
{
    public class MusteriAdapter : YeniMusteri, IMusteriler
    {
        private EskiMusteri eskiMusteri;

        public MusteriAdapter(EskiMusteri eskiMusteri)
        {
            this.eskiMusteri = eskiMusteri;
            this.VerileriAktar();
        }

        private void VerileriAktar()
        {
            this.isim = eskiMusteri.isim;
            this.soyisim = eskiMusteri.soyisim;
            this.tel = eskiMusteri.tel;
        }
    }
}
