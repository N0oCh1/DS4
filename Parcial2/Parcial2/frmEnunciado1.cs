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
    public partial class frmEnunciado1 : Form
    {
    // defino clases que se usaran
        MetodosGenerales mg = new MetodosGenerales();
        Calculadora calculadora = new Calculadora();
        PointF[] puntos = new PointF[2];
        public frmEnunciado1()
        {
            InitializeComponent();
            txtA.Text = "0";
            txtB.Text = "0";
            txtC.Text = "0";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        // validando que los valores sean correcto y dependiendo de los 0 haga sobrecarga
            if(double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b) && double.TryParse(txtC.Text, out double c))
            {
                if (a.Equals(0))
                { 
                    calculadora.SetValores(b, c);
                    if (b.Equals(0))
                    {
                        calculadora.SetValores(c);
                    }
                }
                else
                {
                    calculadora.SetValores(a, b, c);
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        // verificar si la ecuacion sea valida
            if(double.IsNaN(calculadora.GetX1()) || double.IsNaN(calculadora.GetX2()))
            {
                MessageBox.Show("Ecuacion invalida Raiz negativo, Prueba aumentando el valor B o disminuye A o C", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtX1.Text = Convert.ToString(calculadora.GetX1());
                txtX2.Text = Convert.ToString(calculadora.GetX2());
                txtY.Text = Convert.ToString(calculadora.GetY());
            }
            
        }
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            // refrescar la grafica
            pbGrafica.Invalidate();
            // obtener los puntos de la grafica
            puntos = calculadora.GetPuntoGrafica(pbGrafica);
            calculadora.GetEje(lbX, lbY);
        }

        // metodos de validacion de entradas 
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            mg.esDigito(txtA, e);
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            mg.esDigito(txtB, e);
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            mg.esDigito(txtC, e);   
        }

        // evento para dibujar la grafica
        private void pbGrafica_Paint_1(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Pen lapiz = new Pen(Color.Red, 1);
            Pen lapiz2 = new Pen(Color.Blue, 1);
            PointF[] x =
            {
                new PointF(pbGrafica.Width/2, 0),
                new PointF(pbGrafica.Width/2, pbGrafica.Width)
            };
            PointF[] y =
            {
                new PointF(0,pbGrafica.Height/2),
                new PointF(pbGrafica.Height, pbGrafica.Height/2)
            };
            g.DrawLines(lapiz, x);
            g.DrawLines(lapiz, y);
            g.DrawLines(lapiz2, puntos);
        }
    }
}
