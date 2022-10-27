using olah_nilaiV2;
using olah_nilaiV2.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olah_nilaiV2
{
    public partial class inisiswa : Form
    {
        public static inisiswa inisiswaInstance;
        public TextBox tbnama;
        public string stdName { get; set; }
        bantu bantu = new bantu();
        public inisiswa()
        {
            InitializeComponent();
            inisiswaInstance = this;
            tbnama = cari;
        }

        public void inisiswa_Load(object sender, EventArgs e)
        {
            DataTable name = bantu.satudata("select nama  from siswa, users where siswa.id = users.id");
            cari.Text = name.Rows[0][0].ToString();
            DataSet databarang = bantu.data("select * from nilai");
            datagridnilai.DataSource = databarang.Tables[0];
            cari.Enabled = false;
            datagridnilai.Visible = false;
            cari.Text = stdName;
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();
            fa.Show();
        }

        private void guna2Button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btcari_Click(object sender, EventArgs e)
        {
            if (cari.Text != "")
            {
                DataSet dataLog = bantu.data("select nisn, nama, kelas, mapel, uas, uts, ulangan_harian, nilai_akhir, nilai_mutu from nilai where (nama like '%" + cari.Text + "%')");
                datagridnilai.DataSource = dataLog.Tables[0];
                datagridnilai.Visible = true;
            }
            else
            {
                datagridnilai.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dbsiswa1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datagridnilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
