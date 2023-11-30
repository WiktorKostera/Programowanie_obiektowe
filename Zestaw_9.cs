
using System.Collections.Generic;
using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        /*        Console.WriteLine(":)");
                (double, int) krotka1 = (4.5, 3);//Krotka to uporządkowany ciąg matematyczny
                Console.WriteLine($"Krotka z elementami {krotka1.Item1} i {krotka1.Item2}.");
                (double suma, int liczba) krotka2 = (4.5, 3);
                Console.WriteLine($"Suma {krotka2.liczba} elemntów wynosi {krotka2.suma}");

                Dictionary<int, string> nazwyLiczb = new();
                nazwyLiczb.Add(0, "Zero");
                nazwyLiczb.Add(1, "Jeden");
                nazwyLiczb.Add(2, "Dwa");
                nazwyLiczb.Add(3, "Trzy");
                foreach (KeyValuePair<int, string> kvp in nazwyLiczb)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                }
                nazwyLiczb[0] = "Zerówka";
                nazwyLiczb[1] = "Jedynka";
                nazwyLiczb[2] = "Dwójka";
                nazwyLiczb[3] = "Trójka";
                foreach (KeyValuePair<int, string> kvp in nazwyLiczb)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                }
        */

        Abonent janKowalski = new Abonent("Jan", "Kowalski", "777-034-232");
        Abonent edytaNowak = new Abonent("Edyta", "Nowak", "666-634-009");
        Abonent marianWaligora = new Abonent("Marian", "Waligóra", "744-934-229");

        OperatorSieci idea = new OperatorSieci("IDEA");

        idea.DodajAbonenta(janKowalski);
        idea.DodajAbonenta(edytaNowak);
        idea.DodajAbonenta(marianWaligora);

        janKowalski.Zadzwon(10, EnumTaryfa.taryfa1);
        janKowalski.Zadzwon(5, EnumTaryfa.taryfa2);

        edytaNowak.Zadzwon(8, EnumTaryfa.taryfa3);
        edytaNowak.Zadzwon(10, EnumTaryfa.taryfa1);
        edytaNowak.Zadzwon(5, EnumTaryfa.taryfa2);

        Console.WriteLine(idea.ToString());
    }
}


enum EnumTaryfa
{
    taryfa1 = 1,
    taryfa2 = 2,
    taryfa3 = 4,
}

interface IAbonent

{
    public string PodajDane();
    public void Zadzwon(double czas, EnumTaryfa taryfa);
    public (int, decimal) PodsumowanieRozmow();
}



internal class Polaczenie
{
    public double czasTrwania { get; set; }
    public decimal oplata { get; set; }
    public bool wykonane { get; set; }

    public Polaczenie(double czasTrwania, decimal oplata, bool wykonane)
    {
        this.czasTrwania = czasTrwania;
        this.oplata = oplata;
        this.wykonane = wykonane;
    }

}

internal class Abonent : IAbonent
{
    public string imie { get; set; }
    public string nazwisko { get; set; }
    public string numerTelefonu { get; set; }
    public List<Polaczenie> polaczenia { get; set; }

    public Abonent(string imie, string nazwisko, string numerTelefonu)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.numerTelefonu = numerTelefonu;
        this.polaczenia = new List<Polaczenie>();
    }
    public string PodajDane()
    {
        return $"{imie} {nazwisko}";
    }

    public void Zadzwon(double czas, EnumTaryfa taryfa)
    {
        double losowa = new Random().NextDouble();

        if (losowa < 0.3)
        {
            polaczenia.Add(new Polaczenie(0, 0, false));
        }
        else
        {
            decimal oplata = (decimal)taryfa * (decimal)czas;
            polaczenia.Add(new Polaczenie(czas, oplata, true));
        }
    }
    public (int, decimal) PodsumowanieRozmow()
    {
        int rozmowy = 0;
        decimal oplaty = 0;

        foreach (var Polaczenie in polaczenia) //zamist var mozemy dac Polaczenie, jednak teraz program sam wykryje ze chodzi nam o ten typ
        {
            if(Polaczenie.wykonane)
            {
                rozmowy++;
                oplaty += Polaczenie.oplata;
            }
        }
        return (rozmowy, oplaty);
    }

    public override string ToString()
    {
        (int, decimal) podsumowanie = PodsumowanieRozmow(); // tu tez moglibysmy dac 'var' zamiast '(int, decimal)'
        return $"{PodajDane()}, [liczba rozmów: {podsumowanie.Item1}, opłata: {podsumowanie.Item2}]";
    }
}

internal class OperatorSieci
{
    public string nazwa { get; set; }
    public Dictionary<string, Abonent> abonenci { get; set; }

    public OperatorSieci(string nazwa)
    {
        this.nazwa = nazwa;
        this.abonenci = new Dictionary<string, Abonent>();
    }
    public void DodajAbonenta(Abonent abonent)
    {
        abonenci.Add(abonent.numerTelefonu, abonent);
    }
    public Abonent WyszukajAbonenta(string numerTelefonu)
    {
        if (abonenci.ContainsKey(numerTelefonu))
        {
            return abonenci[numerTelefonu];
        }
        else
        {
            return null;
        }
    }
    public override string ToString()
    {
        decimal zysk = 0;
        string daneAbonent;
        foreach (var abonent in abonenci.Values)
        {
            var podsumowanie = abonent.PodsumowanieRozmow();
            zysk += podsumowanie.Item2;
        }

        foreach (var abonent in abonenci.Values)
        {
            daneAbonent = abonent.ToString();
            Console.WriteLine(daneAbonent);
        }
        return $"\nOperator: {nazwa} [sumaryczny zysk: {zysk}]";
    }
}
