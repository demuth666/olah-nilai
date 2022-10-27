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
    public partial class logacti : UserControl
    {
        bantu bantu = new bantu();  
        public logacti()
        {
            InitializeComponent();
        }

        public void logacti_Load(object sender, EventArgs e)
        {
            string theDate = date.Value.ToString("yyyy-MM-dd");
            DataSet dataLog = bantu.data("select username, act, tanggal from logact, users where logact.id = users.id and (tanggal='" + theDate + "')");
            datagridact.DataSource = dataLog.Tables[0];
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            string theDate = date.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(theDate);
            DataSet dataLog = bantu.data("select username, act, tanggal from logact, users where logact.id = users.id and tanggal='" + theDate + "'");
            datagridact.DataSource = dataLog.Tables[0];
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet dataLog = bantu.data("select username, act, tanggal from logact, users where logact.id = users.id and (username like '%" + search.Text + "%' or act like '%" + search.Text + "%')");
            datagridact.DataSource = dataLog.Tables[0];
        }

        private void datagridact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridact_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
