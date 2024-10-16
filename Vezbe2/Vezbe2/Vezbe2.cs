﻿using ConsoleApp1.TreeStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe
{
    internal class Vezbe2
    {
        public static int Limit = 5000;
        public static void Main(string[] args)
        {
            zadatak6();
            //zadatak7();
        }

        public static int getBrojNiza(List<int> lista, int index)
        {
            if (lista[index] % 7 == 0 && lista[index] != 0)
            {
                return lista[index];
            }
            else
            {
                return getBrojNiza(lista, index + 1);
            }
        }

        public static int BinarnaPretraga(List<int> lista, int broj)
        {
            int levi = 0;
            int desni = lista.Count - 1;

            while (levi <= desni)
            {
                int srednji = (levi + desni) / 2;

                if (lista[srednji] == broj)
                {
                    return srednji;
                }
                else if (lista[srednji] > broj)
                {
                    desni = srednji - 1;
                }
                else
                {
                    levi = srednji + 1;
                }
            }

            return -1;
        }

        public struct Korisnik
        {
            public string BrojKartice;
            public string Pin;
            public int Stanje;

            public Korisnik(string BrojKartice, string Pin, int Stanje)
            {
                this.BrojKartice = BrojKartice;
                this.Pin = Pin;
                this.Stanje = Stanje;
            }
        }

        public static void zadatak6()
        {
            /* S obzirom da materijal za 6ti zadatak nije radio, profesor je umesto njega zadao nadogradnju na Z5a,
            a to je da se rekurzijom pronadje najmanji broj deljiv sa 7 u sortiranom nizu brojeva */

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
            if (BinarnaPretraga(nizNasumicnihBrojeva, broj) == -1)
            {
                Console.WriteLine("Broj ne postoji u ovom nizu.");
            }
            else
            {
                Console.WriteLine("Broj se nalazi na indexu: " + BinarnaPretraga(nizNasumicnihBrojeva, broj));
            }

            // Ovo je resenje zadatka 6:
            Console.WriteLine("Najmanji broj deljiv sa 7 u ovom nizu je: " + getBrojNiza(nizNasumicnihBrojeva, 1));
        }

        public static void zadatak7()
        {
            Dictionary<string, Korisnik> korisnici = new Dictionary<string, Korisnik>();
            Korisnik korisnik1 = new Korisnik("001", "123", 55000);
            Korisnik korisnik2 = new Korisnik("002", "321", 4500);
            Korisnik korisnik3 = new Korisnik("003", "123", 17562);
            korisnici.Add(korisnik1.BrojKartice, korisnik1);
            korisnici.Add(korisnik2.BrojKartice, korisnik2);
            korisnici.Add(korisnik3.BrojKartice, korisnik3);


            Console.WriteLine("Dobrodosli na vankomat! Molimo Vas unesite broj vase kartice: ");
            String brojKartice = Console.ReadLine();
            Korisnik izabranKorisnik = korisnici[brojKartice];
            Console.WriteLine("Molimo sacekajte...");
            Thread.Sleep(3000);
            Console.WriteLine("Molimo Vas unesite Vas PIN: ");
            String pin = Console.ReadLine();
            Console.WriteLine("Molimo sacekajte...");
            Thread.Sleep(1500);
            if (pin == izabranKorisnik.Pin)
            {
                Console.WriteLine("Uspesna prijava! Izaberite funkciju: ");
                Console.WriteLine("1) Upit stanja");
                Console.WriteLine("2) Povlacenje sredstava");
                Console.WriteLine("3) Promena PIN-a");
                int unos = int.Parse(Console.ReadLine());
                switch (unos)
                {
                    case 1:
                        Console.WriteLine("Molimo sacekajte...");
                        Thread.Sleep(2345);
                        Console.WriteLine("Iznos na Vasem racunu iznosi: " + izabranKorisnik.Stanje);
                        break;
                    case 2:
                        Console.WriteLine("Molimo sacekajte...");
                        Thread.Sleep(3000);
                        Console.WriteLine("Koliko novca povlacite sa racuna? ");
                        int iznos = int.Parse(Console.ReadLine());
                        if (iznos > Limit)
                        {
                            Console.WriteLine("Molimo sacekajte...");
                            Thread.Sleep(3500);
                            Console.WriteLine("Prekoracili ste limit!");
                        }
                        else if (iznos > izabranKorisnik.Stanje)
                        {
                            Console.WriteLine("Molimo sacekajte...");
                            Thread.Sleep(999);
                            Console.WriteLine("Nemate dovoljno novca na racunu!");

                        }
                        else
                        {
                            Console.WriteLine("Molimo sacekajte...");
                            Thread.Sleep(1234);
                            Console.WriteLine("Uspesno povlacenje novca!");
                            izabranKorisnik.Stanje -= iznos;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Molimo sacekajte...");
                        Thread.Sleep(4321);
                        Console.WriteLine("Unesite novi PIN:");
                        String UnetPin = Console.ReadLine();
                        izabranKorisnik.Pin = UnetPin;
                        Console.WriteLine("Molimo sacekajte...");
                        Thread.Sleep(1632);
                        Console.WriteLine("Uspesno promenjen PIN");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Pogresan PIN!");
            }
        }

        //public static void Serialize(Tree tree)
        //{
        //    BinaryFormatter b = new BinaryFormatter();
        //    var fileStream = File.Create("path");
        //    b.Serialize(fileStream, tree);
        //    fileStream.Close();
        //}

        //public static Tree Deserialize(string filePath)
        //{
        //    BinaryFormatter b = new BinaryFormatter();
        //    var fileStream = File.OpenRead(filePath);
        //    var tree = (Tree)b.Deserialize(fileStream);
        //    fileStream.Close();
        //    return tree;
        //}


    }
}
