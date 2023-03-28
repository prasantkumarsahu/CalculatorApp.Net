using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CalculateorApp
{
    public partial class Form1 : Form
    {
        public static StringBuilder input;
        bool optCount = false;
        public Form1()
        {
            input = new StringBuilder();
            InitializeComponent();
            
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (!textBox1.ReadOnly)
            {
                input.Append('1');
                textBox1.Text = input.ToString();
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (!textBox1.ReadOnly)
            {
                input.Append('2');
                textBox1.Text = input.ToString();
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (!textBox1.ReadOnly)
            {
                input.Append('3');
                textBox1.Text = input.ToString();
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (!textBox1.ReadOnly)
            {
                input.Append('4');
                textBox1.Text = input.ToString();
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (!textBox1.ReadOnly)
            {
                input.Append('5');
                textBox1.Text = input.ToString();
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (!textBox1.ReadOnly)
            {
                input.Append('6');
                textBox1.Text = input.ToString();
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (!textBox1.ReadOnly)
            {
                input.Append('7');
                textBox1.Text = input.ToString();
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (!textBox1.ReadOnly)
            {
                input.Append('8');
                textBox1.Text = input.ToString();
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (!textBox1.ReadOnly)
            {
                input.Append('9');
                textBox1.Text = input.ToString();
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (!textBox1.ReadOnly)
            {
                input.Append('0');
                textBox1.Text = input.ToString();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if(input.Length > 0)
            {
                optCount = true;
                textBox1.ReadOnly = false;
                char ch = input[input.Length - 1];
                if(ch == '+' || ch == '-' || ch == 'x' || ch == '/' || ch == '%')
                {
                    optCount = false;
                }
                input.Remove(input.Length - 1, 1);
                textBox1.Text = input.ToString();
            }
        }
        
        private void AllClear_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            optCount = false;
            input.Clear();
            textBox1.Text = input.ToString();
            resultTextBox.Text = "";
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            if(!optCount && input.Length > 0 && !textBox1.ReadOnly)
            {
                input.Append('x');
                textBox1.Text = input.ToString();
                optCount = true;
            }
            
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (!optCount && input.Length > 0 && !textBox1.ReadOnly)
            {
                input.Append('-');
                textBox1.Text = input.ToString();
                optCount = true;
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (!optCount && input.Length > 0 && !textBox1.ReadOnly)
            {
                input.Append('+');
                textBox1.Text = input.ToString();
                optCount = true;
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (!optCount && input.Length > 0 && !textBox1.ReadOnly)
            {
                input.Append('/');
                textBox1.Text = input.ToString();
                optCount = true;
            }
        }

        private void Modulo_Click(object sender, EventArgs e)
        {
            if (!optCount && input.Length > 0 && !textBox1.ReadOnly)
            {
                input.Append('%');
                textBox1.Text = input.ToString();
                optCount = true;
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (input.Length > 0)
            {
                textBox1.ReadOnly = true;
                optCount = false;
                string str1 = "";
                string str2 = "";
                char optChar = 'p';
                bool opt = false;
                for (int i = 0; i < input.Length; i++)
                {
                    char ch = input[i];
                    if (ch >= '0' && ch <= '9')
                    {
                        if (!opt)
                        {
                            str1 += ch;
                        }
                        else
                        {
                            str2 += ch;
                        }
                    }
                    else
                    {
                        if (!opt)
                        {
                            optChar = ch;
                            opt = true;
                        }
                    }
                }

                int num1 = int.Parse(str1);
                int num2 = int.Parse(str2);

                switch (optChar)
                {
                    case '+':
                        resultTextBox.Text = Addition(num1, num2).ToString();
                        break;
                    case '-':
                        resultTextBox.Text = Substraction(num1, num2).ToString();
                        break;
                    case 'x':
                        resultTextBox.Text = Multiplication(num1, num2).ToString();
                        break;
                    case '/':
                        resultTextBox.Text = Division(num1, num2).ToString();
                        break;
                    case '%':
                        resultTextBox.Text = Modulos(num1, num2).ToString();
                        break;
                    default:
                        resultTextBox.Text = "";
                        break;
                }
            }
        }
        
        private int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        private int Substraction(int num1, int num2)
        {
            return num1 - num2;
        }
        private int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        private int Division(int num1, int num2)
        {
            return num1 / num2;
        }
        private int Modulos(int num1, int num2)
        {
            return num1 % num2;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
