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

        
        Console.WriteLine("Introduceți elementele vectorului (sortate în ordine crescătoare):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceți elementul {i + 1}: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Introduceți elementul căutat k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        
        int pozitie = CautareBinara(vector, k);

        
        if (pozitie != -1)
        {
            Console.WriteLine($"Elementul {k} se află la poziția {pozitie} în vector.");
        }
        else
        {
            Console.WriteLine($"Elementul {k} nu a fost găsit în vector.");
        }

        
        Console.ReadKey();
    }

    static int CautareBinara(int[] vector, int k)
    {
        int stanga = 0;
        int dreapta = vector.Length - 1;

        while (stanga <= dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;

            if (vector[mijloc] == k)
            {
                return mijloc; 
            }
            else if (vector[mijloc] < k)
            {
                stanga = mijloc + 1; 
            }
            else
            {
                dreapta = mijloc - 1; 
            }
        }

        return -1; 
    }
}
