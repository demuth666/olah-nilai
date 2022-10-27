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
    public partial class siswa : UserControl
    {
        bantu bantu = new bantu();
        public int id;
        public siswa()
        {
            InitializeComponent();
        }

        private void hapus()
        {
            nisn.Clear();
            nama.Clear();
            alamat.Clear();
            kelamin.Text = "";
            lahir.Clear();
            kelas.Text = "";
            jurusan.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void siswa_Load(object sender, EventArgs e)
        {
            DataSet dataBarang = bantu.data("select * from siswa");
            datagridsiswa.DataSource = dataBarang.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (nisn.Text != "" && nama.Text != "" && alamat.Text != "" && kelamin.Text != "" && lahir.Text != "" && tanggal.Text != "" && kelas.Text != "" && jurusan.Text != "")
            {
                if (MessageBox.Show("Simpan Data Siswa?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bantu.SetData("insert into siswa values('" + nisn.Text + "', '" + nama.Text + "', '" + alamat.Text + "', '" + kelamin.Text + "', '" + lahir.Text + "', '" + tanggal.Value + "', '" + kelas.Text + "', '" + jurusan.Text + "')", "Siswa Berhasil Tersimpan.");
                    siswa_Load(this, null);
                    hapus();
                    bantu.logact("Menambahkan Siswa");
                }
            }
            else
            {
                bantu.isi();
            }
        }

        private void datagridsiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(datagridsiswa.Rows[e.RowIndex].Cells[0].Value.ToString());
                nisn.Text = datagridsiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
                nama.Text = datagridsiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
                alamat.Text = datagridsiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
                kelamin.Text = datagridsiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
                lahir.Text = datagridsiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
                tanggal.Text = datagridsiswa.Rows[e.RowIndex].Cells[6].Value.ToString();
                kelas.Text = datagridsiswa.Rows[e.RowIndex].Cells[7].Value.ToString();
                jurusan.Text = datagridsiswa.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            hapus();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (nisn.Text != "" && nama.Text != "" && alamat.Text != "" && kelamin.Text != "" && lahir.Text != "" && tanggal.Text != "" && kelas.Text != "" && jurusan.Text != "")
            {
                if (MessageBox.Show("Simpan Data Siswa?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bantu.SetData("update siswa set nisn = '" + nisn.Text + "', nama = '" + nama.Text + "', alamat = '" + alamat.Text + "', kelamin = '" + kelamin.Text + "', lahir = '" + lahir.Text + "', tgl = '" + tanggal.Value + "', kelas = '" + kelas.Text + "', jurusan = '" + jurusan.Text + "'  where id = '" + id + "'", "Berhasil Mengedit Data Siswa.");
                    siswa_Load(this, null);
                    hapus();
                    bantu.logact("Mengedit Data Siswa");
                }
            }
            else
            {
                bantu.isi();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (nisn.Text != "" && nama.Text != "" && alamat.Text != "" && kelamin.Text != "" && lahir.Text != "" && tanggal.Text != "" && kelas.Text != "" && jurusan.Text != "")
            {
                if (MessageBox.Show("Hapus Data Siswa?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bantu.SetData("delete from siswa where id='" + id + "'", "Berhasil menghapus data siswa.");
                    siswa_Load(this, null);
                    hapus();
                    bantu.logact("Menghapus Data Siswa");
                }
            }
            else
            {
                MessageBox.Show("Pilih data untuk dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datagridsiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void jurusan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void kelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lahir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void alamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nisn_TextChanged(object sender, EventArgs e)
        {

        }

        private void carisiswa_TextChanged(object sender, EventArgs e)
        {
            DataSet dataLog = bantu.data("select nisn, nama, alamat, kelamin, lahir, kelas, jurusan from siswa where (nama like '%" + carisiswa.Text + "%' or nisn like '%" + carisiswa.Text + "%' or alamat like '%" + carisiswa.Text + "%')");
            datagridsiswa.DataSource = dataLog.Tables[0];
        }
    }
}
