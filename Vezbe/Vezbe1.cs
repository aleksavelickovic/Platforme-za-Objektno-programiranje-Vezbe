using System.Collections;
using System.Collections.Generic;

internal class Vezbe1
{
    public static void Main(string[] args)
    {
        zadatak1();
        //zadatak1a():
        //zadatak2();
        //zadatak3();
        //zadatak4();
        //zadatak5();

    }

    private static void zadatak1()
    {
        Console.WriteLine("Molimo Vas unesite broj: ");
        int input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " X " + input + " = " + i * input);
        }
    }

    private static void zadatak1a()
    {
        bool isNumberValid = false;
        do
        {
            Console.WriteLine("Molimo Vas unesite broj: ");
            string input = Console.ReadLine();
            if (input != null)
            {
                try
                {
                    int inputReader = int.Parse(input);
                    isNumberValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Molimo Vas unesite validan broj!");
                }

            }
            else
            {
                Console.WriteLine("Greska");
            }
        } while (!isNumberValid);
    }

    private static void zadatak2()
    {
        Console.WriteLine("Unesite broj");
        string input = Console.ReadLine();
        int fact = 1;
        for (int i = 1; i <= int.Parse(input); i++)
        {
            fact = fact * i;
            Console.WriteLine(i);
        }
        Console.WriteLine(fact);
    }

    private static void zadatak3()
    {
        Console.WriteLine("Unesite tekst: ");
        string tekst = Console.ReadLine();
        if (tekst == null)
        {
            Console.WriteLine("Greska: Unet tekst je null.");
            return;
        }

        Console.WriteLine("Unesite substring: ");
        string podstring = Console.ReadLine();

        int brojacPogodaka = 0;
        for (int i = 0; i <= tekst.Length - podstring.Length; i++)
        {
            for (int j = podstring.Length; j > 0; j--)
            {
                if (tekst.Substring(i, j).Equals(podstring))
                {
                    Console.WriteLine("Postoji substring i on se nalazi izmedju sledecih indexa: " + i + " i " + (i + j - 1));
                    brojacPogodaka += 1;
                }
            }
        }
        if (brojacPogodaka == 0)
        {
            Console.WriteLine("Substring nije pronadjen.");
        }
    }

    private static void zadatak4()
    {
        int brojac = 0;
        Console.WriteLine("Unesite rec:");
        String? rec = Console.ReadLine();
        char[] charArray = rec.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(charArray);
        if (rec.Equals(new String(charArray)))
        {
            Console.WriteLine("Rec je palindrom!");
        }
        else
        {
            for (int i = 0; i < rec.Length; i++)
            {
                //Console.WriteLine(rec[i]);
                //Console.WriteLine(charArray[i]);
                if (rec[i] != charArray[i])
                {
                    brojac += 1;
                }
            }
            Console.WriteLine("Rec nije palindrom, potrebno je zameniti " + brojac + " karaktera!");
        }
    }

    private static void zadatak5()
    {
        Random random = new Random();
        Console.WriteLine("Unesite broj nasumicnih brojeva: ");
        int unos = int.Parse(Console.ReadLine());
        List<int> nizNasumicnihBrojeva = new List<int>();
        for (int i = 0; i <= unos; i++)
        {
            nizNasumicnihBrojeva.Add(random.Next(100));
        }
        nizNasumicnihBrojeva.Sort();
        Console.WriteLine(string.Join(",", nizNasumicnihBrojeva));
        Console.WriteLine("Unesite broj: ");
        int broj = int.Parse(Console.ReadLine());
        int brojac = 0;
        foreach (int i in nizNasumicnihBrojeva)
        {
            if (i == broj)
            {
                Console.WriteLine("Broj se nalazi na indexu: " + brojac);
            }
            brojac += 1;
        }
    }

}