using Otel.SignletonPattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.IteratorPattern
{
    class AksamYemegiIterator : IEnumerable
    {
        private List<Menu> items;

        public AksamYemegiIterator(List<Menu> items)
        {
            this.items = items;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return new AksamYemegiEnum(items);
        }
    }
}
