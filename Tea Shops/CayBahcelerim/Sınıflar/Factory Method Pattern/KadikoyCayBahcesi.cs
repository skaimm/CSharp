using CayBahcelerim.Sınıflar.Abstract_Factory_Pattern;
using CayBahcelerim.Sınıflar.Decorator_Pattern;
using CayBahcelerim.Sınıflar.Decorator_Pattern.CondimentDecorator.İcerikler;
using CayBahcelerim.Sınıflar.Strategy_Pattern;
using CayBahcelerim.Sınıflar.Tost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Factory_Method_Pattern
{
    public class KadikoyCayBahcesi : SiparisFactory
    {
        private List<List<SiparisSinif>> siparisler;
        
        public KadikoyCayBahcesi()
        {
            this.siparisler = new List<List<SiparisSinif>>();
            ozellik = new Icilebilir();
        }
        protected override void SiparisDuz(int spno, string t, string i, bool b, bool l)
        {
            TostSinif tost = null;
            IcecekSinif icecek = null;
            Iicindekiler ici = new KadikoySube();
            List<SiparisSinif> temp = new List<SiparisSinif>();
            if (t != null)
            {
                if (t.Equals("Kasarli"))
                {
                    tost = new KasarliTost(ici);
                }
                else if (t.Equals("Ayvalik"))
                {
                    tost = new AyvalikTostu(ici);
                }
                else
                {
                    tost = new KarisikTost(ici);
                }
                temp.Add(tost);
            }

            if (i != null)
            {
                if (i.Equals("Oralet"))
                {
                    icecek = new Oralet();
                }
                else if (i.Equals("Ihlamur"))
                {
                    icecek = new Ihlamur();
                }
                else
                {
                    icecek = new SiyahCay();
                }

                if (b)
                {
                    icecek = new Bal(icecek);
                }
                if (l)
                {
                    icecek = new Limon(icecek);
                }
                temp.Add(icecek);
            }
            siparisler[spno][0] = null;
            siparisler[spno][0] = tost;
            siparisler[spno][1] = null;
            siparisler[spno][1] = icecek;

        }

        protected override void GSiparis(string t, string i, bool b, bool l)
        {
            TostSinif tost;
            IcecekSinif icecek;
            Iicindekiler ici = new KadikoySube();
            List<SiparisSinif> temp = new List<SiparisSinif>();

            if (t != null)
            {
                if (t.Equals("Kasarli"))
                {
                    tost = new KasarliTost(ici);
                }
                else if (t.Equals("Ayvalik"))
                {
                    tost = new AyvalikTostu(ici);
                }
                else
                {
                    tost = new KarisikTost(ici);
                }
                temp.Add(tost);
            }
            
            if(i!=null)
            {
                if (i.Equals("Oralet"))
                {
                    icecek = new Oralet();
                }
                else if (i.Equals("Ihlamur"))
                {
                    icecek = new Ihlamur();
                }
                else
                {
                    icecek = new SiyahCay();
                }

                if (b)
                {
                    icecek = new Bal(icecek);
                }
                if (l)
                {
                    icecek = new Limon(icecek);
                }
                temp.Add(icecek);
            }

            siparisler.Add(temp);
        }

        protected override List<List<SiparisSinif>> getsiparisler()
        {
            return siparisler;
        }

        protected override void SiparisSil(int spno)
        {
            siparisler.RemoveAt(spno);
        }
    }
}
