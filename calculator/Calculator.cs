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
            if(this.textResult.Text.Length <= 8)
            {
                this.textResult.Text += i.ToString();
                value = Double.Parse(textResult.Text);
            }

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
            this.equationLabel.Text += value.ToString() + " = ";
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
            string text = this.textResult.Text;
            if (!text.Contains(','))
            {
                this.textResult.Text += ',';
            }
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0) InputNumber(0);
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1) InputNumber(1);
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2) InputNumber(2);
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3) InputNumber(3);
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4) InputNumber(4);
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5) InputNumber(5);
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6) InputNumber(6);
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7) InputNumber(7);
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8) InputNumber(8);
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9) InputNumber(9);

            if (e.KeyCode == Keys.Add) Sum(sender, e);
            if (e.KeyCode == Keys.Subtract) Subtract(sender, e);
            if (e.KeyCode == Keys.Multiply) Multiply(sender, e);
            if (e.KeyCode == Keys.Divide) Divide(sender, e);
            if (e.KeyCode == Keys.Enter) Result(sender, e);
            if (e.KeyCode == Keys.Back) btnClear_Click(sender, e);
        }
    }
}
