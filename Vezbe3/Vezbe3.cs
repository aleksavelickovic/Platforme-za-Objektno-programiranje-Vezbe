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
        Console.WriteLine("Molimo Vas ulogujte se: ");
        int broj = int.Parse(Console.ReadLine());
        int pin = int.Parse(Console.ReadLine());
        int brojac = 0;
        for (int i = 0; i < bankomat.kartice.Count; i++)
        {
            if (bankomat.kartice[i].pin.Equals(pin) && bankomat.kartice[i].broj.Equals(broj))
            {
                Console.WriteLine("Dobrodosli na bankomat, izaberite opciju 1-3: ");
                Kartica ulogovan = (Kartica)bankomat.kartice[i];
                Console.WriteLine("Ulogovani ste kao: " + ulogovan.ime + " " + ulogovan.prezime);
                int izbor = int.Parse(Console.ReadLine());
                bankomat.inicijalizujBankomat(izbor, ulogovan);
            }
            else
            {
                Console.WriteLine("TESTTESTTEST");
            }
            brojac++;
        }

    }
}