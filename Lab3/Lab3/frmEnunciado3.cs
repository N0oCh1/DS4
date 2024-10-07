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
        public frmEnunciado3()
        {
            InitializeComponent();
        }

        private void nupCantVentas_ValueChanged(object sender, KeyEventArgs e)
        {
            cantidad = Convert.ToInt32(nupCantVentas.Value);
            
        }
    }
}
