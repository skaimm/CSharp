using Otel.CommandPattern;
using Otel.IteratorPattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.AbstractFactoryPattern
{
    public class IstanbulOtel
    {
        private static IstanbulOtel Instance = null;
        private OdaServisi odaServisi;
        private SinemaOdasi cinema;
        private MusteriKayıtSistemi musteriKayıt;
        private LobiKlima lobiKlima; 

        private IstanbulOtel()
        {
            odaServisi= new OdaServisi(new Kahvalti(),new AksamYemegi());
            musteriKayıt = new MusteriKayıtSistemi();
            lobiKlima = KlimaRemote.getKlima();
        }

        public static IstanbulOtel getInstance()
        {
            if (Instance==null)
            {
                Instance = new IstanbulOtel();
            }
            return Instance;
        }

        public SinemaOdasi SinemaOrtamHazirla( OrtamIsigi OI,Dvd film,DvdPlayer dvdPlayer)
        {
            cinema = new SinemaOdasi(OI,film,dvdPlayer);
            return cinema;
        }

        public IEnumerable OdaServisMenuleri()
        {
            var breakfast = new Kahvalti();
            var dinner = new AksamYemegi();
            var waiter = new OdaServisi(breakfast, dinner);
            return waiter.Liste();
        }

        public MusteriKayıtSistemi Musterikayit()
        {
            return musteriKayıt;
        }

        public bool KlimaAcKapa(string komut)
        {
            if(komut.Equals("A"))
            {
                KlimaAc ackomutu = new KlimaAc(lobiKlima);
                KontrolButon ac = new KontrolButon(ackomutu);
                ac.islemYap();

                return lobiKlima.getDurum();
                
            }
            else 
            {
                KlimaKapat kapakomutu = new KlimaKapat(lobiKlima);
                KontrolButon kapa = new KontrolButon(kapakomutu);
                kapa.islemYap();

                return lobiKlima.getDurum();
            }
        }

        public int KlimaDereceDegistir(string komut)
        {
            if (komut.Equals("A"))
            {
                KlimaDereceArtir dereceartirkomutu = new KlimaDereceArtir(lobiKlima);
                KontrolButon artir = new KontrolButon(dereceartirkomutu);
                artir.islemYap();

                return lobiKlima.getderece();
            }
            else
            {
                KlimaDereceAzalt dereceazaltkomutu = new KlimaDereceAzalt(lobiKlima);
                KontrolButon azalt = new KontrolButon(dereceazaltkomutu);
                azalt.islemYap();

                return lobiKlima.getderece();
            }
        }

        public override string ToString()
        {
            return "Bilgileri Yaz";
        }
    }
    
}
