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

        
        RotireSpreStanga(vector);

        
        Console.WriteLine("Vectorul rotit spre stânga:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }

        
        Console.ReadKey();
    }

    static void RotireSpreStanga(int[] vector)
    {
        if (vector.Length <= 1)
        {
            
            return;
        }

        int primulElement = vector[0];

        
        for (int i = 0; i < vector.Length - 1; i++)
        {
            vector[i] = vector[i + 1];
        }

        
        vector[vector.Length - 1] = primulElement;
    }
}
