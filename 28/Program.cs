using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți elementele vectorului, separate prin spațiu: ");
        int[] vector = CitesteVector();

        Console.WriteLine("Vectorul înainte de sortare:");
        AfisareVector(vector);

        QuickSort(vector, 0, vector.Length - 1);

        Console.WriteLine("Vectorul după sortare:");
        AfisareVector(vector);


        Console.ReadKey();
    }

    static int[] CitesteVector()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }

    static void QuickSort(int[] vector, int stanga, int dreapta)
    {
        if (stanga < dreapta)
        {

            int pivotIndex = Partitie(vector, stanga, dreapta);


            QuickSort(vector, stanga, pivotIndex - 1);
            QuickSort(vector, pivotIndex + 1, dreapta);
        }
    }

    static int Partitie(int[] vector, int stanga, int dreapta)
    {
        int pivot = vector[dreapta];
        int i = stanga - 1;

        for (int j = stanga; j < dreapta; j++)
        {
            if (vector[j] <= pivot)
            {
                i++;
                SchimbaElemente(vector, i, j);
            }
        }

        SchimbaElemente(vector, i + 1, dreapta);

        return i + 1;
    }

    static void SchimbaElemente(int[] vector, int index1, int index2)
    {
        int temp = vector[index1];
        vector[index1] = vector[index2];
        vector[index2] = temp;
    }

    static void AfisareVector(int[] vector)
    {
        foreach (var element in vector)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}
