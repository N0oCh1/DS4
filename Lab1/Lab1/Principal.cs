using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmEnun1 frmEnun1 = new frmEnun1();
            frmEnun1.Show();
        }

        private void btnEnun2_Click(object sender, EventArgs e)
        {
            frmEnun2 frmEnun2 = new frmEnun2();
            frmEnun2.Show();
        }
    }
}
