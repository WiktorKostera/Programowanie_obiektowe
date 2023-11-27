using System.Collections;
using Zestaw_8;

internal class Program
{
    static void Main(string[] args)
    {
        //Zadanie 10.1
        Konto k1 = new Konto("Wiktor", "Kostera");

        Console.WriteLine(k1.imie);
        k1.imie = "Karol";
        Console.WriteLine(k1.imie);

/*        Console.WriteLine(k1.Nazwisko);
        k1.Nazwisko = "Kantor";
        Console.WriteLine(k1.Nazwisko);

        Console.WriteLine(k1.Numer);
        k1.Numer = 2000;
        Console.WriteLine(k1.Numer);*/

        //Zadanie 10.2
        /*        Bank b1 = new Bank("mBank");

                b1.ZalozKonto("Wiktor", "Kostera");
                b1.ZalozKonto("Pawel", "Nowak");

                b1.tablicaKont[0].Wplac(1000);
                b1.tablicaKont[1].Wplac(500);

                b1.tablicaKont[0].Przelej2(b1, b1.tablicaKont[1].numer, 500);

                b1.ListaKont();*/
        //Zadanie 10.3 - koniecznosc zmiany na 'Bank2' w Przelej2()
        /*        Bank2 b1 = new Bank2("Alior");

                Konto k1 = b1.ZalozKonto("Wiktor", "Kostera"); //k1 jest kontem ktore jest elementem banku b1
                Konto k2 = b1.ZalozKonto("Pawel", "Nowak");

                k1.Wplac(1000); 
                k2.Wplac(500);
                b1.ListaKont();

                k1.Przelej2(b1, k2.numer, 200);

                b1.ListaKont();*/

        //Zadanie 10.4 - koniecznosc zmiany na 'Bank3' w Przelej2()
        /*        Bank3 b1 = new Bank3("Alior");

                Konto k1 = b1.ZalozKonto("Wiktor", "Kostera"); //k1 jest kontem ktore jest elementem banku b1
                Konto k2 = b1.ZalozKonto("Pawel", "Nowak");

                k1.Wplac(1000);
                k2.Wplac(500);
                b1.ListaKont();

                k1.Przelej2(b1, k2.numer, 200); //kazda operacja wykonywana dla k1 dzieje sie tez dla banku bo k1 jest jego elementem/czescia struktury banku

                b1.ListaKont();*/

        //Zadanie 10.5 w pliku Class1
    }
}