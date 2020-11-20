using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace NewMyPerpus.Nav

{

    public partial class Buku : UserControl

    {
        OleDbConnection connection = new OleDbConnection();
        public Buku()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\My Documents\BukuDatabase.accdb;Persist Security Info=False;
";
        }

        private void Buku_Load(object sender, EventArgs e)
        {

        }
        void clearText()
        {
            textbox_No.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }
        void fillgrid()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from TableBuku";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();
            }
            label2.Text = dataGridView1.Rows.Count.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection delConn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\My Documents\BukuDatabase.accdb; Persist Security Info = False");
                delConn.Open();
                String delQuery = "DELETE FROM TableBuku WHERE [No]= @No";
                OleDbCommand delcmd = new OleDbCommand();
                delcmd.CommandText = delQuery;
                delcmd.Connection = delConn;
                delcmd.Parameters.AddWithValue("@No", textbox_No.Text);
                delcmd.ExecuteNonQuery();
                MessageBox.Show("Buku has been successfully removed!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            fillgrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection delConn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\My Documents\BukuDatabase.accdb; Persist Security Info = False");
                delConn.Open();
                String delQuery = "INSERT INTO TableBuku ([Kode],[ISBN],[Judul],[Stok],[Penerbit]) VALUES (?,?,?,?,?)";
                OleDbCommand delcmd = new OleDbCommand();
                delcmd.CommandText = delQuery;
                delcmd.Connection = delConn;
                delcmd.Parameters.AddWithValue("@Kode", textBox1.Text);
                delcmd.Parameters.AddWithValue("@ISBN", textBox2.Text);
                delcmd.Parameters.AddWithValue("@Judul", textBox3.Text);
                delcmd.Parameters.AddWithValue("@Stok", textBox4.Text);
                delcmd.Parameters.AddWithValue("@Penerbit", textBox5.Text);
                delcmd.ExecuteNonQuery();
                MessageBox.Show("Buku has been successfully Inserted!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            clearText();
            fillgrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection delConn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\My Documents\BukuDatabase.accdb; Persist Security Info = False");
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE TableBuku SET Kode = @kode, ISBN = @isbn, Judul = @judul, Stok = @stok, Penerbit = @penerbit WHERE [No] = @no";
                cmd.Parameters.AddWithValue("@kode", textBox1.Text);
                cmd.Parameters.AddWithValue("@isbn", textBox2.Text);
                cmd.Parameters.AddWithValue("@judul", textBox3.Text);
                cmd.Parameters.AddWithValue("@stok", textBox4.Text);
                cmd.Parameters.AddWithValue("@penerbit", textBox5.Text);
                cmd.Parameters.AddWithValue("@no", int.Parse(textbox_No.Text));
                cmd.Connection = delConn;
                delConn.Open();
                cmd.ExecuteNonQuery();
                {
                    MessageBox.Show("Update Success!");
                    delConn.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            fillgrid();
            clearText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillgrid();
        }
    }
}
