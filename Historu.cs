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
    public partial class Historu : Form
    {
        public Historu()
        {
            InitializeComponent();
        }

        private void Historu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grouppDataSet.Jurnal". При необходимости она может быть перемещена или удалена.
            this.jurnalTableAdapter.Fill(this.grouppDataSet.Jurnal);
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView dgv = dataGridView1;
                string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Groupp.mdf;Integrated Security = True; Connect Timeout = 10000;";
                string sqlQuery = "SELECT nomer,name,data FROM jurnal Where data >='" + monthCalendar1.SelectionStart.Date.ToString("MM/dd/yyyy") + "' AND data <='" + monthCalendar1.SelectionEnd.Date.ToString("MM/dd/yyyy") + "' ";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, connection);
                DataSet ds = new DataSet();
                connection.Open();
                da.Fill(ds, "jurnal");
                connection.Close();
                dgv.DataSource = ds;
                dataGridView1.DataMember = "jurnal";
            }
            catch (SystemException) { MessageBox.Show("На данные даты нет информации"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Groupp.mdf;Integrated Security = True; Connect Timeout = 10000;";
            string sqlQuery = "SELECT nomer,name,data FROM jurnal";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, connection);
            DataSet ds = new DataSet();
            connection.Open();
            da.Fill(ds, "jurnal");
            connection.Close();
            dgv.DataSource = ds;
            dataGridView1.DataMember = "jurnal";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Groupp.mdf;Integrated Security = True; Connect Timeout = 1000;");
            conn1.Open();
            SqlCommand zapros = new SqlCommand("TRUNCATE TABLE jurnal;", conn1);
            if (zapros.ExecuteNonQuery() != 0)
                MessageBox.Show("История очищена");
            else
                MessageBox.Show("Ошибка");
            this.jurnalTableAdapter.Fill(this.grouppDataSet.Jurnal);
        } 


    }
}
