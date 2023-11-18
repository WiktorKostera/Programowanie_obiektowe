using Zestaw_7;

internal class Program
{
    static void Main(string[] args)
    {
        //ZADANIE 1
        /*        Konto k1 = new Konto("Paweł", "Nowak");
                Konto k2 = new Konto("Jan", "Kowalski");

                k1.Wplac(1000);
                k2.Wplac(500);

                k1.Wyplac(300);

                k1.Przelej(k2, 500);

                k1.Wyplac(400);

                k1.StanKonta();
                k2.StanKonta();*/

        //ZADANIE 2
        /*        Bank b1 = new Bank("mBank");
                b1.ZalozKonto("Paweł", "Nowak");
                b1.ZalozKonto("Jan", "Kowalski");

                b1.tablicaKont[0].Wplac(1000);
                b1.tablicaKont[1].Wplac(500);

                b1.tablicaKont[0].przelej2(b1, b1.tablicaKont[1].numer, 500);

                b1.ListaKont();*/

        //ZADANIE 3

/*        Komorka k1 = new Komorka(567456987);
        Komorka k2 = new Komorka(444555666);

        k1.WyslijSMS(k2, "Co tam u Ciebie?");

        k2.CzytajSMS();

        k1.WyslijSMS(k2, "Co robisz w weekend?");
        k1.WyslijSMS(k2, "Piwo w sobote o 18?");

        k2.CzytajSMS();*/

        //ZADANIE 4

        OperatorGSM o1 = new OperatorGSM();
        Komorka k1 = new Komorka(573465987);
        Komorka k2 = new Komorka(657435634);
        o1.Rejestruj(k1);
        o1.Rejestruj(k2);

        o1.tablicaKomorek[0].WyslijSMS2(o1, o1.tablicaKomorek[1].numerTelefonu, "Co dzisiaj robisz?");

        o1.tablicaKomorek[1].CzytajSMS();

        o1.tablicaKomorek[0].WyslijSMS2(o1, 123123123, "Co to za numer?");
    }
}