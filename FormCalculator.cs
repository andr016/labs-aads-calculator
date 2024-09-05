using System;
using System.Windows.Forms;

namespace Calculator
{

    public partial class FormCalculator : Form
    {
        static TextBox _textBox;
        public static TextBox textBox { get => _textBox; set => _textBox = value; }
        static Label _label;
        public static Label labelMemory { get => _label; set => _label = value; }

        static Double _value = 0;
        public static Double value { get => _value; set => _value = value; }

        public double a = 0;
        public double b = 0;
//        public bool second;
        public string operation = "none";
        public bool checkzero = false;
        public FormCalculator()
        {
            InitializeComponent();
            //InitializeVariables();
        }

        public double Equals(string loperation, string loperation2)
        {
            if (operation != "none")
            {
                switch (loperation)
                {
                    case "":
                        break;
                    case "+":
                        a += b;
                        break;
                    case "-":
                        a -= b;
                        break;
                    case "*":
                        a *= b;
                        break;
                    case "/":
                        a /= b;
                        break;
                    case "^":
                        a = Math.Pow(a,b);
                        break;
                    case "log":
                        a = Math.Log(a, b);
                        break;
                }
                journal.Items.Add("=" + a.ToString() + loperation2);
            }
            return a;
        }
        public void SecondNumber(string localoperation)
        {
            //operation = localoperation;
            if(operation == "none")
            {
                journal.Items.Add(a.ToString() + localoperation);
                Equals(operation, "");
            } else
            {
                journal.Items.Add(a.ToString());
                Equals(operation, localoperation);
            }
            
            //second = true;
            display.Text = "0";
            b = a;
            a = 0;
            operation = localoperation;
        }
        public void DisplayUpdate(double f)
        {
            a = f;
            display.Text = f.ToString();
        }
        public void Input(string str)
        {
            
            if(display.Text == "0")
            {
                display.Text = "";
            }
            if (display.Text.Length > 2 && display.Text.Substring(display.Text.Length-2, 2) == ",0" && checkzero == true)
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
            if (str == "0") checkzero = false;

            /*            if(str == "." && str.Any("."))
                        {

                        }*/
            if (str == "," && str.Contains(","))
            {
                display.Text += ",0";
                checkzero = true;
            }
            else if (str == "," && !str.Contains(","))
            {
               
            } else
            {
                display.Text += str;
            }
            float c = float.Parse(display.Text);
            a = c;
            
        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            Input((sender as Button).Text);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            SecondNumber("+");
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            SecondNumber((sender as Button).Text);
        }

        private void buttonImmediateOperation_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            journal.Items.Add(s + "(" + a + ")");
            switch(s)
            {
                case "+/-":
                    DisplayUpdate(-a);
                    break;
                case "sqrt":
                    DisplayUpdate(Math.Sqrt(a));
                    break;
                case "sin":
                    DisplayUpdate(Math.Sin(a));
                    break;
                case "cos":
                    DisplayUpdate(Math.Cos(a));
                    break;
                case "sinh":
                    DisplayUpdate(Math.Sinh(a));
                    break;
                case "cosh":
                    DisplayUpdate(Math.Cosh(a));
                    break;
                case "Exp":
                    DisplayUpdate(Math.Sin(a));
                    break;
                case "Mod":
                    DisplayUpdate(Math.Abs(a));
                    break;
                case "log10":
                    DisplayUpdate(Math.Log10(a));
                    break;
                case "pi":
                    DisplayUpdate(3.1415);
                    break;
                case "round":
                    DisplayUpdate(Math.Round(a));
                    break;
            }
            journal.Items.Add("=" + display.Text);
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            journal.Items.Add(a.ToString());
            DisplayUpdate(Equals(operation, ""));
            operation = "none";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DisplayUpdate(0);
        }
    }
}
