using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_7
{
    internal class Konto
    {
        private static long nadawany_numer = 1000;

        string imie;
        string nazwisko;
        public long numer;
        decimal saldo;

        public Konto(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numer = GenerowanieNumeru();
            this.saldo = 0;
        }

        public string Imie
        {
            get
            {
                return imie;
            }
            set
            {
                imie = value;
            }
        }
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
            }
        }
        public long Numer
        {
            get
            {
                return numer;
            }
            set
            {
                numer = value;
            }
        }
        public void Wplac(decimal kwota)
        {
            saldo += kwota;
        }
        public bool MoznaWyplacic(decimal kwota)
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

        public void Wyplac(decimal kwota)
        {
            if (MoznaWyplacic(kwota))
            {
                saldo -= kwota;
            }
            else
            {
                Console.WriteLine($"Operacja wyplaty {kwota} nie moze byc wykonana");
            }
        }
        public void Przelej(Konto konto, decimal kwota)
        {
            if (MoznaWyplacic(kwota))
            {
                saldo -= kwota;
                konto.saldo += kwota;
            }
            else
            {
                Console.WriteLine($"Przelew w kwocie {kwota} nie moze byc wykonany");
            }
        }
        public void StanKonta()
        {
            Console.WriteLine($"Numer konta to: {numer}, włascicielem jest {imie} {nazwisko}, a saldo wynosi {saldo}");
        }
        private static long GenerowanieNumeru()
        {
            return nadawany_numer++;
        }

        public void przelej2(Bank bank, long numer, decimal kwota)
        {
            Konto wplywajace = bank.ZnajdzKonto(numer);

            if (wplywajace != null)
            {
                Wyplac(kwota);
                wplywajace.Wplac(kwota);
            }
        }
    }
    internal class Bank
    {
        string nazwa;
        public Konto[] tablicaKont;
        private static int ilosc = 0;

        public Bank(string nazwa)
        {
            this.nazwa = nazwa;
            this.tablicaKont = new Konto[10];
        }
        public Konto ZalozKonto(string imie, string nazwisko)
        {
            if (ilosc < 10)
            {
                Konto k = new Konto(imie, nazwisko);
                tablicaKont[ilosc] = k;
                ilosc++;
                return k;
            }
            else
            {
                Console.WriteLine("Tablica kont jest juz pelna!");
                return null;
            }
        }
        public void ListaKont()
        {
            for (int i = 0; i < 10; i++)
            {
                if (tablicaKont[i] != null)
                {
                    tablicaKont[i].StanKonta();
                }

            }
        }
        public Konto ZnajdzKonto(long numer)
        {
            for (int i = 0; i < 10; i++)
            {
                if (tablicaKont[i]?.numer == numer)
                {
                    return tablicaKont[i];
                }
            }
            Console.WriteLine($"Konto o numerze {numer} nie istnieje!");
            return null;
        }
    }
    internal class Komorka
    {
        public long numerTelefonu;
        string odebranySMS;

        public Komorka(long numerTelefonu)
        {
            this.numerTelefonu = numerTelefonu;
            this.odebranySMS = "";
        }
        public long Numer
        {
            get { return numerTelefonu; }
        }
        public void OdbierzSMS(string sms)
        {
            odebranySMS = sms;
        }
        public void CzytajSMS()
        {
            Console.WriteLine(odebranySMS);
        }
        public void WyslijSMS(Komorka komorka, string sms)
        {
            Console.WriteLine($"Wysyłanie sms od {numerTelefonu} do {komorka.numerTelefonu} o treści: {sms}");
            komorka.OdbierzSMS(sms);
        }
        public void WyslijSMS2(OperatorGSM operatorgsm, long numer, string sms)
        {
            Komorka docelowa = operatorgsm.Wyszukaj(numer);

            if (docelowa != null)
            {
                docelowa.OdbierzSMS(sms);
            }
        }
    }
    internal class OperatorGSM
    {
        public Komorka[] tablicaKomorek;
        public int ilosc = 0;

        public OperatorGSM()
        {
            tablicaKomorek = new Komorka[10];
        }
        public void Rejestruj(Komorka komorka)
        {
            if (ilosc < 10)
            {
                tablicaKomorek[ilosc] = komorka;
                ilosc++;
            }
            else
            {
                Console.WriteLine("Tablica komorek jest juz pelna!");
            }
        }
        public Komorka Wyszukaj(long numer)
        {
            for (int i = 0; i < 10; i++)
            {
                if (tablicaKomorek[i]?.numerTelefonu == numer)
                {
                    return tablicaKomorek[i];
                }
            }
            Console.WriteLine($"Abonent o numerze {numer} nie istnieje bądź nie istnieje badz nie jest zarejestrowany w sieci");
            return null;
        }

    }
}