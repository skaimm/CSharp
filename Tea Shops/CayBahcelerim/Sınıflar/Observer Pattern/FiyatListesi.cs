using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Observer_Pattern
{
    public class FiyatListesi : ISubject
    {
        private List<IObserver> observers;
        private double karisk;
        private double kasarli;
        private double ayvalik;
        private double cay;
        private double ihlamur;
        private double oralet;
        private double bal;
        private double limon;


        public FiyatListesi()
        {
            observers = new List<IObserver>();
            this.karisk = 4.50;
            this.kasarli = 3.50;
            this.ayvalik = 6.00;
            this.cay = 1.25;
            this.ihlamur = 1.50;
            this.oralet = 1.50;
            this.bal = 4.50;
            this.limon = 4.50; 
        }

        public void NotifyObservers()
        {
            foreach (IObserver ob in observers)
            {
                ob.guncelle(karisk,kasarli,ayvalik,cay,oralet,ihlamur);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public double getihlamur()
        {
            return ihlamur;
        }
        public double getcay()
        {
            return cay;
        }
        public double getoralet()
        {
            return oralet;
        }
        public double getkarisik()
        {
            return karisk;
        }
        public double getkasarli()
        {
            return kasarli;
        }
        public double getayvalık()
        {
            return ayvalik;
        }
        public void setFiyatlar(int ind, string a)
        {
            if (a.Equals("A"))
            {
                this.karisk = karisk + ((karisk * ind) / 100);
                this.kasarli = kasarli + ((kasarli * ind) / 100);
                this.ayvalik = ayvalik + ((ayvalik * ind) / 100);
                this.cay = cay + ((cay * ind) / 100);
                this.oralet = oralet + ((oralet * ind) / 100);
                this.ihlamur = ihlamur + ((ihlamur * ind) / 100);
            }
            else
            {
                this.karisk = karisk - ((karisk * ind) / 100);
                this.kasarli = kasarli - ((kasarli * ind) / 100);
                this.ayvalik = ayvalik - ((ayvalik * ind) / 100);
                this.cay = cay - ((cay * ind) / 100);
                this.oralet = oralet - ((oralet * ind) / 100);
                this.ihlamur = ihlamur - ((ihlamur * ind) / 100);
            }
        }
    }
}
