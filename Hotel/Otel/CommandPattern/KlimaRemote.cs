using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.CommandPattern
{
    public class KlimaRemote
    {
        public static LobiKlima getKlima()
        {
            return new LobiKlima();
        }
    }
}
