using Otel.SignletonPattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Otel.IteratorPattern
{
    public class AksamYemegiEnum : IEnumerator
    {
        private readonly List<Menu> items;
        private int posizyon = -1;
        public AksamYemegiEnum(List<Menu> items)
        {
            this.items = items;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            posizyon++;
            return (posizyon < items.Count);
        }

        public void Reset()
        {
            posizyon = -1;
        }

        object IEnumerator.Current => Current;

        public Menu Current
        {
            get
            {
                try
                {
                    return items[posizyon];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
