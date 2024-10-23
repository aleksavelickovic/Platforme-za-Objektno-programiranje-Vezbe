using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe3
{
    internal class Kartica
    {
        public String broj { get; set; }
        public String pin { get; set; }
        public int novac { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }


        public Kartica(string broj, string pin, int novac, string ime, string prezime)
        {
            this.broj = broj;
            this.pin = pin;
            this.novac = novac;
            this.ime = ime;
            this.prezime = prezime;
        }

        public Kartica()
        {
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return "BrojKartice: " + this.broj;
        }
    }

}
