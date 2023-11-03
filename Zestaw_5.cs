using System;

internal class Zestaw_5
{
    private static void Main(string[] args)
    {
        //zad5_1();
        //zad5_2();
        //zad5_3();
        //zad5_4();
        //zad5_5();
        zad5_6();
    }
    static void zad5_1()
    {
        int[] a = new int[5];

        for (int i = 0; i < 5; i++) {
            Console.Write($"Podaj {i + 1} element tablicy: ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = a[0];
        int indeks = 0;

        for (int i = 1;i < 5; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                indeks = i;
            }
        }

        Console.Write($"Najwieksza wartosc to {max} i znajduje sie na {indeks} pozycji w tabeli");
    }
    static void zad5_2()
    {
        int[] wektor1;
        int[] wektor2;
        int a, x, n1, n2;
        Console.WriteLine("OPERACJE NA WEKTORACH");
        Console.WriteLine("1. Mnozenie wektora przez liczbe");
        Console.WriteLine("2. Mnozenie wektora przez wektor\n");
        Console.Write("Podaj numer operacji ktora chcesz wykonac: ");
        x = Convert.ToInt32(Console.ReadLine());

        switch (x)
        {
            case 1:
                Console.Write("\nPodaj wymiar wektora: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                wektor1 = new int[n1];
                for (int i = 0; i < n1; i++)
                {
                    Console.Write($"Podaj {i + 1} element wektora: ");
                    wektor1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("\nPodaj liczbe przez ktora chcesz przemnozyc wektor: ");

                a = Convert.ToInt32(Console.ReadLine());

                //wypisywanie wektora
                Console.WriteLine("\nWEKTOR\n");
                for (int i = 0; i < n1; i++)
                {
                    Console.WriteLine(wektor1[i]);
                }

                //wypisywanie wyniku
                Console.WriteLine("\nWEKTOR PO PRZEMNOZENIU\n");
                for (int i = 0; i < n1; i++)
                {
                    wektor1[i] = wektor1[i] * a;
                    Console.WriteLine(wektor1[i]);
                }

                break;
            case 2:
                //zakladam mnozenie wektorow jako mnozenie kazdego elementu z kazdym, a nastepnie bez ich sumowania!!
                //zatem wynikiem dzialania bedzie wektor takiego samego rozmiaru jak wektory wejsciowe
                Console.Write("\nPodaj wymiar pierwszego wektora: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                wektor1 = new int[n1];
                Console.Write("Podaj wymiar drugiego wektora: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                wektor2 = new int[n2];
                if (n1 == n2)
                {
                    for (int i = 0; i < n1; i++)
                    {
                        Console.Write($"Podaj {i + 1} element pierwszego wektora: ");
                        wektor1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("");

                    for (int j = 0; j < n2; j++)
                    {
                        Console.Write($"Podaj {j + 1} element drugiego wektora: ");
                        wektor2[j] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("\nWEKTOR A\n");
                    for (int i = 0; i < n1; i++)
                    {
                        Console.WriteLine(wektor1[i]);
                    }

                    Console.WriteLine("\nWEKTOR B\n");
                    for (int i = 0; i < n1; i++)
                    {
                        Console.WriteLine(wektor2[i]);
                    }

                    Console.WriteLine("\nWEKTOR PO PRZEMNOZENIU\n");
                    for (int k = 0; k < n1; k++)
                    {
                        wektor2[k] = wektor1[k] * wektor2[k];
                        Console.WriteLine(wektor2[k]);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Wymiary wektorow musza byc takie same, aby je przemnozyc!!");
                    break;
                }
            default:
                Console.WriteLine("\nPodales niewlasciwy numer!!\n");
                zad5_2();
                break;
        }
    }
    static void zad5_3()
    {
        int a, x, m, n, k, l;
        int[] wektor;
        int[,] macierz1;
        int[,] macierz2;

        Console.WriteLine("OPERACJE NA MACIERZACH");
        Console.WriteLine("1. Mnozenie macierzy przez liczbe");
        Console.WriteLine("2. Mnozenie macierzy przez wektor");
        Console.WriteLine("3. Mnozenie macierzy przez macierz\n");
        Console.Write("Podaj numer operacji ktora chcesz wykonac: ");
        x = Convert.ToInt32(Console.ReadLine());

        switch (x)
        {
            case 1:
                Console.Write("\nPodaj ilosc wierszy macierzy: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj ilosc kolumn macierzy: ");
                n = Convert.ToInt32(Console.ReadLine());
                macierz1 = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"Podaj element macierzy o indeksie {i + 1}{j + 1}: ");
                        macierz1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nPodaj liczbe przez ktora chcesz przemnozyc macierz: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                //wypisywanie macierzy
                Console.WriteLine("\nMACIERZ\n");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == n - 1)
                        {
                            Console.Write(macierz1[i, j] + "\n");
                        }
                        else
                        {
                            Console.Write(macierz1[i, j] + " ");
                        }
                    }
                }

                Console.WriteLine("\nMACIERZ PO PRZEMNOZENIU\n");
                //wypisywanie wyniku
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        macierz1[i, j] = macierz1[i, j] * a;
                        if(j == n - 1)
                        {
                            Console.Write(macierz1[i, j] + "\n");
                        }
                        else
                        {
                            Console.Write(macierz1[i, j] + " ");
                        }
                    }
                }

                break;
            case 2:
                Console.Write("\nPodaj ilosc wierszy macierzy: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj ilosc kolumn macierzy: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj wymiar wektora: ");
                k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (n == k)
                {
                    macierz1 = new int[m, n];
                    wektor = new int[k];
                    int[] wynik = new int[m];

                    //uzupelnianie macierzy
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write($"Podaj element macierzy o indeksie {i + 1}{j + 1}: ");
                            macierz1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("");

                    //uzupelnianie wektora
                    for (int i = 0; i < k; i++)
                    {
                        Console.Write($"Podaj {i + 1} element wektora: ");
                        wektor[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    //wypisywanie macierzy
                    Console.WriteLine("\nMACIERZ\n");
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j == n - 1)
                            {
                                Console.Write(macierz1[i, j] + "\n");
                            }
                            else
                            {
                                Console.Write(macierz1[i, j] + " ");
                            }
                        }
                    }

                    //wypisywanie wektora
                    Console.WriteLine("\nWEKTOR\n");
                    for (int i = 0; i < k; i++)
                    {
                        Console.WriteLine(wektor[i]);
                    }

                    //mnozenie
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            wynik[i] = wynik[i] + (macierz1[i, j] * wektor[j]); 
                        }
                    }

                    //wypisywanie wyniku
                    Console.WriteLine("\nMACIERZ PO PRZEMNOZENIU\n");
                    for (int i = 0; i < m; i++)
                    {
                        Console.WriteLine(wynik[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Liczba elementow wiersza musi odpowiadac liczbie kolumn macierzy!!!");
                    break;
                }
                break;
            case 3:
                Console.Write("\nPodaj ilosc wierszy pierwszej macierzy: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj ilosc kolumn pierwszej macierzy: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj ilosc wierszy drugiej macierzy: ");
                k = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj ilosc kolumn drugiej macierzy: ");
                l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (n == k)
                {
                    macierz1 = new int[m, n];
                    macierz2 = new int[k, l];
                    int[,] wynik = new int[m, l];
                    //uzupelnianie macierzy 1
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write($"Podaj element macierzy o indeksie {i + 1}{j + 1}: ");
                            macierz1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("");

                    //uzupelnianie macierzy 2
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < l; j++)
                        {
                            Console.Write($"Podaj element macierzy o indeksie {i + 1}{j + 1}: ");
                            macierz2[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    //wypisywanie macierzy 1
                    Console.WriteLine("\nMACIERZ A\n");
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j == n - 1)
                            {
                                Console.Write(macierz1[i, j] + "\n");
                            }
                            else
                            {
                                Console.Write(macierz1[i, j] + " ");
                            }
                        }
                    }

                    //wypisywanie macierzy 2
                    Console.WriteLine("\nMACIERZ B\n");
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = 0; j < l; j++)
                        {
                            if (j == l - 1)
                            {
                                Console.Write(macierz2[i, j] + "\n");
                            }
                            else
                            {
                                Console.Write(macierz2[i, j] + " ");
                            }
                        }
                    }

                    //mnozenie elementow
                    for (int i = 0; i < m; i++)
                    {
                        for (int p = 0; p < l; p++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                wynik[i, p] = wynik[i, p] + macierz1[i, j] * macierz2[j, p];
                            }

                        }
                    }

