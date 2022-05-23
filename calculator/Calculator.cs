using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        private double value = 0;
        private double result = 0;
        private int? equation = null;

        public Calculator()
        {
            InitializeComponent();
        }

        private void InputNumber(int i)
        {
            this.textResult.Text += i.ToString();
            value = Int64.Parse(textResult.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            InputNumber(0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            InputNumber(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            InputNumber(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            InputNumber(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            InputNumber(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InputNumber(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InputNumber(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            InputNumber(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InputNumber(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InputNumber(9);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textResult.Text = "";
            value = 0;
        }

        private void Sum(object sender, EventArgs e)
        {
            equation = 0;
            this.textResult.Text = "";
            this.equationLabel.Text = value.ToString() + " + ";
            if(result != 0)
            {
                result = Equation(result, value);
            }
            else 
            {
                result = value;
            }
        }

        private void Subtract(object sender, EventArgs e)
        {
            equation = 1;
            this.textResult.Text = "";
            this.equationLabel.Text = value.ToString() + " - ";
            if (result != 0)
            {
                result = Equation(result, value);
            }
            else
            {
                result = value;
            }
        }

        private void Multiply(object sender, EventArgs e)
        {
            equation = 2;
            this.textResult.Text = "";
            this.equationLabel.Text = value.ToString() + " x ";
            if (result != 0)
            {
                result = Equation(result, value);
            }
            else
            {
                result = value;
            }
        }

        private void Divide(object sender, EventArgs e)
        {
            equation = 3;
            this.textResult.Text = "";
            this.equationLabel.Text = value.ToString() + " / ";
            if (result != 0)
            {
                result = Equation(result, value);
            }
            else
            {
                result = value;
            }
        }

        private void ClearAll(object sender, EventArgs e)
        {
            this.textResult.Text = "";
            this.equationLabel.Text = "";
            value = 0;
            result = 0;
        }

        private void Result(object sender, EventArgs e)
        {
            result = Equation(result, value);
            this.textResult.Text = result.ToString();
            this.equationLabel.Text += value.ToString() + "=";
            value = result;
            result = 0;
        }

        private double Equation(double firstValue, double secondValue)
        {
            switch (equation)
            {
                case 0:
                    result = firstValue + secondValue;
                    return result;
                case 1:
                    result = firstValue - secondValue;
                    return result;
                case 2:
                    result = firstValue * secondValue;
                    return result;
                case 3:
                    result = firstValue / secondValue;
                    return result;
                default:
                    result = 0;
                    return result;
            }
        }

        private void changeOperator(object sender, EventArgs e)
        {
            value = value * -1;
            this.textResult.Text = value.ToString();
        }

        private void putDecimal(object sender, EventArgs e)
        {
        }
    }
}
