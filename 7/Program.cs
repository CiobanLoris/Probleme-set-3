using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți lungimea vectorului: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Lungimea vectorului este invalidă.");
            return;
        }

        int[] vector = new int[n];

        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceți elementul {i + 1}: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        InversareVector(vector);

        
        Console.WriteLine("Vectorul inversat:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }

        
        Console.ReadKey();
    }

    static void InversareVector(int[] vector)
    {
        int i = 0;
        int j = vector.Length - 1;

        while (i < j)
        {
            
            int temp = vector[i];
            vector[i] = vector[j];
            vector[j] = temp;

            
            i++;
            j--;
        }
    }
}
