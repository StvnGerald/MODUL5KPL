using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MODUL5
{
    class PemrosesanData<T>
    {
        T data;
        public void DapatkanNilaiTerbesar<T>(T a, T b, T c)
        {
            dynamic data2 = b;
            dynamic data3 = c;

<<<<<<< HEAD
            dynamic biggest =a ;
=======
            dynamic biggest = a;
>>>>>>> implementasi-generic-class

            if (biggest > data2 && biggest > data3)
            {
                biggest = biggest;
<<<<<<< HEAD
            } else if (data2 > biggest && data2 > data3) {
                biggest = data2;
            } else if (data3 > biggest && data3 > data2)
            {
                biggest = data3;
            }
            
=======
            }
            else if (data2 > biggest && data2 > data3)
            {
                biggest = data2;
            }
            else if (data3 > biggest && data3 > data2)
            {
                biggest = data3;
            }

>>>>>>> implementasi-generic-class
            Console.WriteLine($"Terbesar adalah {biggest}");
        }
    }

    class Generics
    {
        public static void Main(string[] Args)
        {
            PemrosesanData<double> data = new PemrosesanData<double>();
            data.DapatkanNilaiTerbesar(1.0, 3.0, 2.2);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> implementasi-generic-class
