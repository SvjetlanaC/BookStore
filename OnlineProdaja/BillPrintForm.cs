using OnlineProdaja;
using SportShop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class BillPrintForm : Form
    {
        public BillPrintForm()
        {
            InitializeComponent();
        }
        Dictionary<Proizvod, int> productsToUpdate=new Dictionary<Proizvod, int>();
        internal BillPrintForm(Dictionary<Proizvod, int> mapa)
        {
            InitializeComponent();
            productsToUpdate=mapa;
        }
        private void BillPrintForm_Load(object sender, EventArgs e)
        {
            decimal total = 0;
            richTextBox1.Text = "=========================== RAČUN =========================\n" + DateTime.Now + "\n==========================================================\n";
            foreach (KeyValuePair<Proizvod, int> entry in productsToUpdate)
            {
                total += entry.Value * entry.Key.Cijena;
                richTextBox1.Text += entry.Key.Naziv+ "               " + entry.Value + "x" + entry.Key.Cijena + "          "+ (entry.Value * entry.Key.Cijena)+"KM\n";
            }
            richTextBox1.Text += "\n=========================== ===== =========================\n";
            richTextBox1.Text += "Ukupno: " + total+"KM";
            richTextBox1.Text += "\n=========================== ===== =========================\n";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Racun racun = new Racun() { IdKorisnik=BookStoreDatabaseManipulation.GetUserIdByName(Form1.username),Date= DateTime.Now };
            BookStoreDatabaseManipulation.InsertBill(racun);
            foreach (KeyValuePair<Proizvod, int> entry in productsToUpdate)
            {
                BookStoreDatabaseManipulation.UpdateQuantityProduct(entry.Key, entry.Value);
                MessageBox.Show("Database updated!");
                this.Hide();
            }
            
        }
    }
}
