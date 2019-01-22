using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.SignletonPattern
{
    public class EskiMusteri
    {
        private string _isim;
        private string _soyisim;
        private long _tel;
        public string isim { get{ return _isim; } set { _isim = value; } }
        public string soyisim { get { return _soyisim; } set { _soyisim = value; } }
        public long tel { get { return _tel; } set { _tel = value; } }
 
    }
}
