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
    public partial class FrmSumaVec : Form
    {
        public FrmSumaVec()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {
            int cantidad = 0, contador = 0, numero = 0;
            int[] vectorNum;
            if (int.TryParse(txtNum.Text, out cantidad))
            {
                vectorNum = new int[cantidad];
                while(cantidad > contador)
                {
                    string imput = Microsoft.VisualBasic.Interaction.InputBox($"Ingrese el {contador+1} valor", "Cargar numero");
                    if(int.TryParse(imput, out numero))
                    {
                        vectorNum[contador] = numero;
                        listBox1.Items.Add(numero);
                    }
                    else
                    {
                        MessageBox.Show("ingrese numeros enteros", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    contador = contador+1;

                };
                listBox1.Items.Add($"La sumatoria total el => {SumarNumero(vectorNum)}");
            }
            else
            {
                MessageBox.Show("ingrese numeros enteros", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private int SumarNumero (int[] numero)
        {
            int sumatoria = 0;
            foreach (int item in numero) 
            {
                sumatoria += item;
            }
            return sumatoria;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dato;
            int posicion = 0;
            dato = listBox1.SelectedItem.ToString();
            posicion = listBox1.SelectedIndex;
            MessageBox.Show($"Valor {dato}, posicion {posicion}");
        }
    }
    
}
