using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NewMyPerpus.Nav
{
    public partial class Home : UserControl
    {
        OleDbConnection connection = new OleDbConnection();
        public Home()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\My Documents\DatabaseAnggota.accdb;Persist Security Info=False;
";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            fillgrid();
        }
        void fillgrid()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from TableAnggota";
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

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection delConn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\My Documents\DatabaseAnggota.accdb; Persist Security Info = False");
  delConn.Open();
                String delQuery = "DELETE FROM TableAnggota WHERE [No]= @No";
                OleDbCommand delcmd = new OleDbCommand();
                delcmd.CommandText = delQuery;
                delcmd.Connection = delConn;
                delcmd.Parameters.AddWithValue("@No", textbox_No.Text);
                delcmd.ExecuteNonQuery();
                MessageBox.Show("Anggota has been successfully removed!");
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
                OleDbConnection delConn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\My Documents\DatabaseAnggota.accdb; Persist Security Info = False");
                delConn.Open();
                String delQuery = "INSERT INTO TableAnggota ([Nama],[NIS],[Kelas],[Alamat],[Email]) VALUES (?,?,?,?,?)";
                OleDbCommand delcmd = new OleDbCommand();
                delcmd.CommandText = delQuery;
                delcmd.Connection = delConn;
                delcmd.Parameters.AddWithValue("@Nama", textBox1.Text);
                delcmd.Parameters.AddWithValue("@NIS", textBox2.Text);
                delcmd.Parameters.AddWithValue("@Kelas", textBox3.Text);
                delcmd.Parameters.AddWithValue("@Alamat", textBox4.Text);
                delcmd.Parameters.AddWithValue("@Email", textBox5.Text);
                delcmd.ExecuteNonQuery();
                MessageBox.Show("Anggota has been successfully Inserted!");
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
                OleDbConnection delConn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\My Documents\DatabaseAnggota.accdb; Persist Security Info = False");
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE TableAnggota SET Nama = @nama, NIS = @nis, Kelas = @kelas, Alamat = @alamat, Email = @email WHERE [No] = @no";
                cmd.Parameters.AddWithValue("@nama", textBox1.Text);
                cmd.Parameters.AddWithValue("@nis", textBox2.Text);
                cmd.Parameters.AddWithValue("@kelas", textBox3.Text);
                cmd.Parameters.AddWithValue("@alamat", textBox4.Text);
                cmd.Parameters.AddWithValue("@email", textBox5.Text);
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
        void clearText()
        {
            textbox_No.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }
    }
}
