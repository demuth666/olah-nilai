using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olah_nilaiV2.User_Control
{
    public partial class dbguru : UserControl
    {
        bantu bantu = new bantu();
        public dbguru()
        {
            InitializeComponent();
        }

        public void dbguru_Load(object sender, EventArgs e)
        {
            timer1.Start();
            date.Text = DateTime.Now.ToLongDateString();

            DataTable tot = bantu.satudata("SELECT count(*) FROM siswa ");
            jumlah.Text = tot.Rows[0][0].ToString();
            DataTable totguru = bantu.satudata("SELECT count(*) FROM guru ");
            guru.Text = totguru.Rows[0][0].ToString();
            DataSet dataBarang = bantu.data("SELECT nisn, nama, kelas, SUM(nilai_akhir) AS Jumlah_nilai FROM nilai GROUP BY nisn,nama,kelas ORDER BY SUM(nilai_akhir) DESC;");
            rank.DataSource = dataBarang.Tables[0];
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            jam.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jam_Click(object sender, EventArgs e)
        {

        }

        private void nama_Click(object sender, EventArgs e)
        {

        }
    }
}
