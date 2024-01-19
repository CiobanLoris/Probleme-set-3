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

        
        SortarePrinSelectie(vector);


        Console.WriteLine("Vectorul sortat prin selecție:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }


        Console.ReadKey();
    }

    static void SortarePrinSelectie(int[] vector)
    {
        int n = vector.Length;

        for (int i = 0; i < n - 1; i++)
        {

            int indexMinim = i;
            for (int j = i + 1; j < n; j++)
            {
                if (vector[j] < vector[indexMinim])
                {
                    indexMinim = j;
                }
            }


            int temp = vector[i];
            vector[i] = vector[indexMinim];
            vector[indexMinim] = temp;
        }
    }
}
