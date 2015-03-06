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
    }
}
