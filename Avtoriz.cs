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

namespace Курсач
{
    public partial class Avtoriz : Form
    {
        public Avtoriz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Groupp.mdf;Integrated Security = True; Connect Timeout = 1000;");
            conn1.Open();
            SqlCommand zapros = new SqlCommand(@"SELECT log,pas FROM logpas where log='" + textBox1.Text + "' and pas='" + textBox2.Text + "' ;", conn1);
            Form1 f1 = new Form1();
            if (zapros.ExecuteNonQuery() != 0)
            {
                if (textBox1.Text == "admin")
                {
                    f1.администраторToolStripMenuItem.Enabled = true;
                    f1.сменаПароляToolStripMenuItem.Enabled = true;
                }

                f1.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void Avtoriz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Avtoriz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
