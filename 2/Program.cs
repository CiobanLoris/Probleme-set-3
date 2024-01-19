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

        Console.Write("Introduceti valoarea k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        int pozitie = GasestePozitie(vector, k);

        if (pozitie != -1)
        {
            Console.WriteLine($"Prima pozitie in care apare {k} in vector este: {pozitie}");
        }
        else
        {
            Console.WriteLine($"{k} nu apare in vector. Rezultatul este -1.");
        }

        
        Console.ReadKey();
    }

    static int GasestePozitie(int[] vector, int k)
    {
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] == k)
            {
                return i;
            }
        }

        return -1; 
    }
}
