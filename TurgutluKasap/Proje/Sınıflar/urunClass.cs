using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Sınıflar
{
    class urunClass
    {
            private string isim;
            private string miktar;
            private string birimfiyat;
            private string vergiorani;

            public string Isim
            {
                get { return isim; }
                set { isim = value; }
            }

            public string Miktar
            {
                get { return miktar; }
                set { miktar = value; }
            }
            public string Birimfiyat
            {
                get { return birimfiyat; }
                set { birimfiyat = value; }
            }
            public string Vergiorani
            {
                get { return vergiorani; }
                set { vergiorani = value; }
            }
    }
}
