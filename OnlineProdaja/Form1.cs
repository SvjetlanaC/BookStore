using BookStore;
using SportShop;
using SportShop.DAO;
using System.Diagnostics;

namespace OnlineProdaja
{
    public partial class Form1 : Form
    {
        public static String username;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (label4.Text.Equals("SRB"))
                {
                    MessageBox.Show("Unesite korisničko ime i lozinku!");
                }
                else
                {
                    MessageBox.Show("Username and password are missing!");
                }

            }
            else
            {

                if (comboBox1.SelectedItem == "ADMIN")
                {
                    if (CheckAdministrator(textBox1.Text))
                    {
                        if (CheckPassword(textBox1.Text, textBox2.Text))
                        {
                            username = textBox1.Text;
                            SellerForm sf = new SellerForm();
                            this.Hide();
                            sf.ShowDialog();
                            this.Close();
                        }
                    }
                }
                else if (comboBox1.SelectedItem == "SELLER")
                {
                    if (CheckPassword(textBox1.Text, textBox2.Text))
                    {
                        username = textBox1.Text;
                        BillForm sf = new BillForm();
                        this.Hide();
                        sf.ShowDialog();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Select role!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        static List<Korisnik> users = BookStoreDatabaseManipulation.GetUsers();
        public bool CheckAdministrator(String name)
        {
            bool p = false;
            foreach(Korisnik k in users)
            {
                if (k.KorisnickoIme.Equals(name))
                {
                    if (k.Administrator == 1)
                    {
                        return true;
                    }
                    
                }
                
            }
            MessageBox.Show("Access denied! User is not administrator!");
            return false;
        }
        public bool CheckPassword(String username,String pass)
        {
            Trace.WriteLine("aaaaa" + users.ToArray());
            bool p = false;
            foreach (Korisnik k in users)
            {
                if (k.KorisnickoIme.Equals(username))
                {
                    if (k.Lozinka.Equals(pass))
                    {
                        return true;
                    }
                    else
                    {
                        p = true;
                        MessageBox.Show("Wrong password!");
                    }               
                }
            }
            if(!p)
                MessageBox.Show("Username not found!");
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            panel1.BackColor = Color.FromArgb(200, 245, 198, 128);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TranslateToSrb()
        {
            label2.Text = "Korisničko ime:";
            label1.Text = "Lozinka:";
            label3.Text = "PRIJAVI SE";
            button1.Text = "Potvrdi";
            comboBox1.Text = "Odaberi ulogu";
            
        }
        private void TranslateToEng()
        {
            label2.Text = "Username:";
            label1.Text = "Password:";
            label3.Text = "LOGIN";
            
            button1.Text = "Login";
            comboBox1.Text = "Select role";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}