using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.SignletonPattern
{
    class KahvaltiIterator : IEnumerable
    {
        private List<Menu> items;

        public KahvaltiIterator(List<Menu> items)
        {
            this.items = items;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return new KahvaltiEnum(items);
        }
    }
}
