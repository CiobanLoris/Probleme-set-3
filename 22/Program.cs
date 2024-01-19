using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți elementele primului vector (v1), separate prin spațiu: ");
        int[] v1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.Write("Introduceți elementele celui de-al doilea vector (v2), separate prin spațiu: ");
        int[] v2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


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

    static int[] Intersectie(int[] v1, int[] v2)
    {
        return v1.Intersect(v2).ToArray();
    }

    static int[] Reuniune(int[] v1, int[] v2)
    {
        return v1.Union(v2).ToArray();
    }

    static int[] Diferenta(int[] v1, int[] v2)
    {
        return v1.Except(v2).ToArray();
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
