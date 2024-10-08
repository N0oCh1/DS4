using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmEnunciado3 : Form
    {
        private int cantidad;
        private double[] montosVentas;
        private double[] montosOrdenados;
        private List<double> clasificados = new List<double>();
        Enunc3 objEnunc3 = new Enunc3();

        public frmEnunciado3()
        {
            InitializeComponent();
        }

        private void nupCantVentas_ValueChanged_1(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(nupCantVentas.Value);
            if (cantidad >= 0)
            {
                dgvMontosVentas.ColumnCount = 1;
                dgvMontosVentas.RowCount = cantidad;

                dgvOrdenado.ColumnCount = 1;
                dgvOrdenado.RowCount = cantidad;

               
                for (int i = 0; i < cantidad; i++)
                {
                    dgvMontosVentas.Rows[i].Cells[0].Value = null;
                }
                for (int i = 0; i < cantidad; i++)
                {
                    dgvOrdenado.Rows[i].Cells[0].Value = null; 
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            montosVentas = new double[dgvMontosVentas.RowCount];

            
            for (int i = 0; i < montosVentas.Length; i++)
            {
               
                if (dgvMontosVentas.Rows[i].Cells[0].Value == null || !double.TryParse(dgvMontosVentas.Rows[i].Cells[0].Value.ToString(), out montosVentas[i]))
                {

                    MessageBox.Show("Por favor, ingrese valores válidos en todos los montos (no dejar montos vacios).",
                                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            objEnunc3.setMontosVentas(montosVentas);
            montosOrdenados = objEnunc3.ordenarMontosVentas();

            for (int i = 0; i < dgvMontosVentas.RowCount; i++)
            {
                dgvOrdenado.Rows[i].Cells[0].Value = montosOrdenados[i];
            }
        }

        private void btnClasificar_Click(object sender, EventArgs e)
        {
            
            if (montosVentas == null || montosVentas.Length == 0 || montosVentas.All(m => m == 0))
            {
                MessageBox.Show("No hay montos disponibles para clasificar.",
                                "Error de Clasificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            clasificados = objEnunc3.clasificarVentas();

           
            dgvClasif.Rows.Clear();
            dgvClasif.RowCount = clasificados.Count;

            for (int i = 0; i < clasificados.Count; i++)
            {
                dgvClasif.Rows[i].Cells[0].Value = clasificados[i];
            }
        }
    }
}

