using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace olah_nilaiV2.User_Control
{
    public partial class guru : UserControl
    {
        bantu bantu = new bantu();
        public int id;
        public guru()
        {
            InitializeComponent();
        }

        private void hapus()
        {
            nip.Clear();
            nama.Clear();
            alamat.Clear();
            lahir.Clear();
            kelamin.Text = "";
            jabatan.Text = "";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            hapus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void guru_Load(object sender, EventArgs e)
        {
            DataSet dataBarang = bantu.data("select * from guru");
            datagridguru.DataSource = dataBarang.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (nip.Text != "" && nama.Text != "" && alamat.Text != ""  && lahir.Text != "" && tanggal.Text != "" && kelamin.Text != "" && jabatan.Text != "")
            {
                if (MessageBox.Show("Simpan Data Guru?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bantu.SetData("insert into guru values('" + nip.Text + "', '" + nama.Text + "', '" + alamat.Text + "', '" + lahir.Text + "', '" + tanggal.Value + "', '" + kelamin.Text + "', '" + jabatan.Text + "')", "Guru Berhasil Tersimpan.");
                    guru_Load(this, null);
                    hapus();
                    bantu.logact("Menambahkan Guru");
                }
            }
            else
            {
                bantu.isi();
            }
        }

        private void datagridguru_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(datagridguru.Rows[e.RowIndex].Cells[0].Value.ToString());
                nip.Text = datagridguru.Rows[e.RowIndex].Cells[1].Value.ToString();
                nama.Text = datagridguru.Rows[e.RowIndex].Cells[2].Value.ToString();
                alamat.Text = datagridguru.Rows[e.RowIndex].Cells[3].Value.ToString();
                lahir.Text = datagridguru.Rows[e.RowIndex].Cells[4].Value.ToString();
                tanggal.Text = datagridguru.Rows[e.RowIndex].Cells[5].Value.ToString();
                kelamin.Text = datagridguru.Rows[e.RowIndex].Cells[6].Value.ToString();
                jabatan.Text = datagridguru.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (nip.Text != "" && nama.Text != "" && alamat.Text != "" && lahir.Text != "" && tanggal.Text != "" && kelamin.Text != "" && jabatan.Text != "")
            {
                if (MessageBox.Show("Edit Data Guru?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bantu.SetData("update guru set  nip= '" + nip.Text + "', nama= '" + nama.Text + "', alamat= '" + alamat.Text + "', lahir= '" + lahir.Text + "', tgl= '" + tanggal.Value + "', kelamin= '" + kelamin.Text + "', jabatan= '" + jabatan.Text + "'  where id = '" + id + "'", "Berhasil Mengedit Data Guru.");
                    guru_Load(this, null);
                    hapus();
                    bantu.logact("Mengedit Data Guru");
                }
            }
            else
            {
                MessageBox.Show("Pilih data untuk diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (nip.Text != "" && nama.Text != "" && alamat.Text != "" && lahir.Text != "" && tanggal.Text != "" && kelamin.Text != "" && jabatan.Text != "")
            {
                if (MessageBox.Show("Hapus Data Guru?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bantu.SetData("delete from guru where id='" + id + "'", "Berhasil menghapus data guru.");
                    guru_Load(this, null);
                    hapus();
                    bantu.logact("Menghapus Data Guru");
                }
            }
            else
            {
                MessageBox.Show("Pilih data untuk dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cariuser_TextChanged(object sender, EventArgs e)
        {
            DataSet dataLog = bantu.data("select nip, nama, alamat, lahir, kelamin, jabatan  from guru where (nip like '%" + search.Text + "%' or nama like '%" + search.Text + "%'  or alamat like '%" + search.Text + "%'  or lahir like '%" + search.Text + "%'  or kelamin like '%" + search.Text + "%'  or jabatan like '%" + search.Text + "%')");
            datagridguru.DataSource = dataLog.Tables[0];
        }
    }
}
