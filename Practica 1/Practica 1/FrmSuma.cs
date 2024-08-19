using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class FrmSuma : Form
    {
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FrmSuma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1TB.Text);
            double num2 = Convert.ToDouble(Num2TB.Text);
            RestTB.Text = Convert.ToString(num1 + num2);
            //int inicio, fin, suma = 0, contador;
            //inicio = Convert.ToInt32(Num1TB.Text);
            //fin = Convert.ToInt32(Num2TB.Text);
            //if (fin > inicio)
            //{
            //    for(int i = inicio ; i <= fin; i++)
            //    {
            //        suma += i;
            //    }

            //}
        }

    }
}
