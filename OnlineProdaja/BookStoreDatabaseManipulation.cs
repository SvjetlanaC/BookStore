using MySql.Data.MySqlClient;
using SportShop.DAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
   
    internal class BookStoreDatabaseManipulation
    {
        private static readonly string connectionString = "server=localhost;database=bookstorehci;uid=root;pwd=root;";// ConfigurationManager.ConnectionStrings["bookstorehci"].ConnectionString;

        public static List<Kategorija> GetCategories()
        {
            List<Kategorija> result = new List<Kategorija>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT IdKategorija, Naziv FROM `kategorija` ";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Kategorija()
                {
                    IdKategorija = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                });
            }
            reader.Close();
            conn.Close();
            return result;
        }
        public static bool DeleteCategory(String name)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM `kategorija` WHERE Naziv=@Naziv";
            cmd.Parameters.AddWithValue("@Naziv", name);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        public static void UpdateCategory(String name,String oldName)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE `kategorija` SET Naziv=@Naziv WHERE Naziv=@Naziv2";
            cmd.Parameters.AddWithValue("@Naziv", name);
            cmd.Parameters.AddWithValue("@Naziv2", oldName);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static List<Korisnik> GetUsers()
        {
            List<Korisnik> result = new List<Korisnik>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT IdKorisnik,Ime,Prezime,KorisnickoIme,Lozinka,Email,Admnistrator,Tema Naziv FROM `korisnik` ";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Korisnik()
                {
                    IdKorisnik = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime= reader.GetString(2),
                    KorisnickoIme= reader.GetString(3),
                    Lozinka = reader.GetString(4),
                    Email = reader.GetString(5),
                    Administrator = reader.GetInt32(6),
                    Tema=reader.GetInt32(7)

                });
            }
            reader.Close();
            conn.Close();
            Trace.WriteLine("aaaaa"+result.ToArray());
            return result;
        }
        public static List<Povez> GetPovez()
        {
            List<Povez> result = new List<Povez>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT IdPovez,Naziv FROM `povez` ";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Povez()
                {
                    IdPovez = reader.GetInt32(0),
                    Naziv = reader.GetString(1),
                });
            }
            reader.Close();
            conn.Close();
            Trace.WriteLine("aaaaa" + result.ToArray());
            return result;
        }
        public static void InsertUser(Korisnik c)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"INSERT INTO korisnik(Ime,Prezime,KorisnickoIme,Lozinka,Email,Admnistrator,Tema)
                  VALUES (@Ime,@Prezime,@KorisnickoIme,@Lozinka,@Email,@Admnistrator,@Tema)";
            cmd.Parameters.AddWithValue("@Ime", c.Ime);
            cmd.Parameters.AddWithValue("@Prezime", c.Prezime);
            cmd.Parameters.AddWithValue("@KorisnickoIme", c.KorisnickoIme);
            cmd.Parameters.AddWithValue("@Lozinka", c.Lozinka);
            cmd.Parameters.AddWithValue("@Email", c.Email);
            cmd.Parameters.AddWithValue("@Admnistrator", c.Administrator);
            cmd.Parameters.AddWithValue("@Tema", 2);
            cmd.ExecuteNonQuery();
            c.IdKorisnik = (int)cmd.LastInsertedId;
            conn.Close();
        }
        public static void UpdateUser(Korisnik c)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE `korisnik` SET Ime=@Ime,Prezime=@Prezime,KorisnickoIme=@KorisnickoIme,Lozinka=@Lozinka,Email=@Email,Admnistrator=@Admnistrator WHERE IdKorisnik=@IdKorisnik";
            cmd.Parameters.AddWithValue("@IdKorisnik", c.IdKorisnik);
            cmd.Parameters.AddWithValue("@Ime", c.Ime);
            cmd.Parameters.AddWithValue("@Prezime", c.Prezime);
            cmd.Parameters.AddWithValue("@KorisnickoIme", c.KorisnickoIme);
            cmd.Parameters.AddWithValue("@Lozinka", c.Lozinka);
            cmd.Parameters.AddWithValue("@Email", c.Email);
            cmd.Parameters.AddWithValue("@Admnistrator", c.Administrator);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static bool DeleteUser(String name)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM `korisnik` WHERE KorisnickoIme=@KorisnickoIme";
            cmd.Parameters.AddWithValue("@KorisnickoIme", name);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        public static void InsertCategory(Kategorija c)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"INSERT INTO kategorija(Naziv)
                  VALUES (@Naziv)";
            cmd.Parameters.AddWithValue("@Naziv", c.Naziv);
            
            cmd.ExecuteNonQuery();
            c.IdKategorija = (int)cmd.LastInsertedId;
            conn.Close();
        }
        public static int GetCategoryIdByName(Kategorija c)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT IdKategorija FROM kategorija WHERE Naziv=@Naziv";
            cmd.Parameters.AddWithValue("@Naziv", c.Naziv);
            MySqlDataReader reader = cmd.ExecuteReader();
            int id=90;
            while(reader.Read()){
                id = reader.GetInt32(0);
            }
            reader.Close();
            conn.Close();
            return id;
            
        }
        public static int GetCoverIdByName(Povez c)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT IdPovez FROM povez WHERE Naziv=@Naziv";
            cmd.Parameters.AddWithValue("@Naziv", c.Naziv);
            MySqlDataReader reader = cmd.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            Trace.WriteLine("sjsjsjjs " + id);
            reader.Close();
            conn.Close();
            return id;

        }
        public static int GetUserIdByName(String c)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT IdKorisnik FROM korisnik WHERE KorisnickoIme=@Naziv";
            cmd.Parameters.AddWithValue("@Naziv", c);
            MySqlDataReader reader = cmd.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            Trace.WriteLine("sjsjsjjs " + id);
            reader.Close();
            conn.Close();
            return id;

        }

        public static int GetTheme(String username)
        {
            
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Tema FROM `korisnik` WHERE KorisnickoIme=@KorisnickoIme";
            cmd.Parameters.AddWithValue("@KorisnickoIme",username);
            MySqlDataReader reader=cmd.ExecuteReader();
            reader.Read();
            int theme=reader.GetInt32(0);
            reader.Close();
            conn.Close();
            return theme;
        }
        public static void UpdateTheme(String username,int theme)
        {

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE `korisnik` SET Tema=@Tema WHERE KorisnickoIme=@KorisnickoIme";
            cmd.Parameters.AddWithValue("@KorisnickoIme", username);
            cmd.Parameters.AddWithValue("@Tema",theme);
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }

        public static List<Proizvod> GetProducts()
        {
            List<Proizvod> result = new List<Proizvod>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd=conn.CreateCommand();
            cmd.CommandText = "SELECT IdProizvod,proizvod.Naziv,povez.IdPovez,povez.Naziv as Povez,kategorija.Naziv as Kategorija,kategorija.IdKategorija,Opis,Kolicina,Cijena FROM bookstorehci.proizvod INNER JOIN bookstorehci.kategorija ON proizvod.IdKategorija=kategorija.IdKategorija INNER JOIN bookstorehci.povez ON proizvod.IdPovez=povez.IdPovez";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Proizvod()
                {
                    IdProizvod = reader.GetInt32(0),
                    Naziv = reader.GetString(1),
                    Povez = new Povez(){
                        IdPovez = reader.GetInt32(2),
                        Naziv = reader.GetString(3),
                    },
                    Kategorija =new Kategorija()
                    {
                        IdKategorija= reader.GetInt32(5),
                        Naziv=reader.GetString(4),
                    },
                    Opis = reader.GetString(6),
                    Cijena = reader.GetDecimal(8),
                    Kolicina = reader.GetInt32(7),
                   

                });
            }
            reader.Close();
            conn.Close();
            return result;
        }

        public static void InsertProduct(Proizvod c)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"INSERT INTO proizvod(Naziv,IdPovez,IdKategorija,Cijena,Opis,Kolicina)
                  VALUES (@Naziv,@IdPovez,@IdKategorija,@Cijena,@Opis,@Kolicina)";
            cmd.Parameters.AddWithValue("@Naziv", c.Naziv);
            cmd.Parameters.AddWithValue("@IdPovez", c.Povez.IdPovez);
            cmd.Parameters.AddWithValue("@IdKategorija", c.Kategorija.IdKategorija);
            cmd.Parameters.AddWithValue("@Cijena", c.Cijena);
            cmd.Parameters.AddWithValue("@Opis", c.Opis);
            cmd.Parameters.AddWithValue("@Kolicina", c.Kolicina);
            cmd.ExecuteNonQuery();
            c.IdProizvod = (int)cmd.LastInsertedId;
            conn.Close();
        }
        public static void UpdateQuantityProduct(Proizvod c,int q)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE `proizvod` SET Kolicina=@Kolicina-@pom WHERE Naziv=@Naziv";
            cmd.Parameters.AddWithValue("@IdProizvod", c.IdProizvod);
            cmd.Parameters.AddWithValue("@Naziv", c.Naziv);
            
            cmd.Parameters.AddWithValue("@Kolicina", c.Kolicina);
            cmd.Parameters.AddWithValue("@pom", q);
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static bool DeleteProduct(String name)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM `proizvod` WHERE Naziv=@Naziv";
            cmd.Parameters.AddWithValue("@Naziv", name);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }

        public static void UpdateProduct(Proizvod c)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE `proizvod` SET Naziv=@Naziv,Opis=@Opis,Kolicina=@Kolicina,Cijena=@Cijena,IdKategorija=@IdKategorija,IdPovez=@IdPovez WHERE IdProizvod=@IdProizvod";
            cmd.Parameters.AddWithValue("@IdProizvod", c.IdProizvod);
            cmd.Parameters.AddWithValue("@Naziv", c.Naziv);
            cmd.Parameters.AddWithValue("@Opis", c.Opis);
            cmd.Parameters.AddWithValue("@Kolicina", c.Kolicina);
            cmd.Parameters.AddWithValue("@Cijena", c.Cijena);
            cmd.Parameters.AddWithValue("@IdKategorija", c.Kategorija.IdKategorija);
            cmd.Parameters.AddWithValue("@IdPovez", c.Povez.IdPovez);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void InsertBill(Racun c)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"INSERT INTO racun(IdKorisnik,Datum)
                  VALUES (@IdKorisnik,@Datum)";
            cmd.Parameters.AddWithValue("@IdKorisnik", c.IdKorisnik);
            cmd.Parameters.AddWithValue("@Datum", c.Date);
            
            cmd.ExecuteNonQuery();
            c.Id = (int)cmd.LastInsertedId;
            conn.Close();
        }
        public static void InsertBillProduct(Proizvod c, int id)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"INSERT INTO proizvodracun(IdProizvod,IdRacun,Cijena,Kolicina)
                  VALUES (@IdProizvod,@IdRacun,@Cijena,@Kolicina)";
            cmd.Parameters.AddWithValue("@IdProizvod", c.IdProizvod);
            cmd.Parameters.AddWithValue("@Cijena", c.Cijena);
            cmd.Parameters.AddWithValue("@Cijena", c.Kolicina);

            cmd.ExecuteNonQuery();
            
            conn.Close();
        }
        

    }
    

}
