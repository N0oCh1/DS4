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
            Suma objForm1 = new Suma();
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

        private void btnEjem4_Click(object sender, EventArgs e)
        {
            Multiplicar multiplicar = new Multiplicar();
                multiplicar.Show();
        }

        private void btnEjemplo6_Click(object sender, EventArgs e)
        {
            Frmfactorial frmfactorial = new Frmfactorial();
            frmfactorial.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            FrmSumaVec frmSumaVec = new FrmSumaVec();
            frmSumaVec.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSumaArchivo frmSumaArchivo = new FrmSumaArchivo();
            frmSumaArchivo.Show();
        }
    }
}
