using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Dziedziczenie
    {
        public class Punkt
        {
            public int x { get; protected set; }
            public int y { get; protected set; }

            public Punkt(int x = 0, int y = 0)
            {
                this.x = x;
                this.y = y;
            }

            public int sumaWspolrzednych()
            {
                return x + y;
            }
             virtual public string WypiszWspolrzedne()
            {
                return $"X: {x}\tY:{y}";
            }
        }

        public class Punkt3D : Punkt
        {        
            public int z { get; protected set; }
            public Punkt3D(int x, int y, int z)
            {
                this.z = z;
                this.x = x;
                this.y = y;

            }
            new public int sumaWspolrzednych()
            {
                return base.sumaWspolrzednych() + z;
            }
            override public string WypiszWspolrzedne()
            {
                return base.WypiszWspolrzedne() + ' ' + $"\tZ: {z}";
            }

        }
    }
}
