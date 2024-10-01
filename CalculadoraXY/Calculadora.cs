using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraXY
{
    internal class Calculadora
    {

        public static double SomarNumeros(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public static double SubtrairNumeros(double numero1, double numero2)

        {
            return numero1 - numero2;
        }

        public static double MultiplicarNumeros(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public static double DividirNumeros(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                return 0;
            }
            else
            {
                return (numero1 / numero2);
            }
        }

        public static double PotenciaNumeros(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public static string Baskara1(double a, double b, double c)
        {
            double delta = (b * b) - 4 * a * c;
            double x1 = 0;
            double x2 = 0;

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                return "X1 = " + x1.ToString() + "\nX2 = " + x2.ToString();
            }
            else
            {
                if (delta == 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    return "X1 e X2 = " + x1.ToString();
                }
                else
                {
                    return "Não existe raiz real.";
                }
            }

        }


    }
}
