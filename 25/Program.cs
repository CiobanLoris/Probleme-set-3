using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți elementele primului vector (v1) sortat crescător, separate prin spațiu: ");
        int[] v1 = CitesteVector();

        Console.Write("Introduceți elementele celui de-al doilea vector (v2) sortat crescător, separate prin spațiu: ");
        int[] v2 = CitesteVector();

        int[] rezultat = Interclasare(v1, v2);

        AfisareVector("Vectorul rezultat (Interclasare): ", rezultat);


        Console.ReadKey();
    }

    static int[] CitesteVector()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }

    static int[] Interclasare(int[] v1, int[] v2)
    {
        int n1 = v1.Length;
        int n2 = v2.Length;
        int[] rezultat = new int[n1 + n2];

        int i = 0, j = 0, k = 0;


        while (i < n1 && j < n2)
        {
            if (v1[i] <= v2[j])
            {
                rezultat[k] = v1[i];
                i++;
            }
            else
            {
                rezultat[k] = v2[j];
                j++;
            }
            k++;
        }


        while (i < n1)
        {
            rezultat[k] = v1[i];
            i++;
            k++;
        }


        while (j < n2)
        {
            rezultat[k] = v2[j];
            j++;
            k++;
        }

        return rezultat;
    }

    static void AfisareVector(string mesaj, int[] vector)
    {
        Console.Write($"{mesaj}{{ ");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine("}");
    }
}
