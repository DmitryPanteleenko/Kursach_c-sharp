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
    public partial class PasChange : Form
    {
        public PasChange()
        {
            InitializeComponent();
        }

        private void PasChange_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "grouppDataSet.logpas". При необходимости она может быть перемещена или удалена.
            this.logpasTableAdapter.Fill(this.grouppDataSet.logpas);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void PasChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            logpasTableAdapter.Update(grouppDataSet);
        }
    }
}
