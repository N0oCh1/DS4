using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmEnunciado2 : Form
    {
        public frmEnunciado2()
        {
            InitializeComponent();
        }

        private void frmEnunciado2_Load(object sender, EventArgs e)
        {  
            dgvLista.ColumnCount = 1;
            dgvLista.Columns[0].Name = "Número";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OperacionesNumeros.agregarNumero(txtAgregar.Text, dgvLista);
        }

        private void btnEliminarIguales_Click(object sender, EventArgs e)
        {
            OperacionesNumeros.eliminarNumero(txtEliminar.Text, dgvLista);
        }
    }
}

