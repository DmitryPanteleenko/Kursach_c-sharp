using System;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Exception;
using VkNet.Model.RequestParams;
using System.Data.SqlClient;
using System.Collections;
using Essy.Tools.InputBox;

namespace Курсач
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VkApi vk = new VkApi();
        string tok;
        ArrayList Ndej = new ArrayList();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;

        }
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vk.Authorize(new ApiAuthParams
                {
                    ApplicationId = 5646827,
                    Login = textBox1.Text.ToString(),
                    Password = textBox2.Text.ToString(),
                    Settings = Settings.All
                });
                tok = vk.Token;
            }
            catch (VkApiAuthorizationException)
            {
                MessageBox.Show("Нверный логин или пароль");
                groupBox1.BackColor = System.Drawing.Color.Red;
            }

            if (vk.Token != null)
                groupBox1.BackColor = System.Drawing.Color.Green;
            else
                groupBox1.BackColor = System.Drawing.Color.Red;
        }
        public void nedej()
        {
            Ndej.Clear();
            SqlConnection conn1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Groupp.mdf;Integrated Security = True; Connect Timeout = 10000;");
            conn1.Open();
            SqlCommand zapros = new SqlCommand(@"SELECT * FROM Inf_chas WHERE Gotovil=0 AND Otsytstv=0;");
            zapros.Connection = conn1;
            SqlDataReader myrdb = zapros.ExecuteReader();
            while (myrdb.Read())
            {
                Ndej.Add(int.Parse(myrdb[0].ToString()));
            }
        }

        public void gener()
        {
            inf_chasTableAdapter.Update(grouppDataSet);
            nedej();
            Random rnd = new Random();
            {
                if (Ndej.Count != 0 && textBox3.Text == "")
                {
                    int n = rnd.Next(0, Ndej.Count);
                    textBox3.Text = Ndej[n].ToString();
                    Ndej.RemoveAt(n);
                    inf_chasTableAdapter.Update(grouppDataSet);
                }

                if (Ndej.Count != 0 && textBox4.Text == "")
                {
                    int n = rnd.Next(0, Ndej.Count);
                    textBox4.Text = Ndej[n].ToString();
                    Ndej.RemoveAt(n);
                    inf_chasTableAdapter.Update(grouppDataSet);
                }

                if (Ndej.Count != 0 && textBox5.Text == "")
                {
                    int n = rnd.Next(0, Ndej.Count);
                    textBox5.Text = Ndej[n].ToString();
                    Ndej.RemoveAt(n);
                    inf_chasTableAdapter.Update(grouppDataSet);
                }
                else
                {
                    sbros();
                    gener();
                }

            }
        }

        public void sbros()
        {
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            SqlConnection conn1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Groupp.mdf;Integrated Security = True; Connect Timeout = 1000;");
            conn1.Open();
            SqlCommand zapros = new SqlCommand(@"UPDATE Inf_chas SET Gotovil=0;", conn1);
            if (zapros.ExecuteNonQuery() != 0)
                MessageBox.Show("yes");
            else
                MessageBox.Show("noy");
            nedej();
           //gener();
            this.inf_chasTableAdapter.Fill(this.grouppDataSet.Inf_chas);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grouppDataSet.Inf_chas". При необходимости она может быть перемещена или удалена.
            this.inf_chasTableAdapter.Fill(this.grouppDataSet.Inf_chas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gener();
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (vk.Token!= null)
            {
                button3.Enabled = false;
                dataGridView1[2, Convert.ToInt32(textBox3.Text) - 1].Value = true;
                jurnal(int.Parse(textBox3.Text), label1.Text);
                dataGridView1[2, Convert.ToInt32(textBox4.Text) - 1].Value = true;
                jurnal(int.Parse(textBox4.Text), label2.Text);
                dataGridView1[2, Convert.ToInt32(textBox5.Text) - 1].Value = true;
                jurnal(int.Parse(textBox5.Text), label3.Text);
                mess();
                inf_chasTableAdapter.Update(grouppDataSet);
            }
            else
                MessageBox.Show("Авторизируйтесь");

        }
        public void mess()
        {
            ulong[] ints = {
                Convert.ToUInt64(dataGridView1[3,int.Parse(textBox3.Text)-1].Value.ToString()),
                Convert.ToUInt64(dataGridView1[3,int.Parse(textBox4.Text)-1].Value.ToString()),
                Convert.ToUInt64(dataGridView1[3,int.Parse(textBox5.Text)-1].Value.ToString())};
            long id_gr = vk.Messages.CreateChat(ints, "Информационны час");
            vk.Messages.Send(new MessagesSendParams
            {
                ChatId = id_gr,
                Message = "Информацию готовят: " + label1.Text + "," + label2.Text + "," + label3.Text + "Кто про что будет готовить делите сами!" + "Оповестите друг друга сами."
            });
            vk.Messages.RemoveChatUser(id_gr, vk.UserId.Value);
            vk.Messages.DeleteDialog(userId: id_gr, isChat: true);

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
                label1.Text = dataGridView1[1, int.Parse(textBox3.Text) - 1].Value.ToString();
            else
                label1.Text = "";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
                label2.Text = dataGridView1[1, int.Parse(textBox4.Text) - 1].Value.ToString();
            else
                label2.Text = "";
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
                label3.Text = dataGridView1[1, int.Parse(textBox5.Text) - 1].Value.ToString();
            else
                label3.Text = "";
        }
        private void jurnal(Int32 nomer, string fio)
        {
            try
            {
                DateTime data = monthCalendar1.TodayDate.Date;
                SqlConnection conn1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Groupp.mdf;Integrated Security = True; Connect Timeout = 10000;");
                conn1.Open();
                data = monthCalendar1.SelectionStart.Date;
                SqlCommand zapros = new SqlCommand(@"INSERT INTO jurnal (Nomer,Name,Data) values('" + nomer + "',@Name,@Data)", conn1);
                zapros.Parameters.AddWithValue("@Name", fio);
                zapros.Parameters.AddWithValue("@Data",data);
                zapros.ExecuteNonQuery();
                conn1.Close();
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void разблокироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InputBox.ShowInputBox("Введите ключ суперпользователя") == "admin")
            {
                button3.Enabled = true;
                button2.Enabled = true;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;


            }
            else
                MessageBox.Show("Пароль неверен");


        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historu j = new Historu();
            j.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
       m1:
            Random rnd = new Random();
            if (Ndej.Count != 0)
            {
                int n = rnd.Next(0, Ndej.Count);
                textBox3.Text = Ndej[n].ToString();
                Ndej.RemoveAt(n);
                inf_chasTableAdapter.Update(grouppDataSet);
            }
            else
            {
                sbros();
                nedej();
                this.inf_chasTableAdapter.Fill(this.grouppDataSet.Inf_chas);
                goto m1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        m1:
            Random rnd = new Random();
            if (Ndej.Count != 0)
            {
                int n = rnd.Next(0, Ndej.Count);
                textBox4.Text = Ndej[n].ToString();
                Ndej.RemoveAt(n);
                inf_chasTableAdapter.Update(grouppDataSet);
            }
            else
            {
                sbros();
                nedej();
                this.inf_chasTableAdapter.Fill(this.grouppDataSet.Inf_chas);
                goto m1;
            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
        m1:
            Random rnd = new Random();
            if (Ndej.Count != 0)
            {
                int n = rnd.Next(0, Ndej.Count);
                textBox5.Text = Ndej[n].ToString();
                Ndej.RemoveAt(n);
                inf_chasTableAdapter.Update(grouppDataSet);
            }
            else
            {
                sbros();
                nedej();
                this.inf_chasTableAdapter.Fill(this.grouppDataSet.Inf_chas);
                goto m1;
            }
        }


        private void отправитьСообщениеВсемToolStripMenuItem_Click(object sender, EventArgs e)
        { int i=0;
            int col;
            SqlConnection connk = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Groupp.mdf;Integrated Security = True; Connect Timeout = 10000;");
            connk.Open();
            SqlCommand zaprosk = new SqlCommand(@"SELECT count(id_vk) FROM Inf_chas");
            zaprosk.Connection = connk;
            SqlDataReader myrdbk = zaprosk.ExecuteReader();
            myrdbk.Read();
            col = int.Parse(myrdbk[0].ToString());
            ulong[] spis = new ulong[col];

            SqlConnection conn1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Groupp.mdf;Integrated Security = True; Connect Timeout = 10000;");
            conn1.Open();
            SqlCommand zapros = new SqlCommand(@"SELECT id_vk FROM Inf_chas");
            zapros.Connection = conn1;
            SqlDataReader myrdb = zapros.ExecuteReader();
            while (myrdb.Read())
            {
                spis[i] = ulong.Parse(myrdb[0].ToString());
                i++;
            }

            string mes = InputBox.ShowInputBox("Введите сообщение");

            if (mes != null)
            {
                long id_ms = vk.Messages.CreateChat(spis, "Тест Курсовой");
                vk.Messages.Send(new MessagesSendParams
                {
                    ChatId = id_ms,
                    Message = mes

                });
            }
        }

        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Admin adm = new Admin();
                adm.Show();
        }

        private void оАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
           
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void сменаПароляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasChange ps = new PasChange();
            ps.Show();
        }
    }
}