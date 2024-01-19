using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți elementele vectorului, separate prin spațiu: ");
        int[] vector = CitesteVector();

        int rezultat = GasesteElementMajoritar(vector);

        if (rezultat != -1)
        {
            Console.WriteLine($"Elementul majoritar este: {rezultat}");
        }
        else
        {
            Console.WriteLine("Nu există element majoritar în vector.");
        }


        Console.ReadKey();
    }

    static int[] CitesteVector()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }

    static int GasesteElementMajoritar(int[] vector)
    {
        int candidat = -1;
        int contor = 0;

        foreach (int element in vector)
        {
            if (contor == 0)
            {
                candidat = element;
                contor = 1;
            }
            else if (candidat == element)
            {
                contor++;
            }
            else
            {
                contor--;
            }
        }


        int aparitiiCandidat = 0;
        foreach (int element in vector)
        {
            if (element == candidat)
            {
                aparitiiCandidat++;
            }
        }

        if (aparitiiCandidat > vector.Length / 2)
        {
            return candidat;
        }

        return -1;
    }
}
