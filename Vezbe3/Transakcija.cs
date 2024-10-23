using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe3
{
    public enum tipTransakcije
    {
        DEPOZIT,
        ISPLATA,
        PROVERA
    }

    internal class Transakcija
    {
        public tipTransakcije tip { get; set; }
        public int iznos { get; set; }
        public Kartica kartica { get; set; }
        public Transakcija(tipTransakcije tip, int iznos, Kartica kartica)
        {
            this.tip = tip;
            this.iznos = iznos;
            this.kartica = kartica;
        }
        public Transakcija()
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
            return "tip: " + this.tip + " ,iznos: " + this.iznos + " , Kartica: " + this.kartica;
        }
    }

}
