using Microsoft.VisualBasic.Logging;
using CalculatorLogic;
using System.Text;
using System.Diagnostics.Metrics;

namespace CalculatorApp1
{
    public partial class Form1 : Form
    {
        private Calculations logic;
        private string firstNumber;
        private string secondNumber;
        private string operation;
        private string secondOperation;
        private bool isNegatebtnClicked;
        public Form1()
        {
            logic = new Calculations();
            InitializeComponent();
        }

        string result;
        int counter;
        public Form1(string firstNumber, string secondNumber, string operation, string secondOperation, bool isNegatebtnClicked)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.operation = operation;
            this.secondOperation = secondOperation;
            this.isNegatebtnClicked = isNegatebtnClicked;
        }
        public void Operations(string operations)
        {
            this.firstNumber = resulttxt.Text;
            operation = operations;
            resulttxt.Text = string.Empty;
            placeHolderLabelOfScreen.Text += operations;
        }
        public void AddingNumbers(string number)
        {
            if (resulttxt.Text == "0")
            {
                resulttxt.Text = number;
                placeHolderLabelOfScreen.Text = number;
            }
            else
            {
                resulttxt.Text += number;
                placeHolderLabelOfScreen.Text += number;
            }


        }
        private void onebtn_Click(object sender, EventArgs e)
        {
            AddingNumbers("1");
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            AddingNumbers("2");
        }



        private void sixbtn_Click(object sender, EventArgs e)
        {
            AddingNumbers("6");
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            AddingNumbers("5");
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            AddingNumbers("4");
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            AddingNumbers("7");
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            AddingNumbers("8");
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            AddingNumbers("9");
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            counter = 1;
            placeHolderLabelOfScreen.Text = string.Empty;
            resulttxt.Text = logic.MainOperation(firstNumber, secondNumber, resulttxt.Text, operation);
            placeHolderLabelOfScreen.Text = resulttxt.Text;
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            Operations("+");
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            Operations("-");
        }

        private void removeAllbtn_Click(object sender, EventArgs e)
        {
            resulttxt.Text = "0";
            placeHolderLabelOfScreen.Text = string.Empty;
        }

        private void zerobtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text != "0")
            {
                resulttxt.Text += "0";
                placeHolderLabelOfScreen.Text += "0";
            }

        }
        private void threebtn_Click(object sender, EventArgs e)
        {
            AddingNumbers("3");
        }

        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            Operations("×");
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            Operations("÷");
        }

        private void negatebtn_Click(object sender, EventArgs e)
        {
            double result = double.Parse(resulttxt.Text);
            if (result != 0)
            {
                result = result * -1;
            }
            else
            {
                result = 0;
            }
            resulttxt.Text = result.ToString();
        }

        private void removeLastOnebtn_Click(object sender, EventArgs e)
        {
            if (resulttxt.Text != "0" && resulttxt.Text != string.Empty)
            {
                List<char> list = resulttxt.Text.Trim().ToList();
                list.RemoveAt(resulttxt.Text.Length - 1);
                resulttxt.Text = string.Empty;
                placeHolderLabelOfScreen.Text = string.Empty;
                foreach (var a in list)
                {
                    resulttxt.Text += a;
                    placeHolderLabelOfScreen.Text += a;
                }
                if (resulttxt.Text.Length == 0)
                {
                    resulttxt.Text = "0";
                }
            }
        }

        private void sqrtbtn_Click(object sender, EventArgs e)
        {
            placeHolderLabelOfScreen.Text = $"²√{resulttxt.Text}";
            double result = double.Parse(resulttxt.Text);
            result = logic.SquareRoot(result);
            resulttxt.Text = result.ToString();
        }

        private void byThePowerOf2Btn_Click(object sender, EventArgs e)
        {
            placeHolderLabelOfScreen.Text = $"{resulttxt.Text}²";
            double result = double.Parse(resulttxt.Text);
            result = result * result;
            resulttxt.Text = result.ToString();
        }

        private void XDividedBy1Btn_Click(object sender, EventArgs e)
        {
            placeHolderLabelOfScreen.Text = $"1/{resulttxt.Text}";
            double result = double.Parse(resulttxt.Text);
            result = logic.XBelow1(result);
            resulttxt.Text = result.ToString();
        }

        private void percentbtn_Click(object sender, EventArgs e)
        {
            double result1;
            double.TryParse(resulttxt.Text, out result1);
            resulttxt.Text = $"{result1 / 100}";
        }

        private void removeLastbtn_Click(object sender, EventArgs e)
        {
            /*if (resulttxt.Text != "0" && resulttxt.Text != string.Empty)
            {
                List<char> list = placeHolderLabelOfScreen.Text.ToList();
                list.RemoveRange(firstNumber.Length+resulttxt.Text.Length+1,resulttxt.Text.Length);
                foreach (var a in list)
                {
                    placeHolderLabelOfScreen.Text += a;
                }
            }*/
            resulttxt.Text = string.Empty;
        }

        private void commabtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (resulttxt.Text == "0")
                {
                    double result = double.Parse(resulttxt.Text);
                    if (result / 1 == result)
                    {
                        resulttxt.Text += ",";
                        placeHolderLabelOfScreen.Text = "0,";

                    }

                }
                else
                {
                    double result = double.Parse(resulttxt.Text);
                    if (result / 1 == result)
                    {
                        resulttxt.Text += ",";
                        placeHolderLabelOfScreen.Text += ",";
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("You cannot add more than two commas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void resulttxt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    zerobtn.PerformClick();
                    break;
                case Keys.D1:
                    onebtn.PerformClick();
                    break;
                case Keys.D2:
                    twobtn.PerformClick();
                    break;
                case Keys.D3:
                    threebtn.PerformClick();
                    break;
                case Keys.D4:
                    fourbtn.PerformClick();
                    break;
                case Keys.D5:
                    fivebtn.PerformClick();
                    break;
                case Keys.D6:
                    sixbtn.PerformClick();
                    break;
                case Keys.D7:
                    sevenbtn.PerformClick();
                    break;
                case Keys.D8:
                    eightbtn.PerformClick();
                    break;
                case Keys.D9:
                    ninebtn.PerformClick();
                    break;
                case Keys.Decimal:
                    commabtn.PerformClick();
                    break;
                case Keys.Add:
                    plusbtn.PerformClick();
                    break;
                case Keys.Subtract:
                    minusbtn.PerformClick();
                    break;
                case Keys.Multiply:
                    multiplicationbtn.PerformClick();
                    break;
                case Keys.Divide:
                    dividebtn.PerformClick();
                    break;
                case Keys.Enter:
                    equalbtn.PerformClick();
                    break;
                case Keys.Execute:
                    equalbtn.PerformClick();
                    break;
                case Keys.Back:
                    removeLastOnebtn.PerformClick();
                    break;
            }
        }
    }
}