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

        
        

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (vector[i] == vector[j])
                {
                    
                    for (int k = j; k < n - 1; k++)
                    {
                        vector[k] = vector[k + 1];
                    }

                    n--; 
                    j--; 
                }
            }
        }
        
        Console.WriteLine("Vectorul fără elemente duplicate:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(vector[i] + " ");
        }

        Console.ReadKey();
    }

    
}
