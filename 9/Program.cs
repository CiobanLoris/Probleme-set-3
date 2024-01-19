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

        Console.Write("Introduceți k (numărul de poziții pentru rotație spre stânga): ");
        int k = Convert.ToInt32(Console.ReadLine());

        
        RotireSpreStanga(vector, k);

        
        Console.WriteLine($"Vectorul rotit spre stânga cu {k} poziții:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }

        
        Console.ReadKey();
    }

    static void RotireSpreStanga(int[] vector, int k)
    {
        if (vector.Length <= 1 || k % vector.Length == 0)
        {
            return;
        }

        k = k % vector.Length; 

        
        int[] auxiliar = new int[k];
        Array.Copy(vector, auxiliar, k);

        
        for (int i = 0; i < vector.Length - k; i++)
        {
            vector[i] = vector[i + k];
        }

        
        Array.Copy(auxiliar, 0, vector, vector.Length - k, k);
    }
}
