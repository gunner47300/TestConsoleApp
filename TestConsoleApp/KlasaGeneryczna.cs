using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class KlasaGeneryczna<T>
    {
       T tmp;

        public void Swap(T a, T b)
        {
            this.tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine(a + " " + b);
        }

        public void SwapAny<D>(D a, D b)
        {
            D tmpp = a;
            a = b;
            b = tmpp;

            Console.WriteLine(a + " " + b);
        }

    }
}
