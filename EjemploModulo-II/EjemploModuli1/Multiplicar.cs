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
    public partial class Multiplicar : Form
    {
        public Multiplicar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEjecuar_Click(object sender, EventArgs e)
        {
            int inicio, fin, total = 0;
            inicio = Convert.ToInt32(txtInicial.Text);
            fin = Convert.ToInt32(txtFinal.Text);
            if (inicio < fin)
            {
                MetodoGeneral.MultiplosDTres(inicio, fin, ref total);
                txtTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("verifiue los valores de entrada");
            }
            
        }

        private void txtFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
