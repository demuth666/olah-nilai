using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olah_nilaiV2
{
    internal class bantu
    {
        public SqlConnection koneksi()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=CHANDRA;Initial Catalog=olah_nilai1;Integrated Security=True";

            return con;
        }

        public DataTable masuk(String username, String password)
        {
            SqlConnection connection = koneksi();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select id, username, hak from users where username='" + username + "' and pass='" + password + "'", connection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            return dt;
        }

        public DataSet data(String query)
        {
            SqlConnection connection = koneksi();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            sqlDataAdapter.Fill(data);

            return data;
        }

        public void SetData(String query, String message)
        {
            SqlConnection connection = koneksi();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("" + message + "", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        public void isi()
        {
            MessageBox.Show("Isi Semua Data Dengan Benar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void logact(String logact)
        {
            SqlConnection connection = koneksi();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into logact (id, act) values('" + Form1.id + "', '" + logact + "')";
            command.ExecuteNonQuery();
            connection.Close();
        }

     /*   public void nilai(String logact)
        {
            SqlConnection connection = koneksi();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into nilai (nisn, nama, kelas, mapel, guru, uas, uts, ulangan harian, nilai_akhir, nilai_mutu) values('" + Form1.id + "', '" + logact + "')";
            command.ExecuteNonQuery();
            connection.Close();
        }*/

        public DataTable satudata(String query)
        {
            SqlConnection connection = koneksi();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);

            return data;
        }
    }
}
