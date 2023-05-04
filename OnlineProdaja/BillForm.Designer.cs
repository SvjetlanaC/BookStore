namespace BookStore
{
    partial class BillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonChangeTheme = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.guna2ShapesTool1 = new Guna.UI2.WinForms.Guna2ShapesTool(this.components);
            this.guna2ShapesTool2 = new Guna.UI2.WinForms.Guna2ShapesTool(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonChangeTheme);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 748);
            this.panel1.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(10, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 80);
            this.panel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("SimSun-ExtB", 26.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(68, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChangeTheme
            // 
            this.buttonChangeTheme.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonChangeTheme.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonChangeTheme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonChangeTheme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonChangeTheme.FillColor = System.Drawing.Color.DarkOrange;
            this.buttonChangeTheme.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChangeTheme.ForeColor = System.Drawing.Color.White;
            this.buttonChangeTheme.Location = new System.Drawing.Point(65, 560);
            this.buttonChangeTheme.Name = "buttonChangeTheme";
            this.buttonChangeTheme.Size = new System.Drawing.Size(213, 52);
            this.buttonChangeTheme.TabIndex = 4;
            this.buttonChangeTheme.Text = "Change theme";
            this.buttonChangeTheme.Click += new System.EventHandler(this.buttonChangeTheme_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogout.FillColor = System.Drawing.Color.DarkSlateGray;
            this.buttonLogout.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(65, 652);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(213, 59);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(380, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 47);
            this.label1.TabIndex = 49;
            this.label1.Text = "Create bill";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(982, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 46);
            this.panel2.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "ENG";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SRB",
            "ENG"});
            this.comboBox1.Location = new System.Drawing.Point(1047, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 35);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // guna2ShapesTool1
            // 
            this.guna2ShapesTool1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShapesTool1.PolygonSkip = 1;
            this.guna2ShapesTool1.Rotate = 0F;
            this.guna2ShapesTool1.Size = new System.Drawing.Size(200, 200);
            this.guna2ShapesTool1.TargetControl = null;
            // 
            // guna2ShapesTool2
            // 
            this.guna2ShapesTool2.Location = new System.Drawing.Point(0, 0);
            this.guna2ShapesTool2.PolygonSkip = 1;
            this.guna2ShapesTool2.Rotate = 0F;
            this.guna2ShapesTool2.Size = new System.Drawing.Size(200, 200);
            this.guna2ShapesTool2.TargetControl = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(349, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 54;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(451, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 27);
            this.textBox1.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(349, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 55;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(487, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 27);
            this.textBox2.TabIndex = 56;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(642, 107);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 29;
            this.guna2DataGridView1.Size = new System.Drawing.Size(479, 313);
            this.guna2DataGridView1.TabIndex = 57;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(349, 426);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(595, 284);
            this.richTextBox1.TabIndex = 58;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.DarkOrange;
            this.buttonAdd.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(366, 311);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 36);
            this.buttonAdd.TabIndex = 60;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.FillColor = System.Drawing.Color.DarkOrange;
            this.buttonDelete.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(487, 311);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(133, 36);
            this.buttonDelete.TabIndex = 61;
            this.buttonDelete.Text = "DELETE ALL";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2Button2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(982, 560);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(103, 36);
            this.guna2Button2.TabIndex = 62;
            this.guna2Button2.Text = "PRINT";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1127, 722);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1145, 769);
            this.MinimumSize = new System.Drawing.Size(1145, 769);
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button buttonChangeTheme;
        private Guna.UI2.WinForms.Guna2Button buttonLogout;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool1;
        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool2;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private RichTextBox richTextBox1;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Panel panel3;
        private Label label5;
    }
}