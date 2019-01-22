using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.CommandPattern
{
    public interface IKomut
    {
        void Execute();
        void Undo();
    }
}
