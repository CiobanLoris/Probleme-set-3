using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea vectorului: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] vector = new int[n];

        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        int suma = CalculeazaSuma(vector);

        Console.WriteLine($"Suma elementelor vectorului este: {suma}");

        
        Console.ReadKey();
    }

    static int CalculeazaSuma(int[] vector)
    {
        int suma = 0;

        foreach (int element in vector)
        {
            suma += element;
        }

        return suma;
    }
}
