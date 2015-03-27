using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Operation;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Sinaliza a vírgula
        bool Dot_on = false;

        //Diz o limite de digitos
        int digit_limit = 19;

        //vê a operação
        string operation = "";
        
        //analisa e guarda o valor
        double value = 0;
        
        //avisa quando dar o resultado
        bool waiting_result = false;

        public Operations calc = new Operations();

        public Form1()
        {
            InitializeComponent();
            Operations calc = new Operations();
        }

        public void Button_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || waiting_result) {
                result.Text = null;
                waiting_result = false;
            }
                
            if (result.Text.Length < digit_limit) 
            {
                Button digit = sender as Button;
                result.Text += digit.Text;
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Button digit = sender as Button;
            if (!Dot_on) {
                result.Text += digit.Text;
                Dot_on = true;
            }
        }

        public void Clear_Number(object sender, EventArgs e)
        {
            result.Text = "0";
            Dot_on = false;
        }

        public void Erase_Digit(object sender, EventArgs e)
        {
            if (result.Text.ToString().IndexOf(",").Equals(result.Text.ToString().Length - 1)) { Dot_on = false; }
            
            result.Text = result.Text.ToString().Remove(result.Text.ToString().Length - 1);
            
            if (result.Text.ToString().Length <= 0) { result.Text = "0"; Dot_on = false; }
        }
        
        private void Clear_all(object sender, EventArgs e)
        {
            value = 0;
            result.Text = "0";
            Dot_on = false;
            waiting_result = false;
            operation = "";
            Equation = null;
        }

        public void Operation_Click(object sender, EventArgs e)
        {
            Button digit = sender as Button;
            operation = digit.Text;
            value = Convert.ToDouble(result.Text);
            waiting_result = true;
            Dot_on = false;
            Equation.Text = value + operation;
        }

        public void Quick_Operation(object sender, EventArgs e) 
        {
            Button digit = sender as Button;
            operation = digit.Text;
            value = Convert.ToDouble(result.Text);

            switch (operation) { 

                case "±":
                    result.Text = calc.invrs(value);
                    break;

                case "√":
                    result.Text = calc.sqrt(value);
                    break;

                case " ^ ":
                    result.Text = calc.pow(value);
                    break;

                case "tg":
                    result.Text = calc.tg(value);
                    break;

                case "cos":
                    result.Text = calc.cos(value);
                    break;

                case "sen":
                    result.Text = calc.sin(value);
                    break;

                default:
                    break;
            }
            waiting_result = false;
            if (Convert.ToDouble(result.Text) % 1 != 0)
            {
                Dot_on = true;
            }
        }

        public void Check_Answer(object sender, EventArgs e)
        {
            if (operation == "") { return ; }
            Equation.Text = null;
            switch (operation) { 
                case " + ":
                    result.Text = calc.soma(value, Convert.ToDouble(result.Text));
                    break;

                case " - ":
                    result.Text = calc.subtr(value, Convert.ToDouble(result.Text));
                    break;

                case " * ":
                    result.Text = calc.multp(value, Convert.ToDouble(result.Text));
                    break;
                
                case " / ":
                    result.Text = calc.div(value, Convert.ToDouble(result.Text));
                    break;

                case " R ":
                    result.Text = calc.rst(value, Convert.ToDouble(result.Text));
                    break;

                case " % ":
                    result.Text = calc.pct(value, Convert.ToDouble(result.Text));
                    break;

                default:
                    break;
            }
            waiting_result = false;
            if (Convert.ToDouble(result.Text) % 1 == 0) {
                Dot_on = false;
            }
        }

        private void Fatorial_iterativo(object sender, EventArgs e)
        {
            result.Text = calc.Fatorial_iterativo(Convert.ToDouble(result.Text));
        }

        private void Fatorial_recursivo(object sender, EventArgs e)
        {
            result.Text = calc.Fatorial_recursivo(Convert.ToDouble(result.Text), 1);
        }

        private void Fibonacci_iterativo(object sender, EventArgs e)
        {
            result.Text = calc.Fibonacci_iterativo(Convert.ToInt32(result.Text));
        }

        private void Fibonacci_recursivo(object sender, EventArgs e) {
            result.Text = calc.Fibonacci_recursivo(Convert.ToDouble(result.Text), 0, 1);
        }
    }
}
