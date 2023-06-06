using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Valige meetod (1-3):");
        int valik = int.Parse(Console.ReadLine());

        switch (valik)
        {
            case 1:
                Meetod1();
                break;
            case 2:
                Meetod2();
                break;
            case 3:
                Meetod3();
                break;
            default:
                Console.WriteLine("Vale valik!");
                break;
        }

        // Järgmine rida hoiab programmi käivitamiseks konsooliakent avatuna.
        Console.ReadLine();
    }

    static void Meetod1()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        if (numbers.Any())
        {
            int sum = numbers.Sum();
            Console.WriteLine("Sum: " + sum);
        }
        else
        {
            Console.WriteLine("The collection is empty.");
        }
    }

    static void Meetod2()
    {
        Console.WriteLine("Sisestage tekst, mida soovite faili salvestada:");
        string tekst = Console.ReadLine();

        Console.WriteLine("Sisestage faili salvestuskoht:");
        string salvestuskoht = Console.ReadLine();

        try
        {
            if (Directory.Exists(Path.GetDirectoryName(salvestuskoht)))
            {
                File.WriteAllText(salvestuskoht, tekst);
                Console.WriteLine("Tekst on edukalt salvestatud faili.");
            }
            else
            {
                Console.WriteLine("Vigane salvestuskoht! Kausta ei eksisteeri.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Viga faili salvestamisel: " + ex.Message);
        }

        // Järgmine rida hoiab programmi käivitamiseks konsooliakent avatuna.
        Console.ReadLine();
    }

    static void Meetod3()
    {
        int korgus = 3;
        int number = 1;

        for (int i = 1; i <= korgus; i++)
        {
            for (int j = 1; j <= korgus - i; j++)
            {
                Console.Write("  ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write("{0:D2} ", number);
                number++;
            }

            Console.WriteLine();
        }
    }
}
