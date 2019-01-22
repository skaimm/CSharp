using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.SignletonPattern
{
    public class KahvaltiEnum : IEnumerator
    {
        private readonly List<Menu> items;
        private int pozisyon = -1;

        public KahvaltiEnum(List<Menu> items)
        {
            this.items = items;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            pozisyon++;
            return (pozisyon < items.Count);
        }

        public void Reset()
        {
            pozisyon = -1;
        }

        object IEnumerator.Current => Current;

        public Menu Current
        {
            get
            {
                try
                {
                    return (Menu)items[pozisyon];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
