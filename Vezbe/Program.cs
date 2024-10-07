internal class Program
{
    private static void Main(string[] args)
    {
        //zadatak1():
        //zadatak2();

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

    private static Boolean zadatak3(String tekst, String podstring)
    {
        char[] array = tekst.ToCharArray();
        foreach (char karakter in array)
        {
            Console.WriteLine(karakter);
        }
    }

}