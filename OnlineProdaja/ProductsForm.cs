using BookStore;
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

namespace SportShop
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            SellerForm f=new SellerForm();
            FormsUtil.OpenForm(this, f);
        }
        List<Proizvod> products= BookStoreDatabaseManipulation.GetProducts();
        private void UpdateGrid()
        {

            products = BookStoreDatabaseManipulation.GetProducts();
            guna2DataGridView1.DataSource = BookStoreDatabaseManipulation.GetProducts();
            //guna2DataGridView1.Columns["IdPovez"].Visible = false;
            //guna2DataGridView1.Columns["IdKategorija"].Visible = false;
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            currentTheme = BookStoreDatabaseManipulation.GetTheme(Form1.username);
            if (TranslateAndThemeUtil.language.Equals("SRB"))
            {
                label8.Text = "SRB";
                TranslateToSrb();
                TranslateAndThemeUtil.language = label8.Text;
            }
            else
            {
                label8.Text = "ENG";
                TranslateToEng();
                TranslateAndThemeUtil.language = label8.Text;
            }
            CheckTheme();
            UpdateGrid();
            LoadCovers();
            LoadCategories();
        }
        private void LoadCovers()
        {
            List<Povez> covers = BookStoreDatabaseManipulation.GetPovez();
            foreach(Povez p in covers)
            {
                comboBox1.Items.Add(p.Naziv);
                comboBox5.Items.Add(p.Naziv);

            }

        }
        private void LoadCategories()
        {
            List<Kategorija> categories = BookStoreDatabaseManipulation.GetCategories();
            foreach (Kategorija c in categories)
            {
                comboBox2.Items.Add(c.Naziv);
                comboBox3.Items.Add(c.Naziv);
            }

        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormsUtil.Logout(this);
        }

        private void buttonBookTheme_Click(object sender, EventArgs e)
        {
            BookTheme f=new BookTheme();
            FormsUtil.OpenForm(this, f);
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangeTheme_Click(object sender, EventArgs e)
        {
            ChangeTheme();
        }
        int currentTheme = 2;
        public void ChangeTheme()
        {
            if (currentTheme == 0)
            {
                label1.ForeColor = Color.DimGray;
                this.BackColor = Color.Black;
                buttonSellers.FillColor = Color.DimGray;
                buttonBookTheme.FillColor = Color.DimGray;
               
                buttonLogout.FillColor = Color.DimGray;
                currentTheme = 1;
                TranslateAndThemeUtil.theme = 0;
            }
            else if (currentTheme == 1)
            {
                label1.ForeColor = Color.DarkBlue;
                this.BackColor = Color.SkyBlue;
                buttonSellers.FillColor = Color.CornflowerBlue;

                buttonBookTheme.FillColor = Color.CornflowerBlue;
                
                buttonLogout.FillColor = Color.CornflowerBlue;
                currentTheme = 2;
                TranslateAndThemeUtil.theme = 1;
            }
            else
            {
                label1.ForeColor = Color.FromArgb(255, 255, 192);
                this.BackColor = Color.DarkSlateGray;
                buttonSellers.FillColor = Color.DarkSlateGray;
                buttonBookTheme.FillColor = Color.DarkSlateGray;
               
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
                buttonSellers.FillColor = Color.DimGray;
                buttonBookTheme.FillColor = Color.DimGray;
               
                buttonLogout.FillColor = Color.DimGray;
                currentTheme = 1;
            }
            else if (TranslateAndThemeUtil.theme == 1)
            {
                label1.ForeColor = Color.DarkBlue;
                this.BackColor = Color.SkyBlue;
                buttonSellers.FillColor = Color.CornflowerBlue;

                buttonBookTheme.FillColor = Color.CornflowerBlue;
                
                buttonLogout.FillColor = Color.CornflowerBlue;
                currentTheme = 2;
            }
            else
            {
                label1.ForeColor = Color.FromArgb(255, 255, 192);
                this.BackColor = Color.DarkSlateGray;
                buttonSellers.FillColor = Color.DarkSlateGray;
                buttonBookTheme.FillColor = Color.DarkSlateGray;
                
                buttonLogout.FillColor = Color.DarkSlateGray;
                currentTheme = 0;
            }
        }
        private void TranslateToSrb()
        {
            label2.Text = "Naziv";
            label1.Text = "Proizvodi";
            label3.Text = "Količina";
            label7.Text = "Kategorija";
            label6.Text = "Povez";
            label4.Text = "Cijena";
            label5.Text = "Opis";

            buttonAdd.Text = "DODAJ";
            buttonDelete.Text = "OBRIŠI";
            buttonEdit.Text = "AŽURIRAJ";
            buttonLogout.Text = "ODJAVI SE";
            
            buttonBookTheme.Text = "Kategorije";
            buttonSellers.Text = "Prodavci";
            buttonChangeTheme.Text = "Teme";
            refreshButton.Text = "OSVJEŽI";
        }
        private void TranslateToEng()
        {
            label2.Text = "Name";
            
            label3.Text = "Quantity";
            label7.Text = "Category";
            label6.Text = "Cover";
            label4.Text = "Price";
            label5.Text = "Description";

            label1.Text = "Manage products";
            buttonAdd.Text = "ADD";
            buttonDelete.Text = "DELETE";
            buttonEdit.Text = "EDIT";
            buttonLogout.Text = "LOGOUT";
            
            buttonBookTheme.Text = "Categories";
            buttonSellers.Text = "Sellers";
            buttonChangeTheme.Text = "Change Theme";
            refreshButton.Text = "REFRESH";

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text.Equals("SRB"))
            {
                label8.Text = "SRB";
                TranslateToSrb();
                TranslateAndThemeUtil.language = label8.Text;
            }
            else
            {
                label8.Text = "ENG";
                TranslateToEng();
                TranslateAndThemeUtil.language = label8.Text;
            }
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = guna2DataGridView1.CurrentRow.Index;

            richTextBox1.Text = guna2DataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            textBox1.Text = guna2DataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            comboBox2.Text = guna2DataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            comboBox1.Text = guna2DataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            textBox2.Text = guna2DataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            textBox3.Text = guna2DataGridView1.Rows[rowindex].Cells[6].Value.ToString();


        }

        private bool IsPresentProduct()
        {
            foreach (Proizvod k in products)
            {
                if (textBox1.Text.Equals(k.Naziv))
                {


                    return true;
                }
            }
            return false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.SelectedItem==null || comboBox2.SelectedItem==null)
            {
                MessageBox.Show("Data is missing!");
            }
            else
            {
                if (!IsPresentProduct())
                {
                    Trace.WriteLine(comboBox1.Text);
                    int idCategory=BookStoreDatabaseManipulation.GetCategoryIdByName(new Kategorija(comboBox2.Text));
                    int idCover = BookStoreDatabaseManipulation.GetCoverIdByName(new Povez(comboBox1.Text));

                    Trace.WriteLine("categoriy:" +idCategory+"    cover:"+idCover);
                    BookStoreDatabaseManipulation.InsertProduct(new Proizvod()
                    {
                        Naziv = textBox1.Text,
                        Kolicina = Int32.Parse(textBox2.Text),
                        Cijena = Decimal.Parse(textBox3.Text),
                        Opis= richTextBox1.Text,
                        Povez=new Povez(idCover, comboBox1.Text),
                        Kategorija=new Kategorija(idCategory,comboBox2.Text)
                    });
                    UpdateGrid();
                }
                else
                {
                    TranslateAndThemeUtil.CheckLanguage(label4, "Korisnicko ime već postoji!", "Username already exists!");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!IsPresentProduct())
            {
                TranslateAndThemeUtil.CheckLanguage(label8, "Odabrana knjiga za brisanje ne postoji!", "This book does not exist!");
                return;
            }
            if (BookStoreDatabaseManipulation.DeleteProduct(textBox1.Text))
            {
                TranslateAndThemeUtil.CheckLanguage(label8, "Proizvod uspjesno obrisan!", "Product successfully deleted!");
                UpdateGrid();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int idCategory = BookStoreDatabaseManipulation.GetCategoryIdByName(new Kategorija(comboBox2.Text));
            int idCover = BookStoreDatabaseManipulation.GetCoverIdByName(new Povez(comboBox1.Text));
            Proizvod p = new Proizvod()
            {
                IdProizvod = Int32.Parse(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()),
                Naziv = textBox1.Text,
                Opis = richTextBox1.Text,
                Kolicina = Int32.Parse(textBox2.Text),
                Cijena = Int32.Parse(textBox3.Text),
                Kategorija = new Kategorija(idCategory,comboBox2.Text),
                Povez=new Povez(idCover,comboBox1.Text),
            };
            BookStoreDatabaseManipulation.UpdateProduct(p);

            TranslateAndThemeUtil.CheckLanguage(label4, "Proizvod uspjesno ažuriran!", "Product successfully updated!");
            UpdateGrid();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            List<Proizvod> books = products;
            if (textBox4.Text != "")
            {
                books = products.Where(p => p.Naziv.ToLower().StartsWith(textBox4.Text.ToLower())).ToList();
            }
           
            if(comboBox3.SelectedItem != null)
            {
                books = books.Where(p => p.Kategorija.Naziv.Equals(comboBox3.Text)).ToList();
            }

            if (comboBox5.SelectedItem != null)
            {
                books = books.Where(p => p.Povez.Naziv.Equals(comboBox5.Text)).ToList();
            }

            guna2DataGridView1.DataSource = books;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            guna2DataGridView1.DataSource = products;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
