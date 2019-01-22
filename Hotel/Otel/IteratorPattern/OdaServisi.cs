using Otel.IteratorPattern;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Otel.AbstractFactoryPattern
{
    public class OdaServisi
    {
        private IEnumerable kahvalti;
        private IEnumerable aksamYemegi;

        public OdaServisi(Kahvalti kahvalti,AksamYemegi aksamYemegi)
        {
            this.kahvalti = kahvalti.Items;
            this.aksamYemegi = aksamYemegi.Items;
        }
        
        public void MenuCiktiAl()
        {
            var breakfast = kahvalti;
            Goster(breakfast);
            var dinner = aksamYemegi;
            Goster(dinner);
        }

        private IEnumerable Goster(IEnumerable iter)
        {
            return iter;
        }

        public IEnumerable Liste()
        {
            IEnumerable iter;
            iter = kahvalti;
            iter = aksamYemegi;
            return iter;
        }
    }
}