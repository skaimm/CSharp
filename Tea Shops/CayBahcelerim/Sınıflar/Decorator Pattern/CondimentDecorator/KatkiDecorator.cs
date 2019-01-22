using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Decorator_Pattern
{
    abstract class KatkiDecorator : IcecekSinif
    {
        public abstract override string Aciklama { get; }
    }
}
