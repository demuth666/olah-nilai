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
    public partial class datasiswa : Form
    {
        bantu bantu = new bantu();
        public datasiswa()
        {
            InitializeComponent();
        }

        private void datagridsiswa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nilai.nilaiInstance.tba.Text = this.datagridsiswa.CurrentRow.Cells[0].Value.ToString();
            nilai.nilaiInstance.tbb.Text = this.datagridsiswa.CurrentRow.Cells[1].Value.ToString();
            nilai.nilaiInstance.tbc.Text = this.datagridsiswa.CurrentRow.Cells[6].Value.ToString();
            this.Hide();
        }

        private void datasiswa_Load(object sender, EventArgs e)
        {
            DataSet dataBarang = bantu.data("select * from siswa");
            datagridsiswa.DataSource = dataBarang.Tables[0];
            datagridsiswa.Visible = false;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(cari.Text != "")
            {
                DataSet dataLog = bantu.data("select nisn, nama, alamat, kelamin, lahir, kelas, jurusan from siswa where (nisn like '%" + cari.Text + "%' or nama like '%" + cari.Text + "%'  or alamat like '%" + cari.Text + "%'  or kelamin like '%" + cari.Text + "%'  or lahir like '%" + cari.Text + "%'  or kelas like '%" + cari.Text + "%'  or jurusan like '%" + cari.Text + "%')");
                datagridsiswa.DataSource = dataLog.Tables[0];
                datagridsiswa.Visible = true;
            } else
            {
                datagridsiswa.Visible = false;
            }
          
        }

        private void guna2ComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbcari.Text != "")
            {
                DataSet dataLog = bantu.data("select nisn, nama, alamat, kelamin, lahir, kelas, jurusan from siswa where (nisn like '%" + cbcari.Text + "%' or nama like '%" + cbcari.Text + "%'  or alamat like '%" + cbcari.Text + "%'  or kelamin like '%" + cbcari.Text + "%'  or lahir like '%" + cbcari.Text + "%'  or kelas like '%" + cbcari.Text + "%'  or jurusan like '%" + cbcari.Text + "%')");
                datagridsiswa.DataSource = dataLog.Tables[0];
                datagridsiswa.Visible = true;
            }
            else
            {
                datagridsiswa.Visible = false;
            }
        }

        private void cbcari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcari.Text != "")
            {
                DataSet dataLog = bantu.data("select nisn, nama, alamat, kelamin, lahir, kelas, jurusan from siswa where (nisn like '%" + cbcari.Text + "%' or nama like '%" + cbcari.Text + "%'  or alamat like '%" + cbcari.Text + "%'  or kelamin like '%" + cbcari.Text + "%'  or lahir like '%" + cbcari.Text + "%'  or kelas like '%" + cbcari.Text + "%'  or jurusan like '%" + cbcari.Text + "%')");
                datagridsiswa.DataSource = dataLog.Tables[0];
                datagridsiswa.Visible = true;
            }
            else
            {
                datagridsiswa.Visible = false;
            }
        }
    }
}
