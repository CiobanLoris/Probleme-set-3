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

        
        SortarePrinInserție(vector);

        
        Console.WriteLine("Vectorul sortat prin inserție:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }

        
        Console.ReadKey();
    }

    static void SortarePrinInserție(int[] vector)
    {
        int n = vector.Length;

        for (int i = 1; i < n; i++)
        {
            int elementCurent = vector[i];
            int j = i - 1;

            
            while (j >= 0 && vector[j] > elementCurent)
            {
                vector[j + 1] = vector[j];
                j--;
            }

            
            vector[j + 1] = elementCurent;
        }
    }
}
