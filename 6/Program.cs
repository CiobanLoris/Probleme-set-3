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

        Console.Write("Introduceti pozitia k de la care doriti sa stergeti elementul: ");
        int k = Convert.ToInt32(Console.ReadLine());

        

        
        int aux = 0;

        if (k < 0 || k >= vector.Length)
        {
            Console.WriteLine("Pozitia de stergere este invalida.");
            return;
        }
        else
        {
            while(k < n-1)
            {
                aux = vector[k];
                vector[k] = vector[k + 1];
                vector[k + 1] = aux;
                k++;
            }
        }
        
        Console.WriteLine("Vectorul actualizat:");
        for (int i = 0; i < n-1; i++)
        {
            Console.Write(vector[i] + " ");
        }

        Console.ReadKey();
    }

   
}
