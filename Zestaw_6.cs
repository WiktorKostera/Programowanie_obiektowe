using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        labirynt();
    }
    static void labirynt()
    {
        char[,] labirynt = new char[12, 12] {
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
            {'#', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '#'},
            {'.', '.', '#', '.', '#', '.', '#', '#', '#', '#', '.', '#'},
            {'#', '#', '#', '.', '#', '.', '.', '.', '.', '#', '.', '#'},
            {'#', '.', '.', '.', '.', '#', '#', '#', '.', '#', '.', '.'},
            {'#', '#', '#', '#', '.', '#', '.', '#', '.', '#', '.', '#'},
            {'#', '.', '.', '#', '.', '#', '.', '#', '.', '#', '.', '#'},
            {'#', '#', '.', '#', '.', '#', '.', '#', '.', '#', '.', '#'},
            {'#', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '#'},
            {'#', '#', '#', '#', '#', '#', '.', '#', '#', '#', '.', '#'},
            {'#', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '#'},
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
           };
        wypisywanie(labirynt);
        przesuwanie(labirynt, 4, 10, 2);
    }

    //jako poczatkowa pozycje nalezy podac druga pozycje od wejscia do labiryntu,
    //jako argument kierunku poruszania sie, nalezy podac wartosc prowadzaca od wejscia do srodka
    //k == 1 (w prawo), k == 2 (w gore), k == 3 (w lewo), k == 4 (w dol)

    static void wypisywanie(char[ , ] tab)
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                if (j == 11)
                {
                    Console.WriteLine(tab[i, j]);
                }
                else
                {
                    Console.Write(tab[i, j] + " ");
                }
            }
        }
        Console.WriteLine("");
    }

    static int przesuwanie(char[,] tab, int i, int j, int k)
    {
        if (i + 1 == 12 | j + 1 == 12 | i - 1 == -1 | j - 1 == -1)
        {
            return 1;
        }
        else if (k == 1)
        {
            if (tab[i + 1, j] == '#')
            {
                if (tab[i, j + 1] == '.')
                {
                    tab[i, j + 1] = 'X';
                    tab[i, j] = '.';
                    wypisywanie(tab);
                    return przesuwanie(tab, i, j + 1, 1);
                }
                else 
                {
                    return przesuwanie(tab, i, j, 2);
                }
            }
            else
            {
                tab[i + 1, j] = 'X';
                tab[i, j] = '.';
                wypisywanie(tab);
                return przesuwanie(tab, i + 1, j, 4);
            }
        }
        else if (k == 2)
        {
            if (tab[i, j + 1] == '#')
            {
                if (tab[i - 1, j] == '.')
                {
                    tab[i - 1, j] = 'X';
                    tab[i, j] = '.';
                    wypisywanie(tab);
                    return przesuwanie(tab, i - 1, j, 2);
                }
                else
                {
                    return przesuwanie(tab, i, j, 3);
                }
            }
            else
            {
                tab[i, j + 1] = 'X';
                tab[i, j] = '.';
                wypisywanie(tab);
                return przesuwanie(tab, i, j + 1, 1);
            }
        }
        else if (k == 3)
        {
            if (tab[i - 1, j] == '#')
            {
                if (tab[i, j - 1] == '.')
                {
                    tab[i, j - 1] = 'X';
                    tab[i, j] = '.';
                    wypisywanie(tab);
                    return przesuwanie(tab, i, j - 1, 3);
                }
                else 
                {
                    return przesuwanie(tab, i, j, 4);
                }
            }
            else
            {
                tab[i - 1, j] = 'X';
                tab[i, j] = '.';
                wypisywanie(tab);
                return przesuwanie(tab, i - 1, j, 2);
            }
        }
        else
        {
            if (tab[i, j - 1] == '#')
            {
                if (tab[i + 1, j] == '.')
                {
                    tab[i + 1, j] = 'X';
                    tab[i, j] = '.';
                    wypisywanie(tab);
                    return przesuwanie(tab, i + 1, j, 4);
                }
                else 
                {
                    return przesuwanie(tab, i, j, 1);
                }
            }
            else
            {
                tab[i, j - 1] = 'X';
                tab[i, j] = '.';
                wypisywanie(tab);
                return przesuwanie(tab, i, j - 1, 3);
            }
        }
    }
}
