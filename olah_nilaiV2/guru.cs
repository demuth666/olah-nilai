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
    public partial class guru : Form
    {
        public guru()
        {
            InitializeComponent();
        }

        private void nilai1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Form1 fa = new Form1();
            fa.Show();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            nilai1.BringToFront();
            nilai1_Load(this, null);
        }

        private void dbguru1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            inirapot1.BringToFront();
        }
    }
}
