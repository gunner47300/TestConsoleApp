using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Indekser
    {
           
        public string[] slowa { get; set; }

        public Indekser(string zdanie)
        {
            this.slowa = zdanie.Split();
        }
    }
}
