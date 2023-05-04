using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAO
{
    internal class Korisnik
    {
        public int IdKorisnik { get; set; }
        public string? Ime  { get; set; }
        public string? Prezime { get; set; }
        public string? KorisnickoIme { get; set; }
        public string? Lozinka { get; set; }
        public string? Email { get; set; }
        public int Administrator { get; set; }
        public int Tema { get; set; }

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
            return base.ToString();
        }
    }
}
