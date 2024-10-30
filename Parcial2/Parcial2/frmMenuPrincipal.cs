using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void enunciado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnunciado1 frmEnunciado1 = new frmEnunciado1();
            frmEnunciado1.MdiParent = this;
            frmEnunciado1.WindowState = FormWindowState.Maximized;  
            frmEnunciado1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void enunciado2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnunciado2 frmEnunciado2 = new frmEnunciado2();
            frmEnunciado2.MdiParent = this;
            frmEnunciado2.WindowState = FormWindowState.Maximized;
            frmEnunciado2.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
