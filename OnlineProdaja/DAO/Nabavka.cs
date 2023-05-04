using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAO
{
    internal class Nabavka
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public DateTime Date { get; set; }
    }
}
