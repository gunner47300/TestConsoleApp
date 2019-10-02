using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    abstract class Abstrakcja_Osoba
    {
        public string imie { get; protected set; }
        public string nazwisko { get; protected set; }

        public Abstrakcja_Osoba(string imie = "", string nazwisko = "")
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void PrzedstawSie()
        {
            Console.WriteLine("Nazywam się " + this.imie + " " + this.nazwisko);
        }
        abstract public void MojZawodTo();
        public static void WyswietlWszystko(Abstrakcja_Osoba[] abstrakcja_Osoba)
        {
            foreach(Abstrakcja_Osoba osoba in abstrakcja_Osoba)
            {
                if(osoba != null)
                {
                    osoba.PrzedstawSie();
                    osoba.MojZawodTo();
                }
            }
        }
    }

    class Kierowca : Abstrakcja_Osoba
    {
        public string zawod { get; private set; }
        public Kierowca(string imie, string nazwisko, string zawod = "KIEROWCA") : base(imie, nazwisko)
        {
            this.zawod = zawod;
        }


        public override void MojZawodTo()
        {
            Console.WriteLine("Mój zawód to {0}", zawod);
        }
    }

    class Nauczyciel : Abstrakcja_Osoba
    {
        public string zawod { get; private set; }
        public Nauczyciel(string imie, string nazwisko, string zawod = "NAUCZYCIEL") : base(imie, nazwisko)
        {
            this.zawod = zawod;
        }
        public override void MojZawodTo()
        {
            Console.WriteLine("Mój zawód to {0}", zawod);
        }
    }
}
