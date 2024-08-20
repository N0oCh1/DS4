using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmEnun2 : Form
    {
        public frmEnun2()
        {
            InitializeComponent();
        }

        private void numkilow_ValueChanged(object sender, EventArgs e)
        {
            numkilow.Maximum = 9999999;
            decimal kw = 0;
            double tarifa = 0;
            kw = numkilow.Value;
            tarifa = Convert.ToDouble(kw) * 0.19181;
            txtbTarifa.Text = Convert.ToString(tarifa);
        }
    }
}
