
using Parcial2.Clases;
using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class frmEnunciado2 : Form
    {
        ConsultasDB consultasDB = new ConsultasDB();
        MetodosGenerales metodos = new MetodosGenerales();
        public frmEnunciado2()
        {
            InitializeComponent();
        }
        private void frmEnunciado2_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Left = (this.ClientSize.Width - flowLayoutPanel1.Width) / 2;
            ActualizarTodosLosCB();
        }
        // agregar nuevo Medicamentos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPrecio.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("tienes que agregar valores al agregar medicamentos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                consultasDB.AgregarDato(txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtPrecio.Text), pbImagen);
                ActualizarTodosLosCB();
                txtNombre.Text = null;
                txtPrecio.Text = null;
                txtCantidad.Text = null;
                pbImagen.Image = null;
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            metodos.CargarImagen(pbImagen);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pbImagen.Image = null;
        }

    // Actualizar Medicamentos 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultasDB.ObtenerInfo(cbBuscar, txtNombreM, txtPrecioM, txtCantidadM, pbImagenM);
            txtCantidadM.ReadOnly = false;
            txtNombreM.ReadOnly = false;
            txtPrecioM.ReadOnly = false;   
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            consultasDB.ActualizarMedicamentos(cbBuscar, txtNombreM.Text, Convert.ToInt32(txtCantidadM.Text), Convert.ToDouble(txtPrecioM.Text), pbImagenM);
            ActualizarTodosLosCB();
            txtCantidadM.ReadOnly = true;
            txtNombreM.ReadOnly = true;
            txtPrecioM.ReadOnly = true;
            pbImagenM.Image = null;
        }
        private void btnImagenM_Click(object sender, EventArgs e)
        {
            metodos.CargarImagen(pbImagenM);
        }
        private void btnBorrarM_Click(object sender, EventArgs e)
        {
            pbImagenM.Image = null;
        }
    // Vender Medicamentos
        private void btnBuscarV_Click(object sender, EventArgs e)
        {
            consultasDB.ObtenerInfo(cbBuscarV, txtStock, pbImageV);
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            consultasDB.Transaccion(cbBuscarV, txtCantidadV);
            txtCantidadV.Text = null;
            consultasDB.ObtenerInfo(cbBuscarV, txtStock, pbImageV);
            pbImageV.Image= null;
        }
    // Reabastecer Medicamentos
        private void btnBuscarR_Click(object sender, EventArgs e)
        {
            consultasDB.ObtenerInfo(cbBuscarR, txtStockR, pbImagenR);
        }
        private void btnReponer_Click(object sender, EventArgs e)
        {
            consultasDB.Transaccion(cbBuscarR, txtCantidadR, "reponer");
            txtCantidadR.Text = null;
            consultasDB.ObtenerInfo(cbBuscarR, txtStockR, pbImagenR);
            pbImagenR.Image= null;
        }
    // Consultar estado del inventario
        private void btnInventario_Click(object sender, EventArgs e)
        {
            consultasDB.GetInventario(dgvInventario);
        }

    // validacion de los TextBox
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.esDecimal(txtPrecio, e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.soloNumero(txtCantidad, e);
        }

        private void txtPrecioM_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.esDecimal(txtPrecioM, e);
        }

        private void txtCantidadM_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.soloNumero(txtCantidadM, e);
        }

        private void txtCantidadV_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.soloNumero(txtCantidadV, e);
        }

        private void txtCantidadR_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.soloNumero(txtCantidadR,e); 
        }
        // Me canse de escribir lo mismo
        public void ActualizarTodosLosCB()
        {
            consultasDB.AgregarDataCB(cbBuscar);
            consultasDB.AgregarDataCB(cbBuscarV);
            consultasDB.AgregarDataCB(cbBuscarR);
        }

    }
}
