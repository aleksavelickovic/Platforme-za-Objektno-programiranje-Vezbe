using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Vezbe3
{
    internal class Bankomat
    {
        public List<Kartica> kartice { get; set; }
        public ArrayList transakcije { get; set; }
        public int novac { get; set; }
        public Bankomat(List<Kartica> kartice, ArrayList transakcije, int novac)
        {
            this.kartice = kartice;
            kartice.Add(new Kartica()
            {
                broj = "123",
                pin = "321",
                novac = 10000,
                ime = "Aleksa",
                prezime = "Velickovic"
            }); 
            this.transakcije = transakcije;
            this.novac = novac;
        }
        public Bankomat()
        {
        }

        public void inicijalizujBankomat(int izbor, Kartica ulogovan)
        {
            switch (izbor)
            {
                case 1:
                    Console.WriteLine("Iznos na vasem racunu je: " + ulogovan.novac);
                    Transakcija transakcija = new Transakcija(tipTransakcije.PROVERA, 0, ulogovan);
                    this.transakcije.Add(transakcija);
                    ispisiTransakcije();
                    break;
                case 2:
                    Console.WriteLine("Koliko novca zelite da podignete?");
                    int novac = int.Parse(Console.ReadLine());
                    if (novac > this.novac)
                    {
                        Console.WriteLine("Nedovoljno novca u bankomatu!");
                        break;
                    }
                    if (novac > ulogovan.novac)
                    {
                        Console.WriteLine("Nedovoljno novca na Vasem racunu!");
                        break;
                    }
                    ulogovan.novac -= novac;
                    Transakcija transakcija1 = new Transakcija(tipTransakcije.ISPLATA, novac, ulogovan);
                    this.transakcije.Add(transakcija1);
                    Console.WriteLine("Podigli ste novac! Novo stanje na vasem racunu iznosi:" + ulogovan.novac);
                    ispisiTransakcije();
                    break;
            }
        }
        private void ispisiTransakcije()
        {
            Console.WriteLine("ZA DEBAGOVANJE sve transakcije: ");
            foreach (Transakcija transakcija in this.transakcije)
            {
                Console.WriteLine("Transakcija");
            }
        }
    }
}
