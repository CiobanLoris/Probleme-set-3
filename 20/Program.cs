using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceți primul șirag de mărgele (s1): ");
        string s1 = Console.ReadLine();

        Console.Write("Introduceți al doilea șirag de mărgele (s2): ");
        string s2 = Console.ReadLine();

        int numarSuprapuneri = NumarSuprapuneri(s1, s2);

        Console.WriteLine($"Numărul de suprapuneri este: {numarSuprapuneri}");


        Console.ReadKey();
    }

    static int NumarSuprapuneri(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;
        int numarSuprapuneri = 0;


        for (int i = 0; i < n; i++)
        {
            int contor = 0; 


            for (int j = 0; j < m && i + j < n; j++)
            {
                if (s1[j] == s2[i + j])
                {
                    contor++;
                }
                else
                {
                    break; 
                }
            }

            numarSuprapuneri += contor;
        }

        return numarSuprapuneri;
    }
}
