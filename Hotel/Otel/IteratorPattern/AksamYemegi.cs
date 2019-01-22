using Otel.SignletonPattern;
using System;
using System.Collections;
using System.Collections.Generic;


namespace Otel.IteratorPattern
{
    public class AksamYemegi
    {
        private List<Menu> items;

        public IEnumerable Items
        {
            get
            {
                return new AksamYemegiIterator(items);
            }
        }

        public AksamYemegi()
        {
            this.items = new List<Menu>();

            AddItems("Hamburger", "Dana eti, Soğan, Domates'li Hambuger", 160);
            AddItems("Patates Kızartması", "Yanında Peynir Zeytin Kahvaltılık", 60);

        }
        private void AddItems(string isim, string aciklama, int ucret)
        {
           var item = new Menu(isim, aciklama, ucret);
           items.Add(item);
        }

        public List<Menu> itemleriGoster()
        {
            return items;
        }
    }
}
