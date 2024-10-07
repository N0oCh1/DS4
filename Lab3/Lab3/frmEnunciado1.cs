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
    public partial class frmEnunciado1 : Form
    {
        private Enunciado1MG Banco = new Enunciado1MG();
        private MetodosGenerales mg = new MetodosGenerales();
        public frmEnunciado1()
        {
            InitializeComponent();
        }

        private void btnAbrirCuenta_Click(object sender, EventArgs e)
        {
            // validar si tiene valor el txb del cliente
            // mostrar label de error
            if (tbCliente.Text.Length > 0 && double.TryParse(tbMonto.Text, out double montoInicial))
            {
                lblErrorCliente.Visible = false;
                lblErrorMontobl.Visible = false;
                if (montoInicial < 0)
                {
                    lblErrorMonto.Visible = true;
                }
                else
                {
                    lblErrorCliente.Visible = false;
                    lblErrorMonto.Visible = false;
                    Banco.AbrirCuenta(tbCliente.Text, montoInicial);
                    btnAbrirCuenta.Enabled = false;
                    pnlCuentaAhorro.Visible = true;
                    pnlTransaccion.Visible = true;
                    tbSaldoCuenta.Text = tbMonto.Text;
                }
            }
            else
            {
                lblErrorCliente.Visible = (tbCliente.Text.Length > 0 ? false : true);
                lblErrorMontobl.Visible = (tbMonto.Text.Length > 0 ? false : true);
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblErrorSaldo.Visible = (tbSaldo.Text.Length > 0 ? false : true);
            lblErrorTransaccion.Visible = (rbDeposito.Checked || rbRetiro.Checked ? false : true);
            if(tbSaldo.Text.Length> 0)
            {
                if (rbDeposito.Checked)
                {
                    Banco.Depositar(Convert.ToDouble(tbSaldo.Text), lbDeposito);
                    tbSaldoCuenta.Text = Banco.GetSaldoCuenta().ToString();
                    
                }
                if (rbRetiro.Checked)
                {
                    try
                    {
                        Banco.Retirar(Convert.ToDouble(tbSaldo.Text), lbRetiros);
                        tbSaldoCuenta.Text = Banco.GetSaldoCuenta().ToString();

                    }
                    catch
                    {
                        MessageBox.Show("Saldo insuficiente para retirar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
            }
            tbSaldo.Text = null;
        }

        private void frmEnunciado1_Load(object sender, EventArgs e)
        {
            tbMonto.Text = "0";
        }

        // solo para digito y un punto(.)
        private void tbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            mg.esDigito(tbMonto, e);
        }

        private void tbSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            mg.esDigito(tbSaldo, e);
        }
    }
}
