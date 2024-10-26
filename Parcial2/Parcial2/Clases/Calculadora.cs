using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    internal class Calculadora
    {
        private double y;
        private double x1;
        private double x2;
        private double A;
        private double B;
        private double C;
        PointF[] puntos;

     // sobre carga de clases 
        public void SetValores (double a, double b, double c)
        { 
            double divisor = 2 * a;
            double discriminador = (b*b)-(4*a*c);
            x1 = Math.Round((-b + Math.Sqrt(discriminador)) / divisor , 0);
            x2 = Math.Round((-b - Math.Sqrt(discriminador)) / divisor, 0);
            y = c;
            A = a;
            B = b;
            C = c;
        }
        public void SetValores (double b, double c)
        {
            A = 0;
            B = b;
            C = c;
            x1 = Math.Round((-1*C) / B);
            x2 = 0;
            y = C;
        }
        public void SetValores (double c)
        {
            A = 0;
            B = 0;
            C = c;
            y = c;
            x1 = 0;
            x2 = 0; 
        }
        public PointF[] GetPuntoGrafica (PictureBox tamano)
        {
        // seteo los valores para el uso
            int xCentral = tamano.Width / 2;
            int yCentral = tamano.Height / 2;
            int IntX1 = Convert.ToInt32(x1);
            int IntX2 = Convert.ToInt32(x2);
            int Contador = 0;
        // defino el arreglo para los puntos 
            puntos =  new PointF[Math.Abs(IntX1 - IntX2) +41];
        // For para usar la ecuacion y = Ax^2 + Bx + C en cada punto de X y multiplico por 5 para escalar la grafica
            for (int x = (IntX1>=IntX2 ? IntX2 : IntX1) -20; x<= (IntX1 <= IntX2 ? IntX2 : IntX1) +20; x++) 
            {
                int A1 = Convert.ToInt32(A * x * x);
                int B1 = Convert.ToInt32(B * x);
                int C1 = Convert.ToInt32(C);
                int Y = (A1 + B1 + C1) * 5;
                puntos[Contador] = new PointF(xCentral + x * 5, yCentral - Y);
                Contador++;
            }
            return puntos;
        }
       
        // obtener todos los puntos de la grafica
        public void GetEje (ListBox lbX, ListBox lbY)
        {
            lbX.Items.Clear();
            lbY.Items.Clear();
            foreach (PointF puntosXY in puntos)
            {
                lbX.Items.Add(puntosXY.X);
                lbY.Items.Add(puntosXY.Y);
            }
        }
    // obtener puntos de interseccion
        public double GetX1 ()
        {
            return x1;
        }
        public double GetX2 ()
        {
            return x2;
        }
        public double GetY() 
        { 
            return y;
        }
    }
}
