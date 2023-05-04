using BookStore;
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

namespace SportShop
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ChangeTheme();
        }
        int currentTheme = 2;
        public void ChangeTheme()
        {
            if (currentTheme == 0)
            {
                label1.ForeColor = Color.DimGray;
                this.BackColor= Color.Black;
                buttonProducts.FillColor= Color.DimGray;
                buttonBookTheme.FillColor = Color.DimGray;
                
                buttonLogout.FillColor = Color.DimGray;
                currentTheme = 1;
                TranslateAndThemeUtil.theme = 0;
            }else if(currentTheme == 1)
            {
                label1.ForeColor = Color.DarkBlue;
                this.BackColor = Color.SkyBlue;
                buttonProducts.FillColor = Color.CornflowerBlue;
                
                buttonBookTheme.FillColor = Color.CornflowerBlue;
                
                buttonLogout.FillColor = Color.CornflowerBlue;
                currentTheme = 2;
                TranslateAndThemeUtil.theme = 1;
            }
            else
            {
                label1.ForeColor = Color.FromArgb(255, 255, 192);
                this.BackColor = Color.DarkSlateGray;
                buttonProducts.FillColor = Color.DarkSlateGray;
                buttonBookTheme.FillColor = Color.DarkSlateGray;
               
                buttonLogout.FillColor = Color.DarkSlateGray;
                TranslateAndThemeUtil.theme = 2;
                currentTheme = 0;
            }
        }

        private void TranslateToSrb()
        {
            label2.Text = "Ime";
            label1.Text = "Prodavci";
            label3.Text = "Korisničko ime";
            label8.Text = "Prezime";
            label6.Text = "Lozinka";

            buttonAdd.Text = "DODAJ";
            buttonDelete.Text = "OBRIŠI";
            buttonEdit.Text = "AŽURIRAJ";
            buttonLogout.Text = "ODJAVI SE";
           
            buttonBookTheme.Text = "Kategorije";
            buttonProducts.Text = "Proizvodi";
            buttonChangeTheme.Text = "Teme";
        }
        private void TranslateToEng()
        {
            label2.Text = "Name";
            label3.Text = "Username";
            label8.Text = "Surname";
            label6.Text = "Password";

            label1.Text = "Manage sellers";
            buttonAdd.Text = "ADD";
            buttonDelete.Text = "DELETE";
            buttonEdit.Text = "EDIT";
            buttonLogout.Text = "LOGOUT";
           
            buttonBookTheme.Text = "Categories";
            buttonProducts.Text = "Products";
            buttonChangeTheme.Text = "Change Theme";

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text.Equals("SRB"))
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
        List<Korisnik> users= BookStoreDatabaseManipulation.GetUsers();
        List<Kategorija> categories = BookStoreDatabaseManipulation.GetCategories();
        private void UpdateGrid()
        {
            
            users = BookStoreDatabaseManipulation.GetUsers();
            guna2DataGridView1.DataSource = BookStoreDatabaseManipulation.GetUsers();
            guna2DataGridView1.Columns["Tema"].Visible = false;
        }
        
       
        private bool IsPresentUser()
        {
            foreach (Korisnik k in users)
            {
                if (textBox2.Text.Equals(k.KorisnickoIme))
                {
                    
                    
                    return true;
                }
            }
            return false;
        }
        private void SellerForm_Load(object sender, EventArgs e)
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
        private void CheckTheme()
        {
            if (TranslateAndThemeUtil.theme == 0)
            {
                label1.ForeColor = Color.DimGray;
                this.BackColor = Color.Black;
                buttonProducts.FillColor = Color.DimGray;
                buttonBookTheme.FillColor = Color.DimGray;
                
                buttonLogout.FillColor = Color.DimGray;
                currentTheme = 1;
            }
            else if (TranslateAndThemeUtil.theme == 1)
            {
                label1.ForeColor = Color.DarkBlue;
                this.BackColor = Color.SkyBlue;
                buttonProducts.FillColor = Color.CornflowerBlue;

                buttonBookTheme.FillColor = Color.CornflowerBlue;
               
                buttonLogout.FillColor = Color.CornflowerBlue;
                currentTheme = 2;
            }
            else
            {
                label1.ForeColor = Color.FromArgb(255, 255, 192);
                this.BackColor = Color.DarkSlateGray;
                buttonProducts.FillColor = Color.DarkSlateGray;
                buttonBookTheme.FillColor = Color.DarkSlateGray;
                
                buttonLogout.FillColor = Color.DarkSlateGray;
                currentTheme = 0;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FormsUtil.Logout(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            BookTheme f = new BookTheme();
            FormsUtil.OpenForm(this, f);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Name is missing!");
            }
            else
            {
                if (!IsPresentUser())
                {
                    BookStoreDatabaseManipulation.InsertUser(new Korisnik()
                    {
                        Ime = textBox1.Text,
                        Prezime = textBox4.Text,
                        KorisnickoIme = textBox2.Text,
                        Lozinka = textBox3.Text,
                        Email = textBox4.Text,
                        Administrator = (checkBox1.Checked) ? 1 : 0,
                        Tema = 2
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
            
            
            if (!IsPresentUser())
            {
                TranslateAndThemeUtil.CheckLanguage(label4, "Odabrano korisnicko ime za brisanje ne postoji!", "This username does not exist!");
                return;
            }
            if (BookStoreDatabaseManipulation.DeleteUser(textBox2.Text))
            {
                TranslateAndThemeUtil.CheckLanguage(label4, "Korisnik uspjesno obrisan!", "User successfully deleted!");
                UpdateGrid();
            }
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = guna2DataGridView1.CurrentRow.Index;

            textBox1.Text = guna2DataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            textBox4.Text = guna2DataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            textBox2.Text = guna2DataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            textBox3.Text = guna2DataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            textBox5.Text = guna2DataGridView1.Rows[rowindex].Cells[5].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            Korisnik k = new Korisnik()
            {
                IdKorisnik= Int32.Parse(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()),
                Ime = textBox1.Text,
                Prezime = textBox4.Text,
                KorisnickoIme = textBox2.Text,
                Lozinka = textBox3.Text,
                Email = textBox5.Text,
                Administrator = (checkBox1.Checked) ? 1 : 0
            };
            BookStoreDatabaseManipulation.UpdateUser(k);
            
            TranslateAndThemeUtil.CheckLanguage(label4, "Korisnik uspjesno ažuriran!", "User successfully updated!");
            UpdateGrid();
           
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ProductsForm f=new ProductsForm();
            FormsUtil.OpenForm(this, f);
        }
    }
}
