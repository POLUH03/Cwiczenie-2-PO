using System;

class SortowanieLiczb
{
    private int[] liczby;
    private const int ROZMIAR_TABLICY = 6;

    public SortowanieLiczb()
    {
        liczby = new int[ROZMIAR_TABLICY];
    }

    public void wczytaj_dane()
    {
        Console.WriteLine($"Proszę wprowadzić {ROZMIAR_TABLICY} liczb:");
        for (int i = 0; i < ROZMIAR_TABLICY; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out liczby[i]))
            {
                Console.Write("Nieprawidłowe dane. Proszę wprowadzić liczbę całkowitą: ");
            }
        }
    }

    public void przetwórz_dane()
    {
        // Algorytm sortowania bąbelkowego
        for (int i = 0; i < ROZMIAR_TABLICY - 1; i++)
        {
            for (int j = 0; j < ROZMIAR_TABLICY - i - 1; j++)
            {
                if (liczby[j] > liczby[j + 1])
                {
                    // Zamiana elementów
                    int temp = liczby[j];
                    liczby[j] = liczby[j + 1];
                    liczby[j + 1] = temp;
                }
            }
        }
    }

    public void pokaż_wyniki()
    {
        Console.WriteLine("\nPosortowane liczby:");
        foreach (int liczba in liczby)
        {
            Console.Write($"{liczba} ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SortowanieLiczb sorter = new SortowanieLiczb();
        sorter.wczytaj_dane();
        sorter.przetwórz_dane();
        sorter.pokaż_wyniki();
    }
}