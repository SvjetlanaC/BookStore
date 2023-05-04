using OnlineProdaja;
using SportShop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormsUtil.Logout(this);
        }
        int currentTheme = 2;
        public void ChangeTheme()
        {
            if (currentTheme == 0)
            {
                label1.ForeColor = Color.DimGray;
                this.BackColor = Color.Black;
                
                
                buttonLogout.FillColor = Color.DimGray;
                currentTheme = 1;
                TranslateAndThemeUtil.theme = 0;
            }
            else if (currentTheme == 1)
            {
                label1.ForeColor = Color.DarkBlue;
                this.BackColor = Color.SkyBlue;
               
               
                buttonLogout.FillColor = Color.CornflowerBlue;
                currentTheme = 2;
                TranslateAndThemeUtil.theme = 1;
            }
            else
            {
                label1.ForeColor = Color.FromArgb(255, 255, 192);
                this.BackColor = Color.DarkSlateGray;
                
               
                buttonLogout.FillColor = Color.DarkSlateGray;
                TranslateAndThemeUtil.theme = 2;
                currentTheme = 0;
            }
        }
        private void CheckTheme()
        {
            if (TranslateAndThemeUtil.theme == 0)
            {
                label1.ForeColor = Color.DimGray;
                this.BackColor = Color.Black;
               
                
                buttonLogout.FillColor = Color.DimGray;
                currentTheme = 1;
            }
            else if (TranslateAndThemeUtil.theme == 1)
            {
                label1.ForeColor = Color.DarkBlue;
                this.BackColor = Color.SkyBlue;
                
                
                buttonLogout.FillColor = Color.CornflowerBlue;
                currentTheme = 2;
            }
            else
            {
                label1.ForeColor = Color.FromArgb(255, 255, 192);
                this.BackColor = Color.DarkSlateGray;
               
                buttonLogout.FillColor = Color.DarkSlateGray;
                currentTheme = 0;
            }
        }
        private void buttonChangeTheme_Click(object sender, EventArgs e)
        {
            ChangeTheme();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            label5.Text = Form1.username;
            panel3.BackColor = Color.FromArgb(200, 245, 198, 128);
            currentTheme = BookStoreDatabaseManipulation.GetTheme(Form1.username);
            if (TranslateAndThemeUtil.language.Equals("SRB"))
            {
                label4.Text = "SRB";
                TranslateToSrb();
                TranslateAndThemeUtil.language = label4.Text;
            }
            else
            {
                label4.Text = "ENG";
                TranslateToEng();
                TranslateAndThemeUtil.language = label4.Text;
            }
            CheckTheme();
            UpdateGrid();
            richTextBox1.Text = "=========================== RAČUN =========================\n" + DateTime.Now + "\n==========================================================\n";

        }
        List<Proizvod> products = new List<Proizvod>();
        private void UpdateGrid()
        {
            products = BookStoreDatabaseManipulation.GetProducts();
            guna2DataGridView1.DataSource = BookStoreDatabaseManipulation.GetProducts();
        }
        private void TranslateToSrb()
        {
            label2.Text = "Naziv:";
            label3.Text = "Količina:";
            label1.Text = "Račun";
            buttonAdd.Text = "DODAJ";
            buttonDelete.Text = "OBRIŠI";
            
            buttonLogout.Text = "ODJAVI SE";
            
            buttonChangeTheme.Text = "Teme";
        }
        private void TranslateToEng()
        {
            label2.Text = "Name:";
            label3.Text = "Količina:";
            label1.Text = "Create bill";
            buttonAdd.Text = "ADD";
            buttonDelete.Text = "DELETE ALL";
            
            buttonLogout.Text = "LOGOUT";
            
            buttonChangeTheme.Text = "Change Theme";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("SRB"))
            {
                label4.Text = "SRB";
                TranslateToSrb();
                TranslateAndThemeUtil.language = label4.Text;
            }
            else
            {
                label4.Text = "ENG";
                TranslateToEng();
                TranslateAndThemeUtil.language = label4.Text;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = guna2DataGridView1.CurrentRow.Index;

            
            textBox1.Text = guna2DataGridView1.Rows[rowindex].Cells[2].Value.ToString();
           
            textBox2.Text = guna2DataGridView1.Rows[rowindex].Cells[6].Value.ToString();
            
        }
        
        Dictionary<Proizvod, int> productsToUpdate = new Dictionary<Proizvod, int>();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int rowindex = guna2DataGridView1.CurrentRow.Index;
            int q = Int32.Parse(guna2DataGridView1.Rows[rowindex].Cells[6].Value.ToString());
            if (Int32.Parse(textBox2.Text) <= q)
            {

                Proizvod p = new Proizvod(Int32.Parse(guna2DataGridView1.Rows[rowindex].Cells[0].Value.ToString()), guna2DataGridView1.Rows[rowindex].Cells[2].Value.ToString(), guna2DataGridView1.Rows[rowindex].Cells[3].Value.ToString(), guna2DataGridView1.Rows[rowindex].Cells[4].Value.ToString(), Decimal.Parse(guna2DataGridView1.Rows[rowindex].Cells[5].Value.ToString()), guna2DataGridView1.Rows[rowindex].Cells[1].Value.ToString(), Int32.Parse(guna2DataGridView1.Rows[rowindex].Cells[6].Value.ToString()));
                productsToUpdate.Add(p, Int32.Parse(textBox2.Text));

                richTextBox1.Text += String.Format("{0,10}",p.Naziv) + String.Format("{0,10}",textBox2.Text) + "x" + p.Cijena + "          " + (Int32.Parse(textBox2.Text) * p.Cijena)+"KM\n ";
                Trace.WriteLine(productsToUpdate[p]);
                Trace.WriteLine("" + p.Kategorija + p.Povez + p.Opis + "");
                guna2DataGridView1.Rows[rowindex].Cells[6].Value = Int32.Parse(guna2DataGridView1.Rows[rowindex].Cells[6].Value.ToString()) - Int32.Parse(textBox2.Text);
            }
            else
            {
                MessageBox.Show("There is not enough books in store!");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "=========================== RAČUN =========================\n" +DateTime.Now + "\n==========================================================\n";
            productsToUpdate.Clear();
            UpdateGrid();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            BillPrintForm f = new BillPrintForm(productsToUpdate);

            FormsUtil.OpenHelpForm(f);
        }
    }
}
