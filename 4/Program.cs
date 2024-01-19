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

        GasesteMinMaxSiAparitii(vector);

        
        Console.ReadKey();
    }

    static void GasesteMinMaxSiAparitii(int[] vector)
    {
        if (vector.Length == 0)
        {
            Console.WriteLine("Vectorul este gol.");
            return;
        }

        int minim = vector[0];
        int maxim = vector[0];
        int aparitiiMinim = 1;
        int aparitiiMaxim = 1;

        for (int i = 1; i < vector.Length; i++)
        {
            int element = vector[i];

            if (element < minim)
            {
                minim = element;
                aparitiiMinim = 1;
            }
            else if (element == minim)
            {
                aparitiiMinim++;
            }

            if (element > maxim)
            {
                maxim = element;
                aparitiiMaxim = 1;
            }
            else if (element == maxim)
            {
                aparitiiMaxim++;
            }
        }

        Console.WriteLine($"Cea mai mică valoare este {minim} și apare de {aparitiiMinim} ori.");
        Console.WriteLine($"Cea mai mare valoare este {maxim} și apare de {aparitiiMaxim} ori.");
    }
}
