using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Listy
    {
        string imie { get; set; }
        string nazwisko { get; set; }
        string numer { get; set; }

        public Listy(string imie = "Łukasz", string nazwisko = "Hetman", string telefon = "607770155")
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numer = telefon;
        }
        public void PrintData()
        {
            Console.WriteLine("Imie: {0} Nazwisko: {1} Numer telefonu: {2}", imie, nazwisko, numer);
        }
    }

    class Ludz : Listy
    {
        public Ludz() : base("Dawid", "Kapinos")
        {

        }
        new public void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Pochodna");
        }
    }
}
