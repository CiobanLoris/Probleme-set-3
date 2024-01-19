using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți numărul în baza 10: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceți baza b (1 < b < 17): ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (b <= 1 || b >= 17)
        {
            Console.WriteLine("Baza introdusă nu este validă.");
            return;
        }

        string rezultat = ConvertireBaza(n, b);

        Console.WriteLine($"Numărul {n} în baza {b} este: {rezultat}");


        Console.ReadKey();
    }

    static string ConvertireBaza(int numar, int baza)
    {
        if (numar == 0)
        {
            return "0";
        }

        string rezultat = "";

        while (numar > 0)
        {
            int rest = numar % baza;
            char cifra;

            if (rest < 10)
            {
                cifra = (char)('0' + rest);
            }
            else
            {
                cifra = (char)('A' + rest - 10);
            }

            rezultat = cifra + rezultat;
            numar /= baza;
        }

        return rezultat;
    }
}
