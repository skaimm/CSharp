using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Tost
{
    public abstract class TostSinif : SiparisSinif
    {
        protected string aciklama = "Aciklama Yok";
        public abstract string Aciklama { get; }
        public abstract double Ucret();
    }
}
