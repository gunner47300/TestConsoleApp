using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    interface Interfejs
    {
        decimal Saldo { get; }
        int NumerKonta { get; }

        void WplacSrodki(decimal kwota);
        void WyplacSrodki(decimal kwota);
        void WyslijPrzelew(Interfejs konto, decimal kwota);
        void StanKonta();
    }
}

namespace TestConsoleApp
{
    class BankA : Interfejs
    {
        decimal saldo;
        public decimal Saldo { get
            {
                return saldo;
            } }
        int numerKonta;
        public int NumerKonta { get
            {
                return numerKonta;
            } }
        public BankA(decimal saldo, int numerKonta)
        {
            this.saldo = saldo;
            this.numerKonta = numerKonta;
        }
        public void WplacSrodki(decimal kwota)
        {
            saldo += kwota;
        }
        public void WyplacSrodki(decimal kwota)
        {
            this.saldo -= kwota;
        }
        public void WyslijPrzelew(Interfejs konto, decimal kwota)
        {
            konto.WplacSrodki(kwota);
            WyplacSrodki(kwota);
        }
        public void StanKonta()
        {
            Console.WriteLine(saldo);
        }
    }

    class BankB : Interfejs
    {
        decimal saldo;
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
        }
        int numerKonta;
        public int NumerKonta
        {
            get
            {
                return numerKonta;
            }
        }
        public BankB(decimal saldo, int numerKonta)
        {
            this.saldo = saldo;
            this.numerKonta = numerKonta;
        }
        public void WplacSrodki(decimal kwota)
        {
            this.saldo += kwota;
        }
        public void WyplacSrodki(decimal kwota)
        {
            saldo -= kwota;
        }
        public void WyslijPrzelew(Interfejs konto, decimal kwota)
        {
            konto.WplacSrodki(kwota);
            WyplacSrodki(kwota);
        }
        public void StanKonta()
        {
            Console.WriteLine(saldo);
        }
    }
}