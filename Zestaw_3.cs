using System;

internal class Zestaw_3
{
    private static void Main(string[] args)
    {
        //zad4_1();
        //zad4_2();
        //zad4_3();
        //zad4_4();
        //zad4_5();
        //zad4_6();
        zad4_7();
    }
    static void zad4_1()
    {
        int suma = 0;
        int ocena = 0;
        int licznik = 0;
        do
        {
            Console.Write("Podaj ocenę: ");
            ocena = Convert.ToInt32(Console.ReadLine());
            suma += ocena;
            licznik += 1;
        } while (ocena >= 1 & ocena <= 6);

        if (licznik > 0)
        {
            double srednia = suma / (double)licznik;
            Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);
        }
        else
        {
            Console.WriteLine("Brak danych do obliczenia średniej");
        }
    }
    static void zad4_2()
    {
        Console.Write("Podaj kwote, ktora chcesz zdeponowac na lokacie: ");
        int kwota = Convert.ToInt32(Console.ReadLine());
        double lokata = kwota;
        int lata = 0;
        while (lokata < 2*kwota)
        {
            lokata = lokata * 1.06;
            lata += 1;
            Console.WriteLine($"Kwota po okresie {lata} lat wynosi {lokata}");
        }
        Console.WriteLine($"\nKwota na lokacie będzie przynajmniej 2 razy większa po okresie {lata} lat");
    }
    static void zad4_3()
    {
        Random rnd = new Random();
        int liczba = rnd.Next(2, 10);
        Console.WriteLine("Komputer wylosowal liczbe, twoim zadaniem jest jej zgadniecie\n");
        int a;
        int licznik = 0;
        Console.Write("Podaj liczbe: ");
        do
        {
            a = Convert.ToInt32(Console.ReadLine());
            licznik += 1;
            if (a > liczba)
            {
                Console.WriteLine("Za duzo!!!");
                Console.Write("Podaj mniejsza liczbe: ");
            }
            else if (a < liczba)
            {
                Console.WriteLine("Za malo!!!");
                Console.Write("Podaj wieksza liczbe: ");                
            }
            else
            {
                Console.WriteLine($"Brawo!!! Odgadles za {licznik} razem!");
            }
        } while (a != liczba);
    }
    static void zad4_4 ()
    {
        Console.Write("Podaj liczbe calkowita: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int liczba = x;
        int n = 0;
        if (x == 2)
        {
            Console.WriteLine($"Liczbe {liczba} mozna wyrazic za pomoca liczby 2 do potegi 1");
        }
        else if (x == 1)
        {
            Console.WriteLine($"Liczbe {liczba} mozna wyrazic za pomoca liczby 2 do potegi 0");
        }
        else if(x % 2 != 0 || x < 1)
        {
            Console.WriteLine($"Liczby {liczba} nie mozna wyrazic za pomoca potegi liczby 2");
        }
        else
        {
            while (x % 2 == 0)
            {
                x = x / 2;
                n += 1;               
                if (x % 2 != 0)
                {
                    Console.WriteLine($"Liczby {liczba} nie mozna wyrazic za pomoca potegi liczby 2");
                    break;
                }
                else if (x / 2 == 1)
                {
                    n += 1;
                    Console.WriteLine($"Liczbe {liczba} mozna wyrazic za pomoca liczby 2 do potegi {n}");
                    break;
                }
            } 
        }
    }
    static void zad4_5()
    {
        Console.Write("Podaj liczbe a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Podaj liczbe b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a < 0)
        {
            a = -a;
        }
        if (b < 0)
        {
            b = -b;
        }
        while (a != b)
        {
            if (a < b)
            {
                b -= a;
            }
            else
            {
                a -= b;
            }
        }
        Console.WriteLine($"Najwiekszy wspolny dzielnik podanych liczb wynosi {a}");
    }
    static void zad4_6()
    {
        Console.Write("Podaj dokladnosc z jaka chcesz policzyc liczbe pi: ");
        double d = Convert.ToDouble(Console.ReadLine());
        double a1 = 0;
        double a2 = 1;
        double mianownik = 1;
        int potega = 2;
        while (Math.Abs(4 * a1 - 4 * a2) >= d)
        {
            a1 = a1 + (Math.Pow(-1, potega) * (1 / mianownik));
            mianownik += 2;
            a2 = a1 + (Math.Pow(-1, potega + 1) * (1 / mianownik));
            potega += 1;
        }
        Console.WriteLine($"Liczba pi z dokladnoscia {d} wynosi {4 * a2}");
    }
    static void zad4_7()
    {
        Console.Write("Podaj liczbe, ktora chcesz sprawdzic czy jest doskonala: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        int suma = 0;
        while (i <= a/2)
        {
            if(a % i == 0)
            {
                suma += i;
            }
            i++;
        }
        if (suma == a)
        {
            Console.WriteLine($"Liczba {a} jest doskonala");
        }
        else
        {
            Console.WriteLine($"Liczba {a} nie jest doskonala");
        }
    }
}