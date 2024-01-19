using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți elementele vectorului, separate prin spațiu: ");
        int[] vector = CitesteVector();

        Console.Write("Introduceți indexul dorit în vector (de la 0): ");
        int index = int.Parse(Console.ReadLine());

        int valoareDupaSortare = ValoareDupaSortare(vector, index);

        Console.WriteLine($"Valoarea de pe poziția {index} după sortare este: {valoareDupaSortare}");


        Console.ReadKey();
    }

    static int[] CitesteVector()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }

    static int ValoareDupaSortare(int[] vector, int index)
    {

        if (index >= 0 && index < vector.Length)
        {

            int[] vectorSortat = vector.ToArray();
            Array.Sort(vectorSortat);


            return vectorSortat[index];
        }
        else
        {
            Console.WriteLine("Indexul introdus nu este valid.");
            return -1; 
        }
    }
}
