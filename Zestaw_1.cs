internal class Program
{
    private static void Main(string[] args)
    {
        //zad1_1();
        //zad1_2();
        //zad1_3();
        //zad1_4();
        //zad1_5();
        zad1_6();
    }
    static void zad1_1()
    {
        Console.Write("Podaj promień: ");
        double r = Double.Parse(Console.ReadLine());
        if (r < 0)
        {
            Console.WriteLine("Niepoprawne dane");
        }
        else
        {
            double pole = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Pole wynosi: {0:0.##}", pole);
        }
    }
    static void zad1_2()
    {
        Console.Write("Podaj pierwszy bok prostokata: ");
        double a = Double.Parse(Console.ReadLine());
        Console.Write("Podaj drugi bok prostokata: ");
        double b = Double.Parse(Console.ReadLine());
        //Oczywiście zakładam, że wpisane dane są dodatnie
        double pole = a * b;
        Console.WriteLine("Pole wynosi: {0:0.##}", pole);
        if (a == b)
        {
            Console.WriteLine("To jest kwadrat");
        }
        else
        {
            Console.WriteLine("To nie jest kwadrat");
        }
    }
    static void zad1_3()
    {
        Console.Write("Podaj liczbe całkowita: ");
        int liczba = Int32.Parse(Console.ReadLine());
        if(liczba % 2 == 0)
        {
            Console.WriteLine("Podana liczba jest parzysta");
        }
        else
        {
            Console.WriteLine("Podana liczba nie jest parzysta");
        }
    }
    static void zad1_4()
    {
        Console.Write("Podaj pierwsza liczbe: ");
        double a = Double.Parse(Console.ReadLine());
        Console.Write("Podaj druga liczbe: ");
        double b = Double.Parse(Console.ReadLine());
        Console.Write("Podaj trzecia liczbe: ");
        double c = Double.Parse(Console.ReadLine());
        double max;
        if(a < b)
        {
            if(b < c)
            {
                max = c;
            }
            else
            {
                max = b;
            }
        }
        else
        {
            if(a < c)
            {
                max = c;
            }
            else
            {
                max = a;
            }
        }
        Console.WriteLine("Najwieksza z podanych trzech liczb to: {0:0.##}", max);
    }
    static void zad1_5()
    {
        Console.Write("Podaj wspolczynnik a rownania kwadratowego: ");
        double a = Double.Parse(Console.ReadLine());
        Console.Write("Podaj wspolczynnik b rownania kwadratowego: ");
        double b = Double.Parse(Console.ReadLine());
        Console.Write("Podaj wspolczynnik c rownania kwadratowego: ");
        double c = Double.Parse(Console.ReadLine());
        double delta = (b * b) - (4 * a * c);
        if(delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
            double x2 = (-b + Math.Sqrt(delta)) / 2 * a;
            Console.WriteLine("Rozwiazania rownania kwadratowego o zadanych wspolczynnikach to: {0:0.##} oraz {1:0.##}", x1, x2);
        }
        else if(delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Rozwiazaniem rownania kwadratowego o zadanych wspolczynnikach jest: {0:0.##}", x);
        }
        else
        {
            double re = -b / (2 * a);
            double im = Math.Sqrt(-delta) / 2;
            Console.WriteLine("Rozwiazania rownania kwadratowego o zadanych wspolczynnikach to: {0:0.##} + {1:0.##}i oraz {0:0.##} - {1:0.##}i", re, im);
        }
    }
    static void zad1_6()
    {
        Console.Write("Podaj kwote w zlotowkach, ktora chcesz przeliczyc na inna walute: ");
        double x = Double.Parse(Console.ReadLine());
        Console.WriteLine("Dostepne waluty:");
        Console.WriteLine("1. USD");
        Console.WriteLine("2. EUR");
        Console.WriteLine("3. GBP");
        Console.Write("Wybierz numer waluty, na ktora chcesz przeliczyc wpisana kwote: ");     
        int nr = Int16.Parse(Console.ReadLine());
        double przeliczona;

        switch(nr)
        {
            case 1:
                przeliczona = x / 4.32;
                Console.WriteLine("Przeliczona kwota wynosi: {0:0.##} USD", przeliczona);
                break;
            case 2:
                przeliczona = x / 4.58;
                Console.WriteLine("Przeliczona kwota wynosi: {0:0.##} EUR", przeliczona);
                break;
            case 3:
                przeliczona = x / 5.30;
                Console.WriteLine("Przeliczona kwota wynosi: {0:0.##} GBP", przeliczona);
                break;
            default:
                Console.WriteLine("Nie wybrano zadnej waluty do przeliczenia");
                break;
        }
    }
}