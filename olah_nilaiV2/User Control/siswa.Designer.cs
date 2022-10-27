namespace olah_nilaiV2.User_Control
{
    partial class siswa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datagridsiswa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.jurusan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kelas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kelamin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lahir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.alamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nama = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nisn = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carisiswa = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridsiswa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Siswa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.carisiswa);
            this.panel2.Controls.Add(this.tanggal);
            this.panel2.Controls.Add(this.datagridsiswa);
            this.panel2.Controls.Add(this.guna2Button4);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.jurusan);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.kelas);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.kelamin);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lahir);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.alamat);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nama);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nisn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 537);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tanggal
            // 
            this.tanggal.BorderRadius = 5;
            this.tanggal.Checked = true;
            this.tanggal.FillColor = System.Drawing.Color.Silver;
            this.tanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tanggal.HoverState.FillColor = System.Drawing.Color.White;
            this.tanggal.Location = new System.Drawing.Point(305, 129);
            this.tanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(240, 36);
            this.tanggal.TabIndex = 48;
            this.tanggal.Value = new System.DateTime(2022, 10, 1, 19, 0, 50, 690);
            this.tanggal.ValueChanged += new System.EventHandler(this.tanggal_ValueChanged);
            // 
            // datagridsiswa
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.datagridsiswa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridsiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridsiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridsiswa.ColumnHeadersHeight = 15;
            this.datagridsiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridsiswa.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagridsiswa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridsiswa.Location = new System.Drawing.Point(551, 52);
            this.datagridsiswa.Name = "datagridsiswa";
            this.datagridsiswa.RowHeadersVisible = false;
            this.datagridsiswa.Size = new System.Drawing.Size(312, 470);
            this.datagridsiswa.TabIndex = 47;
            this.datagridsiswa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridsiswa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridsiswa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridsiswa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridsiswa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridsiswa.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridsiswa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridsiswa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridsiswa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridsiswa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridsiswa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridsiswa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridsiswa.ThemeStyle.HeaderStyle.Height = 15;
            this.datagridsiswa.ThemeStyle.ReadOnly = false;
            this.datagridsiswa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridsiswa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridsiswa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridsiswa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridsiswa.ThemeStyle.RowsStyle.Height = 22;
            this.datagridsiswa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridsiswa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridsiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridsiswa_CellClick);
            this.datagridsiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridsiswa_CellContentClick);
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
            this.guna2Button4.Location = new System.Drawing.Point(318, 408);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(92, 34);
            this.guna2Button4.TabIndex = 46;
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
            this.guna2Button3.Location = new System.Drawing.Point(220, 408);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(92, 34);
            this.guna2Button3.TabIndex = 45;
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
            this.guna2Button2.Location = new System.Drawing.Point(122, 408);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(92, 34);
            this.guna2Button2.TabIndex = 44;
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
            this.guna2Button1.Location = new System.Drawing.Point(22, 408);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(92, 34);
            this.guna2Button1.TabIndex = 43;
            this.guna2Button1.Text = "Simpan";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Jurusan";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // jurusan
            // 
            this.jurusan.BackColor = System.Drawing.Color.Transparent;
            this.jurusan.BorderRadius = 5;
            this.jurusan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.jurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jurusan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.jurusan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.jurusan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.jurusan.ForeColor = System.Drawing.Color.Black;
            this.jurusan.ItemHeight = 30;
            this.jurusan.Items.AddRange(new object[] {
            "RPL",
            "TKJ",
            "Karawitan",
            "DPIB",
            "Mesin",
            "Listrik"});
            this.jurusan.Location = new System.Drawing.Point(305, 289);
            this.jurusan.Name = "jurusan";
            this.jurusan.Size = new System.Drawing.Size(240, 36);
            this.jurusan.TabIndex = 41;
            this.jurusan.SelectedIndexChanged += new System.EventHandler(this.jurusan_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Kelas";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // kelas
            // 
            this.kelas.BackColor = System.Drawing.Color.Transparent;
            this.kelas.BorderRadius = 5;
            this.kelas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kelas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kelas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kelas.ForeColor = System.Drawing.Color.Black;
            this.kelas.ItemHeight = 30;
            this.kelas.Items.AddRange(new object[] {
            "X",
            "XI",
            "XII"});
            this.kelas.Location = new System.Drawing.Point(305, 209);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(240, 36);
            this.kelas.TabIndex = 39;
            this.kelas.SelectedIndexChanged += new System.EventHandler(this.kelas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tanggal";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Jenis Kelamin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.kelamin.Location = new System.Drawing.Point(22, 289);
            this.kelamin.Name = "kelamin";
            this.kelamin.Size = new System.Drawing.Size(240, 36);
            this.kelamin.TabIndex = 35;
            this.kelamin.SelectedIndexChanged += new System.EventHandler(this.kelamin_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Lahir";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.lahir.Location = new System.Drawing.Point(305, 52);
            this.lahir.Name = "lahir";
            this.lahir.PasswordChar = '\0';
            this.lahir.PlaceholderText = "";
            this.lahir.SelectedText = "";
            this.lahir.Size = new System.Drawing.Size(240, 36);
            this.lahir.TabIndex = 33;
            this.lahir.TextChanged += new System.EventHandler(this.lahir_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Alamat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.alamat.Location = new System.Drawing.Point(22, 209);
            this.alamat.Name = "alamat";
            this.alamat.PasswordChar = '\0';
            this.alamat.PlaceholderText = "";
            this.alamat.SelectedText = "";
            this.alamat.Size = new System.Drawing.Size(240, 36);
            this.alamat.TabIndex = 31;
            this.alamat.TextChanged += new System.EventHandler(this.alamat_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.nama.Location = new System.Drawing.Point(22, 129);
            this.nama.Name = "nama";
            this.nama.PasswordChar = '\0';
            this.nama.PlaceholderText = "";
            this.nama.SelectedText = "";
            this.nama.Size = new System.Drawing.Size(240, 36);
            this.nama.TabIndex = 29;
            this.nama.TextChanged += new System.EventHandler(this.nama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "NISN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nisn
            // 
            this.nisn.BorderRadius = 5;
            this.nisn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nisn.DefaultText = "";
            this.nisn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nisn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nisn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nisn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nisn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nisn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nisn.ForeColor = System.Drawing.Color.Black;
            this.nisn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nisn.Location = new System.Drawing.Point(22, 52);
            this.nisn.Name = "nisn";
            this.nisn.PasswordChar = '\0';
            this.nisn.PlaceholderText = "";
            this.nisn.SelectedText = "";
            this.nisn.Size = new System.Drawing.Size(240, 36);
            this.nisn.TabIndex = 27;
            this.nisn.TextChanged += new System.EventHandler(this.nisn_TextChanged);
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // carisiswa
            // 
            this.carisiswa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.carisiswa.BorderRadius = 8;
            this.carisiswa.BorderThickness = 2;
            this.carisiswa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carisiswa.DefaultText = "";
            this.carisiswa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carisiswa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carisiswa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carisiswa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carisiswa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carisiswa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.carisiswa.ForeColor = System.Drawing.Color.Black;
            this.carisiswa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carisiswa.Location = new System.Drawing.Point(551, 22);
            this.carisiswa.Name = "carisiswa";
            this.carisiswa.PasswordChar = '\0';
            this.carisiswa.PlaceholderText = "Cari";
            this.carisiswa.SelectedText = "";
            this.carisiswa.Size = new System.Drawing.Size(312, 20);
            this.carisiswa.TabIndex = 4;
            this.carisiswa.TextChanged += new System.EventHandler(this.carisiswa_TextChanged);
            // 
            // siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "siswa";
            this.Size = new System.Drawing.Size(867, 597);
            this.Load += new System.EventHandler(this.siswa_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridsiswa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox lahir;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox alamat;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox nama;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox nisn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox kelas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox kelamin;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView datagridsiswa;
        private Guna.UI2.WinForms.Guna2ComboBox jurusan;
        private Guna.UI2.WinForms.Guna2DateTimePicker tanggal;
        private Guna.UI2.WinForms.Guna2TextBox carisiswa;
    }
}
