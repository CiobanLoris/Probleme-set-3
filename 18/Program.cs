using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți gradul polinomului: ");
        int n = Convert.ToInt32(Console.ReadLine());


        double[] coeficienti = new double[n + 1];


        for (int i = 0; i <= n; i++)
        {
            Console.Write($"Introduceți coeficientul a{i}: ");
            coeficienti[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.Write("Introduceți valoarea lui x: ");
        double x = Convert.ToDouble(Console.ReadLine());


        double rezultat = CalculValoarePolinom(coeficienti, x);

        Console.WriteLine($"Valoarea polinomului la x = {x} este: {rezultat}");


        Console.ReadKey();
    }

    static double CalculValoarePolinom(double[] coeficienti, double x)
    {
        int n = coeficienti.Length - 1;
        double rezultat = 0;

        for (int i = 0; i <= n; i++)
        {
            rezultat += coeficienti[i] * Math.Pow(x, i);
        }

        return rezultat;
    }
}
