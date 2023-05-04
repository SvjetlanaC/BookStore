using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAO
{
    internal class ProizvodRacun
    {
        public int IdProizvod { get; set; }
        public int IdRacun { get; set; }
        public decimal Price { get; set; }
        public int  Quantity { get; set; }
    }
}
