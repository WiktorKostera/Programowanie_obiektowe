using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_8
{
    internal class Konto
    {
        private static long nadawany_numer = 1000;

        public string imie { get; set; }
        string nazwisko;
        public long numer;
        public decimal saldo;

        public Konto(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numer = GenerowanieNumeru();
            this.saldo = 0;
        }

/*        public string Imie
        {
            get
            {
                return imie;
            }
            set
            {
                imie = value;
            }
        }*/
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

        public void Przelej2(Bank3 bank, long numer, decimal kwota)
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
            if (ilosc < tablicaKont.Length)
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
            for (int i = 0; i < tablicaKont.Length; i++)
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
    internal class Bank2
    {
        string nazwa;
        public ArrayList tablicaKont;
        private static int ilosc = 0;

        public Bank2(string nazwa)
        {
            this.nazwa = nazwa;
            this.tablicaKont = new ArrayList();
        }
        public Konto ZalozKonto(string imie, string nazwisko)
        {
            Konto nowe = new Konto(imie, nazwisko);
            tablicaKont.Add(nowe);
            return nowe;
        }
        public void ListaKont()
        {
            for (int i = 0; i < tablicaKont.Count; i++)
            {
                Konto konto = (Konto)tablicaKont[i];
                konto.StanKonta();
            }
        }
        public Konto ZnajdzKonto(long numer)
        {
            for (int i = 0; i < tablicaKont.Count; i++)
            {
                Konto konto = (Konto)tablicaKont[i];
                if (konto.numer == numer)
                {
                    return konto;
                }
            }
            Console.WriteLine($"Konto o numerze {numer} nie istnieje!");
            return null;
        }
    }
    internal class Bank3
    {
        string nazwa;
        public Hashtable tablicaKont;
        private static int ilosc = 0;

        public Bank3(string nazwa)
        {
            this.nazwa = nazwa;
            this.tablicaKont = new Hashtable();
        }
        public Konto ZalozKonto(string imie, string nazwisko)
        {
            Konto nowe = new Konto(imie, nazwisko);
            tablicaKont.Add(nowe.numer, nowe);
            return nowe;
        }
        public void ListaKont()
        {
            foreach (DictionaryEntry wypisywane in tablicaKont)
            {
                Konto konto = (Konto)wypisywane.Value;
                konto.StanKonta();
            }
        }
        public Konto ZnajdzKonto(long numer)
        {
            if(tablicaKont.ContainsKey(numer))
            {
                return (Konto)tablicaKont[numer];
            }
            Console.WriteLine($"Konto o numerze {numer} nie istnieje!");
            return null;
        }
    }
    internal class Pracownik
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }

        public Pracownik(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public virtual decimal Wyplata() //piszemy 'virtual' zeby moc potem nadpisywac te metode
        {
            return 0m; //piszemy z 'm' zeby traktowane bylo jako 'decimal' a nie 'double'
        }
    }
    internal class PracownikGodzinowy : Pracownik
    {
        public decimal stawkaGodzinowa { get; set; }
        public int liczbaGodzin { get; set; }
        public PracownikGodzinowy(string imie, string nazwisko, decimal stawkaGodzinowa, int liczbaGodzin) : base(imie, nazwisko)
        {
            //:base voznacza wywołanie konstruktora klasy bazowej Pracownik z przekazanymi argumentami imie i nazwisko.
            //To pozwala na inicjalizację pól dziedziczących się z klasy bazowej, czyli Imie i Nazwisko
            this.stawkaGodzinowa = stawkaGodzinowa;
            this.liczbaGodzin = liczbaGodzin;
        }
        public override decimal Wyplata() //'override' zeby nadpisac metode z bazowej klasy
        {
            if(liczbaGodzin <= 160)
            {
                return stawkaGodzinowa * liczbaGodzin; 
            }
            else
            {
                return stawkaGodzinowa * 160 + (stawkaGodzinowa * 1.5m * (liczbaGodzin - 160));
            }
        }
    }
    internal class PracownikAkordowy : Pracownik
    {
        public decimal stawkaAkordowa { get; set; }
        public int liczbaJednostek { get; set; }

        public PracownikAkordowy(string imie, string nazwisko, decimal stawkaAkordowa, int liczbaJednostek) : base(imie, nazwisko)
        {
            this.stawkaAkordowa = stawkaAkordowa;
            this.liczbaJednostek = liczbaJednostek;
        }
        public override decimal Wyplata()
        {
            return stawkaAkordowa * liczbaJednostek;
        }
    }
    internal class PracownikProwizyjny : Pracownik
    {
        public decimal pensjaPodstawowa { get; set; }
        public decimal prowizja { get; set; }
        public int liczbaJednostek { get; set; }

        public PracownikProwizyjny(string imie, string nazwisko, decimal pensjaPodstawowa, decimal prowizja, int liczbaJednostek) : base(imie, nazwisko)
        {
            this.pensjaPodstawowa = pensjaPodstawowa;
            this.prowizja = prowizja;  
            this.liczbaJednostek = liczbaJednostek;
        }
        public override decimal Wyplata()
        {
            return pensjaPodstawowa + prowizja * liczbaJednostek;
        }
    }
}