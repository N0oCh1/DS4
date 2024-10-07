using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cuentaDeAhorroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnunciado1 frmEnunciado1 = new frmEnunciado1();
            frmEnunciado1.MdiParent = this; 
            frmEnunciado1.WindowState = FormWindowState.Maximized;
            frmEnunciado1.Show();
        }

        private void enunciado3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnunciado3 frmEnunciado3 = new frmEnunciado3();
            frmEnunciado3.MdiParent = this;
            frmEnunciado3.WindowState = FormWindowState.Maximized;
            frmEnunciado3.Show();
        }
    }
}
