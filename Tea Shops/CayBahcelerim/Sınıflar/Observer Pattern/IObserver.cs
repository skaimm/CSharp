using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayBahcelerim.Sınıflar.Observer_Pattern
{
    public interface IObserver
    {
       void guncelle(double kar,double kas,double ayv,double cay,double ora,double ihl);
    }
}
