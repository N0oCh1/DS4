using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    internal class Enunciado1MG
    {
        private string nombreCuenta;
        private double saldoCuenta;
        private List<double> retiros = new List<double>();
        private List<double> depositos = new List<double>();
        public void AbrirCuenta(string nombre, double saldo)
        {
            nombreCuenta = nombre;
            saldoCuenta = saldo;
        }
        public double GetSaldoCuenta()
        {
            return saldoCuenta;
        }
        public void Depositar(double saldo, ListBox deposito) 
        {
            deposito.Items.Clear();
            saldoCuenta += saldo;
            depositos.Add(saldo);
            foreach (double valor in depositos)
            {
                deposito.Items.Add(valor.ToString());
            }

        }
        public void Retirar(double saldo, ListBox retiro)
        {

            if (saldo > saldoCuenta)
            {
                throw new ArgumentException("Saldo Insuficiente", nameof(saldo));
            }
            else
            {
                retiro.Items.Clear();
                saldoCuenta -= saldo;
                retiros.Add(saldo);
                foreach (double valor in retiros)
                {
                    retiro.Items.Add(valor.ToString());
                }
            }
        }
    }
}
