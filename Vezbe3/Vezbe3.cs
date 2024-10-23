using System.Collections;
using Vezbe3;

internal class Program
{
    private static void Main(string[] args)
    {
        Greeting greeting = new Greeting()
        {
            title = "Zdravo",
            text = "Svete"
        };

        Console.WriteLine(greeting.text);
        Console.WriteLine(greeting.title);
        ArrayList lista = new ArrayList();
        lista.Add("a");
        lista.Add("b");
        foreach (string slovo in lista)
        {
            Console.Write(slovo + ",");
        }

        List<Kartica> kartice = new List<Kartica>();
        kartice.Add(new Kartica("123", "321", 10000, "Aleksa", "Velickovic"));
        Bankomat bankomat = new Bankomat(kartice, new ArrayList(), 100000);
        bankomat.kartice.Add(new Kartica("123", "321", 10000, "Aleksa", "Velickovic"));
        bankomat.kartice.Add(new Kartica("111", "222", 500, "Pera", "Peric"));
        Console.WriteLine("Molimo Vas ulogujte se: ");
        String broj = Console.ReadLine();
        String pin = Console.ReadLine();
        int izbor = int.Parse(Console.ReadLine());
        if (bankomat.UlogujSe(broj, pin))
        {
            bankomat.inicijalizujBankomat(izbor, bankomat.kartice.Find(kartica => kartica.pin == pin)); // Ovako se trazi specifican element Liste po nekom parametru
        }
        else
        {
            Console.WriteLine("Neuspesan Login!");
        }

    }
}