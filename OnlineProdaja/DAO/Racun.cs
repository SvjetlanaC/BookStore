using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAO
{
    internal class Racun
    {
        public int Id { get; set; }
        public int IdKorisnik { get; set;}
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
