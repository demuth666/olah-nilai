namespace olah_nilaiV2.User_Control
{
    partial class guru
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.tanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datagridguru = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.jabatan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lahir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.alamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kelamin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nama = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nip = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridguru)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.tanggal);
            this.panel2.Controls.Add(this.datagridguru);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.jabatan);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lahir);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.alamat);
            this.panel2.Controls.Add(this.guna2Button4);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.kelamin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nama);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 537);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // search
            // 
            this.search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.search.BorderRadius = 8;
            this.search.BorderThickness = 2;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.Location = new System.Drawing.Point(552, 11);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderText = "Cari";
            this.search.SelectedText = "";
            this.search.Size = new System.Drawing.Size(312, 20);
            this.search.TabIndex = 33;
            this.search.TextChanged += new System.EventHandler(this.cariuser_TextChanged);
            // 
            // tanggal
            // 
            this.tanggal.BorderRadius = 5;
            this.tanggal.Checked = true;
            this.tanggal.FillColor = System.Drawing.Color.DarkGray;
            this.tanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tanggal.HoverState.FillColor = System.Drawing.Color.White;
            this.tanggal.Location = new System.Drawing.Point(300, 48);
            this.tanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(240, 36);
            this.tanggal.TabIndex = 32;
            this.tanggal.Value = new System.DateTime(2022, 9, 30, 18, 57, 33, 858);
            // 
            // datagridguru
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridguru.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridguru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridguru.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridguru.ColumnHeadersHeight = 15;
            this.datagridguru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridguru.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridguru.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridguru.Location = new System.Drawing.Point(548, 48);
            this.datagridguru.Name = "datagridguru";
            this.datagridguru.RowHeadersVisible = false;
            this.datagridguru.Size = new System.Drawing.Size(312, 460);
            this.datagridguru.TabIndex = 31;
            this.datagridguru.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridguru.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridguru.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridguru.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridguru.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridguru.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridguru.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridguru.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridguru.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridguru.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridguru.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridguru.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridguru.ThemeStyle.HeaderStyle.Height = 15;
            this.datagridguru.ThemeStyle.ReadOnly = false;
            this.datagridguru.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridguru.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridguru.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridguru.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridguru.ThemeStyle.RowsStyle.Height = 22;
            this.datagridguru.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridguru.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridguru.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridguru_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Jabatan";
            // 
            // jabatan
            // 
            this.jabatan.BackColor = System.Drawing.Color.Transparent;
            this.jabatan.BorderRadius = 5;
            this.jabatan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.jabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jabatan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.jabatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.jabatan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.jabatan.ForeColor = System.Drawing.Color.Black;
            this.jabatan.ItemHeight = 30;
            this.jabatan.Items.AddRange(new object[] {
            "Kepala Sekolah",
            "Guru Produktif",
            "Guru Umum",
            "Guru Honorer"});
            this.jabatan.Location = new System.Drawing.Point(302, 205);
            this.jabatan.Name = "jabatan";
            this.jabatan.Size = new System.Drawing.Size(240, 36);
            this.jabatan.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tanggal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Lahir";
            // 
            // lahir
            // 
            this.lahir.BorderRadius = 5;
            this.lahir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lahir.DefaultText = "";
            this.lahir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lahir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lahir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lahir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lahir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lahir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lahir.ForeColor = System.Drawing.Color.Black;
            this.lahir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lahir.Location = new System.Drawing.Point(20, 286);
            this.lahir.Name = "lahir";
            this.lahir.PasswordChar = '\0';
            this.lahir.PlaceholderText = "";
            this.lahir.SelectedText = "";
            this.lahir.Size = new System.Drawing.Size(240, 36);
            this.lahir.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Alamat";
            // 
            // alamat
            // 
            this.alamat.BorderRadius = 5;
            this.alamat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alamat.DefaultText = "";
            this.alamat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.alamat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.alamat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.alamat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.alamat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alamat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.alamat.ForeColor = System.Drawing.Color.Black;
            this.alamat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alamat.Location = new System.Drawing.Point(20, 205);
            this.alamat.Name = "alamat";
            this.alamat.PasswordChar = '\0';
            this.alamat.PlaceholderText = "";
            this.alamat.SelectedText = "";
            this.alamat.Size = new System.Drawing.Size(240, 36);
            this.alamat.TabIndex = 23;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Gray;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.Blue;
            this.guna2Button4.Location = new System.Drawing.Point(314, 445);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(92, 34);
            this.guna2Button4.TabIndex = 22;
            this.guna2Button4.Text = "Reset";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Gray;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button3.Location = new System.Drawing.Point(216, 445);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(92, 34);
            this.guna2Button3.TabIndex = 21;
            this.guna2Button3.Text = "Hapus";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.guna2Button2.Location = new System.Drawing.Point(118, 445);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(92, 34);
            this.guna2Button2.TabIndex = 20;
            this.guna2Button2.Text = "Edit";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Blue;
            this.guna2Button1.Location = new System.Drawing.Point(20, 445);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(92, 34);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "Simpan";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Jenis Kelamin";
            // 
            // kelamin
            // 
            this.kelamin.BackColor = System.Drawing.Color.Transparent;
            this.kelamin.BorderRadius = 5;
            this.kelamin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelamin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kelamin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kelamin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kelamin.ForeColor = System.Drawing.Color.Black;
            this.kelamin.ItemHeight = 30;
            this.kelamin.Items.AddRange(new object[] {
            "Laki-laki",
            "Wanita"});
            this.kelamin.Location = new System.Drawing.Point(300, 125);
            this.kelamin.Name = "kelamin";
            this.kelamin.Size = new System.Drawing.Size(240, 36);
            this.kelamin.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nama";
            // 
            // nama
            // 
            this.nama.BorderRadius = 5;
            this.nama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nama.DefaultText = "";
            this.nama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nama.ForeColor = System.Drawing.Color.Black;
            this.nama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nama.Location = new System.Drawing.Point(20, 125);
            this.nama.Name = "nama";
            this.nama.PasswordChar = '\0';
            this.nama.PlaceholderText = "";
            this.nama.SelectedText = "";
            this.nama.Size = new System.Drawing.Size(240, 36);
            this.nama.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "NIP";
            // 
            // nip
            // 
            this.nip.BorderRadius = 5;
            this.nip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nip.DefaultText = "";
            this.nip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nip.ForeColor = System.Drawing.Color.Black;
            this.nip.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nip.Location = new System.Drawing.Point(20, 48);
            this.nip.Name = "nip";
            this.nip.PasswordChar = '\0';
            this.nip.PlaceholderText = "";
            this.nip.SelectedText = "";
            this.nip.Size = new System.Drawing.Size(240, 36);
            this.nip.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Guru";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 60);
            this.panel1.TabIndex = 2;
            // 
            // guru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "guru";
            this.Size = new System.Drawing.Size(867, 597);
            this.Load += new System.EventHandler(this.guru_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridguru)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox jabatan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox lahir;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox alamat;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox kelamin;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox nama;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox nip;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2DataGridView datagridguru;
        private Guna.UI2.WinForms.Guna2DateTimePicker tanggal;
        private Guna.UI2.WinForms.Guna2TextBox search;
    }
}
