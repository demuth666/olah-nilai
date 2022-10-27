using olah_nilaiV2.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace olah_nilaiV2
{
    public partial class Form1 : Form
    {
        bantu bantu = new bantu();
        public static string id;
        public static string nama;
        public static string hak;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
               
                DataTable dt = bantu.masuk(username.Text, password.Text);
                if (dt.Rows.Count == 1)
                {
                    id = dt.Rows[0][0].ToString();
                    nama = dt.Rows[0][1].ToString();
                    hak = dt.Rows[0][2].ToString();

                    if (hak == "admin")
                    {
                        admin fa = new admin();
                        this.Hide();
                        fa.Show();
                        bantu.logact("login");
                    }else if (hak == "guru")
                    {
                        guru fa = new guru();
                        this.Hide();
                        fa.Show();
                        bantu.logact("login");
                    }
                    else if (hak == "siswa")
                    {
                        inisiswa fa = new inisiswa();
                        this.Hide();
                        //fa.Show();
                        bantu.logact("login");
                        fa.stdName = username.Text;
                        fa.ShowDialog();
                    }
                    else { }
                    

                }
                else
                {
                    text.Visible = true;
                    password.Clear();
                }

            }
            else
            {
               
            }

           
        }


        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            text.Visible = false;
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
