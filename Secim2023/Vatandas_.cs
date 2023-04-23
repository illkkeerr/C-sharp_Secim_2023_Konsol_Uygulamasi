using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Secim2023
{
    internal abstract class Vatandas_ : IAd, ISoyad, IYas, IOyKullanabilme
    {
        public abstract string Ad { get; set; }
        public abstract string Soyad { get; set; }
        public abstract int Yas { get; set; }
        public abstract void OyKullan(Milletvekili mv, Cumhurbaskani cb);
        
    }
}
