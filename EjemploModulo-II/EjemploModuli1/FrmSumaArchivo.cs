using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploModuli1
{
    public partial class FrmSumaArchivo : Form
    {
        public FrmSumaArchivo()
        {
            InitializeComponent();
        }

        private void TxtRestM1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRestM2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEje1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\";
                ofd.Filter = "CSV files (*.csv)|*.csv|Text file (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int suma = 0;
                        string[] lineas = File.ReadAllLines(ofd.FileName);
                        foreach (string line in lineas)
                        {
                            string[] numero = line.Split(';');
                            foreach (string numero2 in numero)
                            {
                                if (int.TryParse(numero2, out int valor))
                                {
                                    suma += valor;
                                }
                            }
                        }
                        TxtRestM1.Text = suma.ToString();
                    }
                    catch (Exception ex)
                    {
                        {
                            MessageBox.Show("Error en la lectura de archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void BtnEje2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\";
                ofd.Filter = "CSV files (*.csv)|*.csv|Text file (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int suma = File.ReadLines(ofd.FileName)
                            .SelectMany(linea => linea.Split(';'))
                            .Select(item => int.TryParse(item, out int valor) ? valor:0)
                            .Sum();
                        TxtRestM2.Text = suma.ToString();
                    }
                    catch (Exception ex)
                    {
                        {
                            MessageBox.Show("Error en la lectura de archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                

            }
        }
    }
}
