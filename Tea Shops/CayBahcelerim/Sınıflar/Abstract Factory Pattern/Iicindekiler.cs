using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Abstract_Factory_Pattern
{
    interface Iicindekiler
    {
        ISalam CreateSalam();
        ISucuk CreateSucuk();
        IKasar CreateKasar();
        IEnumerable<IEkstralar> CreateEkstra();

    }
}
