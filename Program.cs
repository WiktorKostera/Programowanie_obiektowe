using Zestaw_7;

internal class Program
{
    static void Main(string[] args)
    {
        Konto k1 = new Konto("Wiktor", "Kostera");
        
        Console.WriteLine(k1.Imie);
        k1.Imie = "Karol";
        Console.WriteLine(k1.Imie);

        Console.WriteLine(k1.Nazwisko);
        k1.Nazwisko = "Kantor";
        Console.WriteLine(k1.Nazwisko);

        Console.WriteLine(k1.Numer);
        k1.Numer = 2000;
        Console.WriteLine(k1.Numer);
    }
}