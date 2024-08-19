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
    public partial class FrmCalificacion : Form
    {
        public FrmCalificacion()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int parcial1, parcial2, lab1, lab2, semestral;
            double nota = 0.0;
            string notaLetra = "";
            parcial1 = Convert.ToInt32(txtParcial1.Text);
            parcial2 = Convert.ToInt32(txtParcial2.Text);
            lab1 = Convert.ToInt32(txtLab1.Text);
            lab2 = Convert.ToInt32(txtLab2.Text);
            semestral = Convert.ToInt32(txtSemestral.Text);

            nota = (parcial1 + parcial2) / 2 * 0.35 + (lab1 + lab2) / 2 * 0.25 + (semestral * 0.40);
            txtNota.Clear();
            txtNotaL.Clear();
            txtNota.Text = Convert.ToString(nota);
            if (nota >= 91 && nota <= 100)
            {
                notaLetra = "A";
            }
            else if (nota >= 81 && nota <= 90)
            {
                notaLetra = "B";
            }
            else if (nota >= 71 && nota <= 80)
            {
                notaLetra = "C";
            }
            else if (nota >= 61 && nota <= 70)
            {
                notaLetra = "D";
            }
            else
            {
                notaLetra = "F";
            }
            txtNotaL.Text = notaLetra.ToString();
        }
    }
}
