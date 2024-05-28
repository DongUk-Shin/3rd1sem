using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Parser p = new Parser();
        bool equalFlag = false;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                textBox1.Clear();
                equalFlag = false;
            }
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                textBox1.Clear();
                equalFlag = false;
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                textBox1.Clear();
                equalFlag = false;
            }
            textBox1.Text += "2";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                textBox1.Clear();
                equalFlag = false;
            }
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                textBox1.Clear();
                equalFlag = false;
            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                textBox1.Clear();
                equalFlag = false;
            }
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                textBox1.Clear();
                equalFlag = false;
            }
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                textBox1.Clear();
                equalFlag = false;
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                textBox1.Clear();
                equalFlag = false;
            }
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                textBox1.Clear();
                equalFlag = false;
            }
            textBox1.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] != '-')
            {
                textBox1.Text = "-(" + textBox1.Text + ")";
            }
            else if (textBox1.Text.StartsWith("-(") && textBox1.Text.EndsWith(")"))
            {
                textBox1.Text = textBox1.Text.Substring(2, textBox1.Text.Length - 3);
            }
        }

        //하나 지우기
        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        // =
        private void button16_Click(object sender, EventArgs e)
        {
            string exp = textBox1.Text;
            double result = p.Evaluate(exp);

            textBox2.Text = "" + result;
            equalFlag = true;
        }

        // +
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        // -
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        // 
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        // 나누기
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        // 루트
        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                textBox2.Text = "" + Math.Sqrt(double.Parse(textBox2.Text));
            }
        }

        // 제곱
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                textBox2.Text = "" + Math.Pow(double.Parse(textBox2.Text), 2);
            }
        }

        // 1/x
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                textBox2.Text = "" + (1 / double.Parse(textBox2.Text));
            }
        }

        // sin
        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                double degrees = double.Parse(textBox2.Text);
                double radians = degrees * (Math.PI / 180);
                textBox2.Text = "" + Math.Sin(radians);
            }
        
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                double degrees = double.Parse(textBox2.Text);
                double radians = degrees * (Math.PI / 180); 
                textBox2.Text = "" + Math.Cos(radians);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                double degrees = double.Parse(textBox2.Text);
                double radians = degrees * (Math.PI / 180); 
                textBox2.Text = "" + Math.Tan(radians);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {

            long fact(long n)
            {
                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }

            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                long temp = long.Parse(textBox2.Text);
                textBox2.Text = "" + fact(temp);
            }

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox1.Text = "";
                double temp = double.Parse(textBox2.Text);
                textBox2.Text = "" + Math.Log10(temp);
            }
        }


    }

    class Parser
    {
        private const int NONE = 0;
        private const int OPERATOR = 1;
        private const int NUMBER = 2;

        private const string EOE = "\0";

        private string exp;
        private int expIdx;
        private string token;
        private int tokType;

        public double Evaluate(string expstr)
        {
            double result;
            exp = expstr;
            expIdx = 0;

            Lex();
            if (token == EOE)
                HandleError();

            result = Expr();

            if (token != EOE)
                HandleError();

            return result;
        }

        private double Expr()
        {
            char op;
            double result;
            double nextResult;

            result = Term();

            while ((op = token[0]) == '+' || op == '-')
            {
                Lex();
                nextResult = Term();
                switch (op)
                {
                    case '+':
                        result += nextResult;
                        break;
                    case '-':
                        result -= nextResult;
                        break;
                }
            }
            return result;
        }

        private double Term()
        {
            char op;
            double result;
            double nextResult;

            result = Factor();

            while ((op = token[0]) == '*' || op == '/')
            {
                Lex();
                nextResult = Factor();
                switch (op)
                {
                    case '*':
                        result *= nextResult;
                        break;
                    case '/':
                        if (nextResult == 0.0)
                            HandleError();
                        result /= nextResult;
                        break;
                }
            }
            return result;
        }

        private double Factor()
        {
            double result;
            char unaryOp = '\0';

            if (token == "+" || token == "-")
            {
                unaryOp = token[0];
                Lex();
            }

            if (token == "(")
            {
                Lex();
                result = Expr();
                if (token != ")")
                    HandleError();
                Lex();
            }
            else
            {
                result = Number();
            }

            if (unaryOp == '-')
            {
                result = -result;
            }

            return result;
        }

        private double Number()
        {
            double result = 0.0;

            if (tokType == NUMBER)
            {
                result = double.Parse(token);
                Lex();
            }
            else
            {
                HandleError();
            }
            return result;
        }

        private void HandleError()
        {
            throw new Exception("Error");
        }

        private void Lex()
        {
            tokType = NONE;
            token = "";

            if (expIdx == exp.Length)
            {
                token = EOE;
                return;
            }

            if (IsOperator(exp[expIdx]))
            {
                token += exp[expIdx];
                expIdx++;
                tokType = OPERATOR;
            }
            else if (char.IsDigit(exp[expIdx]) || exp[expIdx] == '.')
            {
                while (expIdx < exp.Length && (char.IsDigit(exp[expIdx]) || exp[expIdx] == '.'))
                {
                    token += exp[expIdx];
                    expIdx++;
                }
                tokType = NUMBER;
            }
            else
            {
                HandleError();
            }
        }

        private bool IsOperator(char c)
        {
            return "+-*%^=()/".IndexOf(c) != -1;
        }
    }
}
