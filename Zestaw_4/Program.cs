namespace Zestaw_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestKola1();
            //TestProstokata1();
            //TestKola2();
            //TestProstokata2();
            TestKola3();
        }
        static void TestKola1()
        {
            //wczytanie danych
            Console.Write("Podaj promien: ");
            double r = Double.Parse(Console.ReadLine());

            //statyczne wywolanie metody Obwod
            double obw = Kolo.Obwod(r);

            //wypisanie wyniku
            Console.WriteLine("Obwod kola o promieniu {0:0.00} wynosi: {1:0.00}", r, obw);
        }
        static void TestProstokata1()
        {
            Console.Write("Podaj dlugosc a prostokata: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj dlugosc b prostokata: ");
            double b = double.Parse(Console.ReadLine());

            Prostokat p = new Prostokat();

            double obw = p.Obwod(a, b);

            Console.WriteLine($"Obwod prostokata o bokach {a} i {b} wynosi {obw}");
        }
        static void TestKola2()
        {
            Console.Write("Podaj promien: ");
            double r = Double.Parse(Console.ReadLine());

            //tworzenie instancji klasy Kolo
            Kolo k = new Kolo(r);

            double obw = k.Obwod();

            Console.WriteLine("Obwod kola o promieniu {0:0.00} wynosi: {1:0.00}", r, obw);
        }
        static void TestProstokata2()
        {
            Console.Write("Podaj dlugosc a prostokata: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj dlugosc b prostokata: ");
            double b = double.Parse(Console.ReadLine());

            Prostokat p = new Prostokat(a, b);

            double obw = p.Obwod();

            Console.WriteLine($"Obwod prostokata o bokach {a} i {b} wynosi {obw}");
        }
        static void TestKola3()
        {
            Kolo k1, k2, k3;
            k1 = new Kolo();
            k2 = new Kolo(4.5);
            k3 = new Kolo(2);

            int ile = Kolo.ile;

            Console.WriteLine("Liczba egzemplarzy klasy Kolo wynosi: {0}", ile);
        }
    }
}