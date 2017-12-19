using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grouppDataSet.Inf_chas". При необходимости она может быть перемещена или удалена.
            this.inf_chasTableAdapter.Fill(this.grouppDataSet.Inf_chas);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            inf_chasTableAdapter.Update(grouppDataSet);
        }

        private void сменаПароляToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
