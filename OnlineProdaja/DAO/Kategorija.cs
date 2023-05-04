using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAO
{
    internal class Kategorija
    {
        public int IdKategorija { get; set; }
        public string? Naziv { get; set; }

        public Kategorija(String n)
        {
            Naziv = n;
        }
        public Kategorija(int i, String n)
        {
            IdKategorija = i;
            Naziv = n;
        }
        public Kategorija() { }
        public override bool Equals(object? obj)
        {
            return obj is Kategorija proizvoda &&
                   IdKategorija == proizvoda.IdKategorija;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdKategorija);
        }

        public override string? ToString()
        {
            return Naziv;
        }
    }
}
