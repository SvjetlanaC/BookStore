using BookStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAO
{
    internal class Proizvod
    {
       

        public Proizvod(int v1, string? v2, string? v3,string v4,decimal v5,string v6,int v7)
        {
            IdProizvod = v1;
            Naziv=v2;
            Povez=new Povez(v3);
            Kategorija=new Kategorija(v4);
            Cijena = v5;
            Opis = v6;
            Kolicina= v7;
        }
        public Proizvod() { }

        public int IdProizvod { get; set; }
        public string? Opis { get; set; }

        public String Naziv { get; set; }

        public Kategorija? Kategorija { get; set; }
        public Povez? Povez { get; set; }
        public decimal Cijena { get; set; }
   
        public int Kolicina { get; set; }
        public override string? ToString()
        {
            return Naziv+"               "+ Kolicina+"x"+Cijena+"          "+(Kolicina*Cijena);
        }
    }

   

}
