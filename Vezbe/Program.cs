internal class Program
{
    private static void Main(string[] args)
    {
        //zadatak1():
        //zadatak2();
        zadatak3();

    }
    private static void zadatak1()
    {
        bool isNumberValid = false;
        do
        {
            Console.WriteLine("Molimo Vas unesite broj: ");
            String input = Console.ReadLine();
            if (input != null)
            {
                try
                {
                    int inputReader = Int32.Parse(input);
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
        int inputReader = Int32.Parse(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= inputReader; i++)
        {
            fact = fact * i;
            Console.WriteLine(i);
        }
        Console.WriteLine(fact);
    }

    private static void zadatak3()
    {
        Console.WriteLine("Unesite tekst: ");
        String? tekst = Console.ReadLine();
        if (tekst == null)
        {
            Console.WriteLine("Greska: Unet tekst je null.");
            return;
        }

        Console.WriteLine("Unesite substring: ");
        String? podstring = Console.ReadLine();
        if (podstring == null)
        {
            Console.WriteLine("Greska: Unet substring je null.");
            return;
        }

        for (int i = 0; i <= tekst.Length - podstring.Length; i++)
        {
            for (int j = podstring.Length; j > 0; j--)
            {
                if (tekst.Substring(i, j).Equals(podstring))
                {
                    Console.WriteLine("Postoji substring i on se nalazi izmedju sledecih indexa: " + i + " i " + (i + j - 1));
                    return;
                }
            }
        }

        Console.WriteLine("Substring nije pronadjen.");
    }

}