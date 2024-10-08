using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Enunc3
    {
        private double[] montosVentas;
        private List<double> clasificados = new List<double>();

        public void setMontosVentas(double [] montosVentas)
        {
            this.montosVentas = montosVentas;
        }
        public double[] ordenarMontosVentas()
        {
            Array.Sort(montosVentas);
            return montosVentas;
        }
        public List<double> clasificarVentas()
        {
            for (int i = 0; i < montosVentas.Length; i++)
            {
                if (montosVentas[i] >= 50 && montosVentas[i] <= 287)
                {
                    clasificados.Add(Convert.ToDouble(montosVentas[i]));
                }
            }
            return clasificados;
        }
    }
}
