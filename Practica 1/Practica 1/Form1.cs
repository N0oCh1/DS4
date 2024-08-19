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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            for(int i = 0; i<10; i++) 
            {
                Form1 objec = new Form1();
                objec.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSuma frmSuma = new FrmSuma();
            frmSuma.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Action console = () => Console.WriteLine("hola");
            TextBox textBox = new TextBox();
            textBox.Text = "dwaawdwd";
            textBox.Focus();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
