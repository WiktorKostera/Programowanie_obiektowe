using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_7
{
    internal class Konto
    {
        string imie;
        string nazwisko;
        long numer;
        decimal saldo;

        public Konto(string imie, string nazwisko, long numer, decimal saldo)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numer = numer;
            this.saldo = saldo;
        }
        void Wplac(decimal kwota)
        {
            saldo += kwota;
        }
        bool MoznaWyplacic(decimal kwota)
        {
            if (kwota <= saldo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void Wyplac(decimal kwota)
        {
            if(MoznaWyplacic(kwota))
            {
                saldo -= kwota;
            }
            else
            {
                Console.Write($"Operacja wyplaty {kwota} nie moze byc wykonana");
            }
        }
        void Przelej(Konto konto, decimal kwota)
        {
            if(MoznaWyplacic(kwota))
            {
                saldo -= kwota;
                konto.saldo += kwota;
            }
            else
            {
                Console.Write($"Przelew w kwocie {kwota} nie moze byc wykonany");
            }
        }
        void StanKonta()
        {
            Console.Write($"Numer konta to: {numer}, włascicielem jest {imie} {nazwisko}, a saldo wynosi {saldo}");
        }
    }

}
