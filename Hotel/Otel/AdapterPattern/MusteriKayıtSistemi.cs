using Otel.AdapterPattern;
using Otel.SignletonPattern;
using System;
using System.Collections.Generic;

namespace Otel.AbstractFactoryPattern
{
    public class MusteriKayıtSistemi
    {
        private List<EskiMusteri> MusteriListesi;
        private List<IMusteriler> YeniSezonRezervasyonlari;

        public MusteriKayıtSistemi ()
        {
            MusteriListesi = new List<EskiMusteri>();
            YeniSezonRezervasyonlari = new List<IMusteriler>();
        }

        public void MusteriRezervasyonu(string isim,string soyisim,long telno)
        {
            bool kayit = false;
            if (MusteriListesi != null)
            {
                for (int i = 0; i < MusteriListesi.Count; i++)
                {
                    if (MusteriListesi[i].tel == telno)
                    {
                        IMusteriler musteri = new MusteriAdapter(MusteriListesi[i]);
                        YeniSezonRezervasyonlari.Add(musteri);
                        kayit = true;
                    }
                }
            }
            
            if(!kayit)
            {
                YeniMusteriKaydıOlustur(isim,soyisim,telno);
            }
        }

        private void YeniMusteriKaydıOlustur(string isim, string soyisim, long telno)
        {
            EskiMusteri yenimusteri = new EskiMusteri();
            try
            {
                yenimusteri.isim = isim;
                yenimusteri.soyisim = soyisim;
                yenimusteri.tel = telno;
            }
            catch { }
            

            MusteriListesi.Add(yenimusteri);
            IMusteriler musteri = new MusteriAdapter(yenimusteri);
            YeniSezonRezervasyonlari.Add(musteri);

        }

        public List<EskiMusteri> TumMusterileriGor()
        {
            return MusteriListesi;
        }

        public List<IMusteriler> YeniSezonRezervasyonlariniGör()
        {
            return YeniSezonRezervasyonlari;
        }
    }
}