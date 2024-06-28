using Microsoft.VisualBasic.ApplicationServices;
using System;

namespace final_calculator
{

    public partial class Form1 : Form
    {
        private void EnableAllButtons()
        {
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonAdd.Enabled = true;
            buttonMinus.Enabled = true;
            buttonSqrt.Enabled = true;
            buttonPower.Enabled = true;
            buttonPercent.Enabled = true;
            buttonMult.Enabled = true;
            buttonDiv.Enabled = true;
            buttonEquals.Enabled = true;
            buttonDot.Enabled = true;
        }
        private void DisableAllButtons()
        {
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            buttonAdd.Enabled = false;
            buttonMinus.Enabled = false;
            buttonSqrt.Enabled = false;
            buttonPower.Enabled = false;
            buttonPercent.Enabled = false;
            buttonMult.Enabled = false;
            buttonDiv.Enabled = false;
            buttonEquals.Enabled = false;
            buttonDot.Enabled = false;
        }
        private string option { get; set; }
        private double num1 { get; set; }
        private double num2 { get; set; }
        private double result { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                txtTotal.Clear();
            }

            txtTotal.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                txtTotal.Clear();
            }
            txtTotal.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                txtTotal.Clear();
            }
            txtTotal.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                txtTotal.Clear();
            }
            txtTotal.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                txtTotal.Clear();
            }
            txtTotal.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                txtTotal.Clear();
            }
            txtTotal.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                txtTotal.Clear();
            }
            txtTotal.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                txtTotal.Clear();
            }
            txtTotal.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                txtTotal.Clear();
            }
            txtTotal.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                txtTotal.Clear();
            }
            txtTotal.Text += "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                num1 = double.Parse(txtTotal.Text);
                txtTotal.Clear();
            }
            option = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                num1 = double.Parse(txtTotal.Text);
                txtTotal.Clear();
            }
            option = "-";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                num1 = double.Parse(txtTotal.Text);
                txtTotal.Clear();
            }
            option = "*";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                num1 = double.Parse(txtTotal.Text);
                txtTotal.Clear();
            }
            option = "/";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                txtTotal.Text = "Invalid Format";
                DisableAllButtons();
                return;
            }

            num2 = double.Parse(txtTotal.Text);

            switch (option)
            {
                case "+":
                    if (double.IsNaN(num2))
                    {
                        txtTotal.Text = "Invalid Format";
                        DisableAllButtons();
                        return;
                    }
                    result = num1 + num2;
                    break;
                case "-":
                    if (double.IsNaN(num2))
                    {
                        txtTotal.Text = "Invalid Format";
                        DisableAllButtons();
                        return;
                    }
                    result = num1 - num2;
                    break;
                case "*":
                    if (double.IsNaN(num2))
                    {
                        txtTotal.Text = "Invalid Format";
                        DisableAllButtons();
                        return;
                    }
                    result = num1 * num2;
                    break;
                case "^":
                    if (double.IsNaN(num2))
                    {
                        txtTotal.Text = "Invalid Format";
                        DisableAllButtons();
                        return;
                    }
                    result = Math.Pow(num1, num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        txtTotal.Text = "Cannot Divide By 0";
                        DisableAllButtons();
                        return;
                    }
                    result = num1 / num2;
                    break;
            }

            txtTotal.Text = result.ToString();
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            EnableAllButtons();
            txtTotal.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            option = "^";
            num1 = Convert.ToDouble(txtTotal.Text);
            txtTotal.Clear();

        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtTotal.Text);
            if (num1 < 0)
            {
                txtTotal.Text = "Cannot square root a negative number";
                return;
            }
            result = Math.Sqrt(num1);
            txtTotal.Text = result.ToString();
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtTotal.Text);
            result = num1 / 100;
            txtTotal.Text = result.ToString();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!txtTotal.Text.Contains("."))
            {
                txtTotal.Text += ".";
            }

        }
    }
}
