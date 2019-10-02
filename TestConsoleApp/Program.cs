using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Print(Dziedziczenie.Punkt punkt)
        {
            if (punkt is Dziedziczenie.Punkt3D)
            {
                Console.WriteLine(((Dziedziczenie.Punkt3D)punkt).WypiszWspolrzedne());
            }
            else
                Console.WriteLine(punkt.WypiszWspolrzedne());
        }

        static void PrintAs(Dziedziczenie.Punkt punkt)
        {
            Dziedziczenie.Punkt3D punkt3D = punkt as Dziedziczenie.Punkt3D;

            if (punkt3D == null)
            {
                Console.WriteLine(punkt.WypiszWspolrzedne());
            }
            else
                Console.WriteLine(((Dziedziczenie.Punkt3D)punkt).WypiszWspolrzedne());
        }

        static void PrintfromObject(object x)
        {

            Dziedziczenie.Punkt punkt = x as Dziedziczenie.Punkt3D;
            if (punkt != null)
            {
                Console.WriteLine(((Dziedziczenie.Punkt3D)punkt).WypiszWspolrzedne());
            }
            else
            {
                punkt = x as Dziedziczenie.Punkt;

                if (punkt != null)
                {
                    Console.WriteLine(punkt.WypiszWspolrzedne());
                }
                else Console.WriteLine("Error");
            }
        }

        static void Main(string[] args)
        {
            string a = "alala";
            Console.WriteLine(a.isFirstLetterCapitalized());

            Console.ReadKey();
        }


    }


    class Test
    {
        public static string name { get; set; } = "Łukasz";
        public int a { get; set; } = 50;
        public int b { get; set; } = 60;
        public int c { get; set; } = 70;

        static Test()
        {
            Console.WriteLine("Hello World!");
        }
        public Test(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Test(int a) : this(a, 11, 12)
        {

        }
        public Test(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Test(Test givenToCopy)
        {
            this.a = givenToCopy.a;
            this.b = givenToCopy.b;
            this.c = givenToCopy.c;
        }
        public void Print(params int[] args)
        {
            foreach (int val in args)
            {
                Console.WriteLine(val);
            }
        }

        public static void HelloLukasz()
        {
            Console.WriteLine("Hello Łukasz!");
        }
    }

    class Laptop
    {
        class Procesor
        {
            string nazwa { get; }
            uint taktowanie { get; }
            uint liczbaRdzeni { get; }

            public Procesor(string nazwa, uint taktowanie, uint liczbaRdzeni)
            {
                this.nazwa = nazwa;
                this.taktowanie = taktowanie;
                this.liczbaRdzeni = liczbaRdzeni;
            }

            public void DrukujDane()
            {
                Console.WriteLine("PROCESOR: \n" +
                    "Nazwa: {0}\n" +
                    "Taktowanie: {1}\n" +
                    "Liczba rdzeni: {2}\n\n", nazwa, taktowanie, liczbaRdzeni);
            }
        }
        class Grafika
        {
            public string nazwa { get; }
            public uint pamiec { get; }

            public Grafika(string nazwa, uint pamiec)
            {
                this.nazwa = nazwa;
                this.pamiec = pamiec;
            }

            public void DrukujDane()
            {
                Console.WriteLine("GRAFIKA: \n" +
                    "Nazwa: {0}\n" +
                    "Pamięć: {1}\n\n", nazwa, pamiec);
            }
        }

        public string nazwa { get; set; }
        Procesor procesor { get; set; }
        Grafika grafika { get; set; }

        public Laptop()
        {
            Console.WriteLine("Podaj nazwę laptopa: ");
            this.nazwa = Console.ReadLine();
            this.procesor = new Procesor("INTEL", 25000000, 4);
            this.grafika = new Grafika(Console.ReadLine().ToString(), uint.Parse(Console.ReadLine()));

            drukujWszystkieDane();
        }

        void drukujWszystkieDane()
        {
            procesor.DrukujDane();
            grafika.DrukujDane();
        }
    }

    class Uprawnienia
    {
        public class Jeden
        {

            string ein = "jeden";
            public Dwa dwa = new Dwa();
            public Dwa.Trzy trzy = new Dwa.Trzy();

            public Jeden()
            {

            }
            public void druknij1()
            {
                Console.WriteLine(ein);
            }
            public void druknij2()
            {
                dwa.druknij2();
            }
            public void druknij3()
            {
                trzy.druknij3();
            }

            public class Dwa
            {
                public string zwei = "dwa";
                public Trzy trzy = new Trzy();

                void druknij3()
                {
                    trzy.druknij3();
                }

                public void druknij2()
                {
                    Console.WriteLine(zwei);
                }


                public class Trzy
                {
                    string drei = "trzy";

                    public Trzy()
                    {

                    }
                    public void druknij3()
                    {
                        Console.WriteLine(drei);
                    }
                }
            }
        }
    }

}
