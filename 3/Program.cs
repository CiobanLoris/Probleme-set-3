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

        Tuple<int, int> rezultat = GasesteMinMax(vector);

        Console.WriteLine($"Pozitia celui mai mic element este: {rezultat.Item1}");
        Console.WriteLine($"Pozitia celui mai mare element este: {rezultat.Item2}");

        
        Console.ReadKey();
    }

    static Tuple<int, int> GasesteMinMax(int[] vector)
    {
        if (vector.Length == 0)
        {
            return Tuple.Create(-1, -1); 
        }

        int min, max;
        int start;

        
        if (vector.Length % 2 == 1)
        {
            min = max = vector[0];
            start = 1;
        }
        else
        {
            
            if (vector[0] < vector[1])
            {
                min = vector[0];
                max = vector[1];
            }
            else
            {
                min = vector[1];
                max = vector[0];
            }

            start = 2;
        }

        
        for (int i = start; i < vector.Length; i += 2)
        {
            int primul = vector[i];
            int alDoilea = (i + 1 < vector.Length) ? vector[i + 1] : vector[i]; 

            
            if (primul < alDoilea)
            {
                if (primul < min) min = primul;
                if (alDoilea > max) max = alDoilea;
            }
            else
            {
                if (alDoilea < min) min = alDoilea;
                if (primul > max) max = primul;
            }
        }

        
        int pozitieMin = -1, pozitieMax = -1;

        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] == min && pozitieMin == -1)
            {
                pozitieMin = i;
            }

            if (vector[i] == max)
            {
                pozitieMax = i;
            }
        }

        return Tuple.Create(pozitieMin, pozitieMax);
    }
}
