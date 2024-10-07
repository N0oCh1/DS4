using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    internal class MetodosGenerales
    {
        public void esDigito (TextBox input, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.' && !input.Text.Contains('.'))
            {
                return;
            }
            e.Handled = true;
        }
    }
}
