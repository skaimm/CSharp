using Otel.SignletonPattern;
using System.Collections;
using System.Collections.Generic;

namespace Otel.AbstractFactoryPattern
{
    public class Kahvalti
    {
        private List<Menu> items;

        public IEnumerable Items
        {
            get
            {
                return new KahvaltiIterator(items);
            }
        }

        public Kahvalti()
        {
            this.items = new List<Menu>();

            AddItem("Sucuklu Yumurta Menu", "Yanında Peynir Zeytin Kahvaltılık", 20);
            AddItem("Menemen", "Yanında Peynir Zeytin Kahvaltılık", 110);
        }

        private void AddItem(string isim, string aciklama, int ucret)
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