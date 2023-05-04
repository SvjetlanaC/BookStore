using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAO
{
    internal class Povez
    {
        public int IdPovez
        {
            get; set;
        }
        public Povez(int i,String n)
        {
            IdPovez = i;
            Naziv = n;
        }
        public Povez(String n) 
        { 
            Naziv=n;
        }
        public Povez() { }
        public String Naziv
        {
            get; set;
        }

        public override bool Equals(object? obj)
        {
            return obj is Povez povez &&
                   IdPovez == povez.IdPovez &&
                   Naziv == povez.Naziv;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdPovez, Naziv);
        }

        public override string? ToString()
        {
            return Naziv;
        }
    }
}
