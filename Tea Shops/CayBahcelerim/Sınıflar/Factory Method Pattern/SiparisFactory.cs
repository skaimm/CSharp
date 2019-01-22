using CayBahcelerim.Sınıflar.Decorator_Pattern;
using CayBahcelerim.Sınıflar.Observer_Pattern;
using CayBahcelerim.Sınıflar.Strategy_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Tost
{
    public abstract class SiparisFactory
    {
        public Ozelllik ozellik;

        public void Siparis(string tosttype,string icecektype,bool bal, bool limon)
        {
            GSiparis(tosttype,icecektype,bal,limon);
             
        }
        public void SiparisDuzelt(int spno,string tosttype, string icecektype, bool bal, bool limon)
        {
            SiparisDuz(spno,tosttype, icecektype, bal, limon);

        }
        public void SiparisIptal(int spno)
        {
            SiparisSil(spno);

        }

        public List<List<SiparisSinif>> SiparileriGoster()
        {
            return getsiparisler();
        }

        protected abstract List<List<SiparisSinif>> getsiparisler();
       

        protected abstract void GSiparis(string t,string i,bool b,bool l);
        protected abstract void SiparisDuz(int spno, string t,string i, bool b, bool l);
        protected abstract void SiparisSil(int spno);

    }
}
