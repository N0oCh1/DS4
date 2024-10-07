using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploModuli1
{
    internal class CFactorial
    {
        private int num;

        public void setNum(int valor)
        {
            this.num = valor;
        }
        public int factorialValor()
        {
            return calcularFactorial(num);  
        }
        private int calcularFactorial(int valor)
        {
            if(valor == 0)
            {
                return 1;
            }
            else
            {
                return valor* calcularFactorial(valor -1);
            }
        }
    }
}
