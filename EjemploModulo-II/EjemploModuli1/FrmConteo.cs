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
    public partial class FrmConteo : Form
    {
        public FrmConteo()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int inicio, fin, suma = 0, contador;
            inicio=Convert.ToInt32(txtInicial.Text);
            fin = Convert.ToInt32(txtFinal.Text);
            txtResp.Clear();
            if (fin > inicio)
            {
                for (contador = inicio; contador <= fin; contador++)
                {
                    suma += contador;
                }
                txtResp.Text = (suma).ToString();
            }
            else
            {
                MessageBox.Show("Por favor revisar los valores dados");
            }
        }
    }
}
