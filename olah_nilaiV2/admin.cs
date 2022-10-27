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
    public partial class admin : Form
    {
        bantu bantu = new bantu();
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            logacti1.BringToFront();
            logacti1.logacti_Load(this, null);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
           
        }

     

        private void iconButton1_Click(object sender, EventArgs e)
        {
            guru1.BringToFront();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            siswa1.BringToFront();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            user1.BringToFront();
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fa = new Form1();
            fa.Show();
            bantu.logact("Log Out");
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            aboutus fa = new aboutus();
            fa.Show();
        }
    }
}
