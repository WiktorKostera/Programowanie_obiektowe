internal class Zestaw_2
{
    private static void Main(string[] args)
    {
        //zad2_1();
        //zad2_2();
        //zad2_3();
        //zad2_4();
        //zad2_5();
        //zad2_6();
        //zad2_7();
        zad2_8();
    }
    static void zad2_1()
    {
        int suma = 0;
        int ocena;
        int licznik = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Podaj ocenę: ");
            ocena = Convert.ToInt32(Console.ReadLine());
            if (ocena > 1) 
            { 
                suma += ocena;
                licznik++;
            }
            
        }
        double srednia = suma / (double)licznik;
        Console.WriteLine("Śrenia z pozytywnych ocen wynosi: {0:N}", srednia);
    }
    static void zad2_2()
    {
        Console.Write("Podaj kwote, ktora chcesz umiescic na lokacie: ");
        double kwota = Convert.ToDouble(Console.ReadLine());
        Console.Write("Podaj ilosc lat, na ktore chcesz zdeponowac lokate: ");
        int lata = Convert.ToInt32(Console.ReadLine());
        int rok = 1;
        for (int i = 0; i < lata; i++)
        {
            kwota = kwota * 1.06;
            Console.WriteLine("Kwota po {0} roku wyniesie {1:N}", rok, kwota);
            rok++;
        }
    }
    static void zad2_3()
    {
        int[] liczby = new int[5];
        int nr = 1;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Podaj {0} liczbe: ", nr);
            liczby[i] = Convert.ToInt32(Console.ReadLine());
            nr++;
        }
        int max = 0;
        for (int j = 0; j < 5; j++)
        {
            if (liczby[j] > max)
                max = liczby[j];
        }
        Console.Write("Maksimum z podanych 5 liczb wynosi: {0}", max);
    }
    static void zad2_4()
    {
        Console.Write("Podaj dlugosc skoku: ");
        double d = Convert.ToDouble(Console.ReadLine());

        int k = 120;
        double s = 1.8;
        int[] oceny = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Podaj {i + 1} ocene sedziow w przedziale od 0 do 20: ");
            oceny[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(oceny);
        int ps = oceny[2] + oceny[3] + oceny[4];
        double pd = 60 + ((d - k) * s);
        double p = ps + pd;
        Console.Write($"Wynik skoczka wynosi {p}");
    }
    static void zad2_5()
    {
        Console.Write("Podaj liczbe, ktorej silnie chcesz obliczyc: ");
        int liczba = Convert.ToInt32(Console.ReadLine());
        double obl_silnia = silnia(liczba);
        if (obl_silnia != 0)
        {
        Console.Write($"Silnia liczby {liczba} wynosi: {obl_silnia}");
        }
        else
        {
        Console.Write($"Silnia liczby {liczba} nie istnieje!!!");
        }

    }
    static double silnia(int liczba)
    {   
        if(liczba < 0)
        {
            return 0;
        }
        double silnia = 1;
        for (int i = 1; i < liczba + 1; i++)
        {
            silnia = silnia * i;
        }
        return silnia;
    }
    static void zad2_6()
    {
        Console.Write("Podaj liczbe, ktora chcesz sprawdzic czy jest pierwsza: ");
        int liczba = Convert.ToInt32(Console.ReadLine());

        if(czy_pierwsza(liczba))
        {
            Console.Write("Liczba {0} jest liczba pierwsza", liczba);
        }
        else
        {
            Console.Write("Liczba {0} nie jest liczba pierwsza", liczba);
        }
    }
    static bool czy_pierwsza(int liczba)
    {
        if (liczba <= 2)
            return false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    static void zad2_7()
    {
        Console.Write("Podaj pierwsza liczbe: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Podaj druga liczbe: ");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <=b; i++)
        {
            if(czy_pierwsza(i))
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
    static void zad2_8()
    {
        Console.WriteLine("OBLICZANIE DWUMIANU NEWTONA");
        Console.Write("Podaj gorna wartosc dwumianu: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Podaj dolna wartosc dwumianu: ");
        int k = Convert.ToInt32(Console.ReadLine());
        double wartosc = silnia(n) / (silnia(k) * silnia(n - k));
        Console.Write($"Wartosc podanego dwumianu wynosi {wartosc}");
    }
}