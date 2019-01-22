using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Strategy_Pattern
{
    public interface Ozelllik
    {
        string sigarakullanimi();
    }

    class Icilebilir : Ozelllik
    {
        public string sigarakullanimi()
        {
            return "Sigara içilebilir";
        }
    }

    class Icilemez : Ozelllik
    {
        public string sigarakullanimi()
        {
            return "Sigara içilemez";
        }
    }
}
