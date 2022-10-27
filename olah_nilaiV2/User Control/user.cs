using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olah_nilaiV2.User_Control
{
    public partial class user : UserControl
    {
        bantu bantu = new bantu();
        public int id;
        public user()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void user_Load(object sender, EventArgs e)
        {
            DataSet dataBarang = bantu.data("select * from users");
            datagriduser.DataSource = dataBarang.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if(hak.Text == "admin")
            {
                username.Enabled = false;
                pass.Enabled = false;
            }
            else
            {
                username.Enabled = true;
                pass.Enabled = true;
            }*/
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && pass.Text != "" && hak.Text != "")
            {
                if (MessageBox.Show("Simpan Data Siswa?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bantu.SetData("insert into users values('" + username.Text + "', '" + pass.Text + "', '" + hak.Text + "')", "User Berhasil Tersimpan.");
                    user_Load(this, null);
                    hapus();
                    bantu.logact("Menambahkan User");
                }
            }
            else
            {
                bantu.isi();
            }
        }

        private void hapus()
        {
            username.Clear();
            pass.Clear();
            hak.Text = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_MouseMove(object sender, MouseEventArgs e)
        {
                 
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (username.Text != "" && pass.Text != "" && hak.Text != "") 
            {
                if (MessageBox.Show("Simpan perubahan ?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bantu.SetData("update users set username='" + username.Text + "', pass='" + pass.Text + "', hak='" + hak.Text + "' where id='" + id + "'", "Berhasil mengedit data User.");
                    user_Load(this, null);
                    hapus();
                    bantu.logact("Mengedit User");
                }
            }
            else
            {
                MessageBox.Show("Pilih data untuk diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && pass.Text != "" && hak.Text != "")
            {
                if (MessageBox.Show("Hapus data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bantu.SetData("delete from users where id='" + id + "'", "Berhasil menghapus data pengguna.");
                    user_Load(this, null);
                    hapus();
                    bantu.logact("Menghapus User");
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

        private void datagriduser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(datagriduser.Rows[e.RowIndex].Cells[0].Value.ToString());
                username.Text = datagriduser.Rows[e.RowIndex].Cells[1].Value.ToString();
                pass.Text = datagriduser.Rows[e.RowIndex].Cells[2].Value.ToString();
                hak.Text = datagriduser.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet dataLog = bantu.data("select username, pass, hak from users where (username like '%" + cariuser.Text + "%' or hak like '%" + cariuser.Text + "%')");
            datagriduser.DataSource = dataLog.Tables[0];

        }
    }
}
