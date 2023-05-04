using OnlineProdaja;
using SportShop;
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
    public partial class BookTheme : Form
    {
        public BookTheme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SellerForm f = new SellerForm();

            this.Hide();
            f.ShowDialog();
            Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();

            this.Hide();
            f.ShowDialog();
            Close();
        }
        private void CheckTheme()
        {
            if (TranslateAndThemeUtil.theme == 0)
            {
                label1.ForeColor = Color.DimGray;
                this.BackColor = Color.Black;
                buttonProducts.FillColor = Color.DimGray;
                buttonSellers.FillColor = Color.DimGray;
               
                buttonLogout.FillColor = Color.DimGray;
                currentTheme = 1;
            }
            else if (TranslateAndThemeUtil.theme == 1)
            {
                label1.ForeColor = Color.DarkBlue;
                this.BackColor = Color.SkyBlue;
                buttonProducts.FillColor = Color.CornflowerBlue;

                buttonSellers.FillColor = Color.CornflowerBlue;
               
                buttonLogout.FillColor = Color.CornflowerBlue;
                currentTheme = 2;
            }
            else
            {
                label1.ForeColor = Color.FromArgb(255, 255, 192);
                this.BackColor = Color.DarkSlateGray;
                buttonProducts.FillColor = Color.DarkSlateGray;
                buttonSellers.FillColor = Color.DarkSlateGray;
               
                buttonLogout.FillColor = Color.DarkSlateGray;
                currentTheme = 0;
            }
        }
        int currentTheme = 2;
        public void ChangeTheme()
        {
            if (currentTheme == 0)
            {
                label1.ForeColor = Color.DimGray;
                this.BackColor = Color.Black;
                buttonProducts.FillColor = Color.DimGray;
                buttonSellers.FillColor = Color.DimGray;
                
                buttonLogout.FillColor = Color.DimGray;
                currentTheme = 1;
                TranslateAndThemeUtil.theme = 0;
            }
            else if (currentTheme == 1)
            {
                label1.ForeColor = Color.DarkBlue;
                this.BackColor = Color.SkyBlue;
                buttonProducts.FillColor = Color.CornflowerBlue;

                buttonSellers.FillColor = Color.CornflowerBlue;
              
                buttonLogout.FillColor = Color.CornflowerBlue;
                currentTheme = 2;
                TranslateAndThemeUtil.theme = 1;
            }
            else
            {
                label1.ForeColor = Color.FromArgb(255, 255, 192);
                this.BackColor = Color.DarkSlateGray;
                buttonProducts.FillColor = Color.DarkSlateGray;
                buttonSellers.FillColor = Color.DarkSlateGray;
               
                buttonLogout.FillColor = Color.DarkSlateGray;
                TranslateAndThemeUtil.theme = 2;
                currentTheme = 0;
            }
        }
        private void TranslateToSrb()
        {
            label2.Text = "Naziv:";
            label1.Text = "Kategorije";
            buttonAdd.Text = "DODAJ";
            buttonDelete.Text = "OBRIŠI";
            buttonEdit.Text = "AŽURIRAJ";
            buttonLogout.Text = "ODJAVI SE";
           
            buttonSellers.Text = "Prodavci";
            buttonProducts.Text = "Proizvodi";
            buttonChangeTheme.Text = "Teme";
        }
        private void TranslateToEng()
        {
            label2.Text = "Name:";
            label1.Text = "Manage book categories";
            buttonAdd.Text = "ADD";
            buttonDelete.Text = "DELETE";
            buttonEdit.Text = "EDIT";
            buttonLogout.Text = "LOGOUT";
            
            buttonSellers.Text = "Sellers";
            buttonProducts.Text = "Products";
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
        private void BookTheme_Load(object sender, EventArgs e)
        {
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

        }
        static List<Kategorija> categories = BookStoreDatabaseManipulation.GetCategories();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Name is missing!");
            }
            else
            {
                if (!IsPresent())
                {
                    BookStoreDatabaseManipulation.InsertCategory(new Kategorija(textBox1.Text));
                    UpdateGrid();
                }
            }
        }
        private bool IsPresent()
        {
            foreach (Kategorija k in categories)
            {
                if (textBox1.Text.Equals(k.Naziv))
                {
                    MessageBox.Show("Category already exists!");
                    return true;
                }
            }
            return false;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int rowindex = guna2DataGridView1.CurrentCell.RowIndex;
            int columnindex = guna2DataGridView1.CurrentCell.ColumnIndex;


            if (textBox1.Text != "")
            {
                if (!IsPresent())
                {
                    BookStoreDatabaseManipulation.UpdateCategory(textBox1.Text, guna2DataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString());
                    UpdateGrid();
                }
            }
            else
            {
                TranslateAndThemeUtil.CheckLanguage(label4,"Kategorija već postoji!","Category already exists!");
            }
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormsUtil.Logout(this);
        }

        private void buttonSellers_Click(object sender, EventArgs e)
        {
            SellerForm f = new SellerForm();

            FormsUtil.OpenForm(this, f);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonChangeTheme_Click(object sender, EventArgs e)
        {
            ChangeTheme();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void UpdateGrid()
        {
            categories = BookStoreDatabaseManipulation.GetCategories();
            guna2DataGridView1.DataSource = BookStoreDatabaseManipulation.GetCategories();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach(Kategorija k in categories)
            {
                if (k.Naziv.Equals(textBox1.Text))
                {
                    check = true;
                }
            }
            if (!check)
            {
                TranslateAndThemeUtil.CheckLanguage(label4, "Odabrani naziv ne postoji!", "Category does not exist!");
                return;
            }
            if (BookStoreDatabaseManipulation.DeleteCategory(textBox1.Text))
            {
                TranslateAndThemeUtil.CheckLanguage(label4, "Kategorija uspjesno obrisana!", "Category successfully deleted!");
                UpdateGrid();
            }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ProductsForm f = new ProductsForm();
            FormsUtil.OpenForm(this, f);
        }
    }
}