                    //wypisywanie
                    Console.WriteLine("\nMACIERZ PO PRZEMNOZENIU\n");
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < l; j++)
                        {
                            if(j == l - 1)
                            {
                                Console.Write(wynik[i, j] + "\n");
                            }
                            else
                            {
                                Console.Write(wynik[i, j] + " ");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Liczba kolumn pierwszej macierzy musi odpowiadac liczbie wierszy drugiej macierzy!!!");
                    break;
                }
                break;
            default:
                Console.WriteLine("\nPodales niewlasciwy numer!!\n");
                zad5_3();
                break;
        }
    }
    static void zad5_4()
    {
        int[ , ] a = new int[5, 5];

        for(int i = 0; i <= 4; i++)
        {
            for(int j = 0; j <= 4; j++)
            {
                if(i == j)
                {
                    a[i, j] = 1;
                }
                else if (j == 4 - i)
                {
                    a[i, j] = 1;
                }
                else
                {
                    a[i, j] = 0;
                }
            }
        }

        //wypisywanie
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j == 4)
                {
                    Console.Write(a[i, j] + "\n");
                }
                else
                {
                    Console.Write(a[i, j] + " ");
                }
            }
        }
    }
    static void zad5_5()
    {
        int n;
        int[] tab;
        int x;
        Console.WriteLine("SORTOWANIE BABELKOWE - TABLICA JEDNOWYMIAROWA\n");
        Console.Write("Podaj liczbe elementow tablicy: ");
        n = Convert.ToInt32(Console.ReadLine());
        tab = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Podaj {i + 1} element tablicy: ");
            tab[i] = Convert.ToInt32(Console.ReadLine());
        }

        //wypisywanie tablicy
        Console.WriteLine("\nTABLICA PRZED SORTOWANIEM\n");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(tab[i]);
        }

        //sortowanie babelkowe
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = 0; j < n - 1; j++)
            {
                if (tab[j + 1] < tab[j])
                {
                    x = tab[j];
                    tab[j] = tab[j + 1];
                    tab[j + 1] = x;
                }
            }
        }

        //wypisywanie tablicy po sortowaniu
        Console.WriteLine("\nTABLICA PO SORTOWANIU\n");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
    static void zad5_6()
    {
        int n;
        int[] tab;
        int x;
        Console.WriteLine("SORTOWANIE PO MAX - TABLICA JEDNOWYMIAROWA\n");
        Console.Write("Podaj liczbe elementow tablicy: ");
        n = Convert.ToInt32(Console.ReadLine());
        tab = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Podaj {i + 1} element tablicy: ");
            tab[i] = Convert.ToInt32(Console.ReadLine());
        }

        //wypisywanie tablicy
        Console.WriteLine("\nTABLICA PRZED SORTOWANIEM\n");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(tab[i]);
        }


        //sortowanie
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (tab[j] > tab[i])
                {
                    x = tab[j];
                    tab[j] = tab[i];
                    tab[i] = x;
                }
            }
        }

        //wypisywanie tablicy po sortowaniu
        Console.WriteLine("\nTABLICA PO SORTOWANIU\n");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}
