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


        int cmmdc = CelMaiMareDivizorComun(vector);

        
        Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {cmmdc}");

        
        Console.ReadKey();
    }

    static int CelMaiMareDivizorComun(int[] vector)
    {
        int n = vector.Length;
        int cmmdc = vector[0];

        for (int i = 1; i < n; i++)
        {
            cmmdc = CalculCMDC(cmmdc, vector[i]);

            
            if (cmmdc == 1)
            {
                break;
            }
        }

        return cmmdc;
    }

    static int CalculCMDC(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}
