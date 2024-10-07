using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace EjemploModuli1
{
    public partial class Frmfactorial : Form
    {
        public Frmfactorial()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int inicial = 0, final = 0, respuesta = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {
            CFactorial cFactorial = new CFactorial();
            int num = Convert.ToInt32(txtNum.Text);
            listBox1.Items.Clear();
            for (int i = 0; i<=num; i++)
            {
                cFactorial.setNum(Math.Abs(i));
                listBox1.Items.Add($"{i}! = {cFactorial.factorialValor()}");
            }
        }
    }
}
