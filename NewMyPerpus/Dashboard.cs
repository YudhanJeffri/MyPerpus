using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMyPerpus
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            panel2.Height = button1.Height;
            panel2.Top = button1.Top;
            home1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Height = button1.Height;
            panel2.Top = button1.Top;
            home1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Height = button2.Height;
            panel2.Top = button2.Top;
            anggota1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Height = button3.Height;
            panel2.Top = button3.Top;
            buku1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Height = button4.Height;
            panel2.Top = button4.Top;
            transaksi1.BringToFront();
        }
    }
}
