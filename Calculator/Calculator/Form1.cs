using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private int FirstValue , SecondValue;
        private char Operator;

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";

        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";


        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";

        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";

        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            FirstValue = int.Parse(textBox2.Text);
            Operator = '/';
            textBox2.Clear();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            SecondValue = int.Parse(textBox2.Text);
            int Result = 0;

            switch (Operator)
            {
                case '+':
                    Result = FirstValue + SecondValue; 
                    break;
                case '-':
                    Result = FirstValue - SecondValue;

                    break;
                case '*':
                    Result = FirstValue * SecondValue;

                    break;
                case '/':
                    Result = FirstValue / SecondValue;

                    break;

                default:textBox2.Text = "Invalid Operator Or Sing"; break;
               
            }

            textBox2.Clear();

            textBox2.Text = Result.ToString();

        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            FirstValue = int.Parse(textBox2.Text);
            Operator = '*';
            textBox2.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            FirstValue = int.Parse(textBox2.Text);
            Operator = '-';
            textBox2.Clear();

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            FirstValue = int.Parse(textBox2.Text);
            Operator = '+';
            textBox2.Clear();

        }
    }
}
