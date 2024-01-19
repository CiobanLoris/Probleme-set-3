using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți elementele primului vector (v1) în ordine crescătoare, separate prin spațiu: ");
        int[] v1 = CitesteVector();

        Console.Write("Introduceți elementele celui de-al doilea vector (v2) în ordine crescătoare, separate prin spațiu: ");
        int[] v2 = CitesteVector();


        int[] intersectie = Intersectie(v1, v2);
        AfisareMultime("Intersectie: ", intersectie);


        int[] reuniune = Reuniune(v1, v2);
        AfisareMultime("Reuniune: ", reuniune);


        int[] diferenta1 = Diferenta(v1, v2);
        int[] diferenta2 = Diferenta(v2, v1);

        AfisareMultime("Diferenta v1-v2: ", diferenta1);
        AfisareMultime("Diferenta v2-v1: ", diferenta2);


        Console.ReadKey();
    }

    static int[] CitesteVector()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }

    static int[] Intersectie(int[] v1, int[] v2)
    {
        int n1 = v1.Length, n2 = v2.Length;
        int i = 0, j = 0;
        var intersectie = new System.Collections.Generic.List<int>();

        while (i < n1 && j < n2)
        {
            if (v1[i] == v2[j])
            {
                intersectie.Add(v1[i]);
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        return intersectie.ToArray();
    }

    static int[] Reuniune(int[] v1, int[] v2)
    {
        int n1 = v1.Length, n2 = v2.Length;
        int i = 0, j = 0;
        var reuniune = new System.Collections.Generic.List<int>();

        while (i < n1 && j < n2)
        {
            if (v1[i] == v2[j])
            {
                reuniune.Add(v1[i]);
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                reuniune.Add(v1[i]);
                i++;
            }
            else
            {
                reuniune.Add(v2[j]);
                j++;
            }
        }

        while (i < n1)
        {
            reuniune.Add(v1[i]);
            i++;
        }

        while (j < n2)
        {
            reuniune.Add(v2[j]);
            j++;
        }

        return reuniune.ToArray();
    }

    static int[] Diferenta(int[] v1, int[] v2)
    {
        int n1 = v1.Length, n2 = v2.Length;
        int i = 0, j = 0;
        var diferenta = new System.Collections.Generic.List<int>();

        while (i < n1 && j < n2)
        {
            if (v1[i] == v2[j])
            {
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                diferenta.Add(v1[i]);
                i++;
            }
            else
            {
                j++;
            }
        }

        while (i < n1)
        {
            diferenta.Add(v1[i]);
            i++;
        }

        return diferenta.ToArray();
    }

    static void AfisareMultime(string mesaj, int[] multime)
    {
        Console.Write($"{mesaj}{{ ");
        foreach (int element in multime)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine("}");
    }
}
