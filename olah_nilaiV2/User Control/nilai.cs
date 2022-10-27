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
    public partial class nilai : UserControl
    {
        public static nilai nilaiInstance;
        public TextBox tba;
        public TextBox tbb;
        public TextBox tbc;
        public int id;
        public static string username;
        bantu bantu = new bantu();
        public nilai()
        {
            InitializeComponent();
            nilaiInstance = this;
            tba = nisn;
            tbb = nama;
            tbc = kelas;
        }

        private void hapus()
        {
            nisn.Clear();
            nama.Clear();
            kelas.Clear();
            uas.Clear();
            uts.Clear();
            harian.Clear();
            nilai_akhir.Clear();
            nilai_mutu.Clear();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            datasiswa fa = new datasiswa();
            fa.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void nilai_Load(object sender, EventArgs e)
        {
            DataSet dataBarang = bantu.data("select * from nilai");
            datagridsiswa.DataSource = dataBarang.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double uass, utss, ulangan_harian, nilai_akhirr, tot;
            string grade;

            uass = int.Parse(uas.Text);
            utss = int.Parse(uts.Text);
            ulangan_harian = int.Parse(harian.Text);
            tot = uass + utss + ulangan_harian;
            nilai_akhirr = tot / 3;
            nilai_akhir.Text = nilai_akhirr.ToString();

            if(nisn.Text != "" && nama.Text != "" && kelas.Text != "" && mapel.Text != "" && uas.Text != "" && uts.Text != "" && harian.Text != "")
            {
                if (nilai_akhirr >= 90)
                {
                    grade = "A";
                }
                else if (nilai_akhirr >= 80)
                {
                    grade = "B";
                }
                else if (nilai_akhirr >= 70)
                {
                    grade = "C";
                }
                else
                {
                    grade = "D";
                }

                nilai_mutu.Text = grade;
            } else
            {
                bantu.isi();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (nisn.Text != "" && nama.Text != "" && kelas.Text != "" && mapel.Text != "" && uas.Text != "" && uts.Text != "" && harian.Text != "")
            {
                if (MessageBox.Show("Simpan Nilai?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bantu.SetData("insert into nilai values('" + nisn.Text + "', '" + nama.Text + "', '" + kelas.Text + "', '" + mapel.Text + "', '" + Form1.nama + "',  '" + uas.Text + "', '" + uts.Text + "', '" + harian.Text + "', '" + nilai_akhir.Text + "', '" + nilai_mutu.Text + "')", "Nilai Berhasil Tersimpan.");
                    nilai_Load(this, null);
                    hapus();
                    bantu.logact("Menambahkan Nilai");
                }
            }
            else
            {
                bantu.isi();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (nisn.Text != "" && nama.Text != "" && kelas.Text != "" && mapel.Text != "" && uas.Text != "" && uts.Text != "" && harian.Text != "")
            {
                if (MessageBox.Show("Update Nilai?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bantu.SetData("update nilai set nisn = '" + nisn.Text + "', nama = '" + nama.Text + "', kelas = '" + kelas.Text + "', mapel = '" + mapel.Text + "', uas = '" + uas.Text + "', uts = '" + uts.Text + "', ulangan_harian = '" + harian.Text + "', nilai_akhir = '" + nilai_akhir.Text + "', nilai_mutu = '" + nilai_mutu.Text + "'  where id = '" + id + "'", "Berhasil Mengedit Nilai.");
                    nilai_Load(this, null);
                    hapus();
                    bantu.logact("Mengedit Nilai");
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
                kelas.Text = datagridsiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
                mapel.Text = datagridsiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
                uas.Text = datagridsiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
                uts.Text = datagridsiswa.Rows[e.RowIndex].Cells[6].Value.ToString();
                harian.Text = datagridsiswa.Rows[e.RowIndex].Cells[7].Value.ToString();
                nilai_akhir.Text = datagridsiswa.Rows[e.RowIndex].Cells[8].Value.ToString();
                nilai_mutu.Text = datagridsiswa.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (nisn.Text != "" && nama.Text != "" && kelas.Text != "" && mapel.Text != "" && uas.Text != "" && uts.Text != "" && harian.Text != "")
            {
                if (MessageBox.Show("Hapus Nilai?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bantu.SetData("delete from nilai where id='" + id + "'", "Berhasil menghapus nilai.");
                    nilai_Load(this, null);
                    hapus();
                    bantu.logact("Menghapus Nilai");
                }
            }
            else
            {
                MessageBox.Show("Pilih data untuk dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            hapus();
        }
    }
}
