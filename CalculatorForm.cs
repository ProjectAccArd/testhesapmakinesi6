using System;
using System.Windows.Forms;

namespace testhesapmakinesi6
{
    public partial class CalculatorForm : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || operation_pressed)
                textBox_Result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + b.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox_Result.Text);
            operation_pressed = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox_Result.Text = (value + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (value - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (value * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(textBox_Result.Text) != 0)
                    {
                        textBox_Result.Text = (value / Double.Parse(textBox_Result.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                    }
                    break;
                default:
                    break;
            }
            operation = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            value = 0;
        }
    }
}