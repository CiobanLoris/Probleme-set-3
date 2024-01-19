using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea vectorului: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Lungimea vectorului este invalida.");
            return;
        }

        int[] vector = new int[n];

        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Introduceti valoarea e pe care doriti sa o inserati: ");
        int e = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti pozitia k pe care doriti sa o inserati: ");
        int k = Convert.ToInt32(Console.ReadLine());


        if (k < 0 || k > vector.Length)
        {
            Console.WriteLine("Pozitia de inserare este invalida.");
            
        }
        else
        {
            vector[k] = e;
        }

        Console.WriteLine("Vectorul actualizat:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }
        Console.ReadKey();
    }

  
}
