using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploModuli1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FrmConteo frmConteo = new FrmConteo();
            frmConteo.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            FrmCalificacion frm = new FrmCalificacion();
            frm.Show();
        }
    }
}
