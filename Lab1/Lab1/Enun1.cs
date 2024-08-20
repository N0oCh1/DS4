using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmEnun1 : Form
    {
        public frmEnun1()
        {
            InitializeComponent();
        }


        private void btnRetornar_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numG1.Maximum = 9999999;
            decimal g1, g2, g3;
            g1 = numG1.Value;
            g2 = numG2.Value;
            g3 = numG3.Value;
            txtbR.Text = Convert.ToString(g1 + g2 + g3);
        }

        private void numG2_ValueChanged(object sender, EventArgs e)
        {
            numG2.Maximum = 9999999;
            decimal g1, g2, g3;
            g1 = numG1.Value;
            g2 = numG2.Value;
            g3 = numG3.Value;
            txtbR.Text = Convert.ToString(g1 + g2 + g3);
        }

        private void numG3_ValueChanged(object sender, EventArgs e)
        {
            numG3.Maximum = 9999999;
            decimal g1, g2, g3;
            g1 = numG1.Value;
            g2 = numG2.Value;
            g3 = numG3.Value;
            txtbR.Text = Convert.ToString(g1 + g2 + g3);
        }
 
    }
}
