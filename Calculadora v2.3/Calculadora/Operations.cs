using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculadora;

namespace Operation
{
    public partial class Operations : Form
    {
        public string soma(double a, double b) {
            double c = a + b;
            return Convert.ToString(c);
        }

        public string subtr(double a, double b)
        {
            double c = a - b;
            return Convert.ToString(c);
        }

        public string multp(double a, double b)
        {
            double c = a * b;
            return Convert.ToString(c);
        }

        public string div(double a, double b)
        {
            double c = a / b;
            return Convert.ToString(c);
        }
        
        public string rst(double a, double b)
        {
            double c = a % b;
            return Convert.ToString(c);
        }

        public string pct(double a, double b)
        {
            double c = a / 100 * b;
            return Convert.ToString(c);
        }

        public string invrs(double a)
        {
            double b = a * (-1);
            return Convert.ToString(b);
        }

        public string sqrt(double a)
        {
            double b = Math.Sqrt(a);
            return Convert.ToString(b);
        }

        public string pow(double a)
        {
            double b = Math.Pow(a, 2);
            return Convert.ToString(b);
        }

        public string sin(double a)
        {
            double b = Math.Sin(a);
            return Convert.ToString(b);
        }

        public string cos(double a)
        {
            double b = Math.Cos(a);
            return Convert.ToString(b);
        }

        public string tg(double a)
        {
            double b = Math.Tan(a);
            return Convert.ToString(b);
        }

        public string Fatorial_iterativo(double a)
        {
            double resultado = 1;

            if (a == 0) { return "1"; }

            for (double i = 0; i < a; i++)
            {
                resultado *= a - i;
            }

            return Convert.ToString(resultado);
        }

        public string Fatorial_recursivo(double a, double result) 
        {
            if (a == 0) { return "1"; }
            if (a <= 1) { return Convert.ToString(result); }

            result *= a;
            a = a - 1;

            return Fatorial_recursivo(a, result);
        }

        public string Fibonacci_iterativo(int a) 
        {
            if ((a == 0) || (a == 1)) { return "0"; }

            int[] valores = new int[a];
            valores[0] = 0;
            valores[1] = 1;
            for(int i = 2; i < a; i++)
            {
                valores[i] = valores[i - 2] + valores[i - 1]; 
            }
            return Convert.ToString(valores[a - 1]);
        }

        public string Fibonacci_recursivo(double a, double b, double c) 
        {
            a--;
            double d = b + c;
            
            if (a > 2)
            {
                return Fibonacci_recursivo(a, c, d);
            }
            else if (a == 2)
            {
                return Convert.ToString(d);
            }
            else { return "0"; }
        }
    
    }
}
