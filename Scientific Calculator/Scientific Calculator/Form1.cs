using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Scientific_Calculator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        bool equal;
        private double memory;

        public Form1()
        {
            InitializeComponent();
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 350;
            textBox1.Width = 300;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 625;
            textBox1.Width = 585;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 350;
            textBox1.Width = 300;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                results = 0;
                lblshowup.Text = "";
                equal = false;
            }
            if (!equal)
            {
                if ((textBox1.Text == "0") || (enter_value))
                    textBox1.Text = "";
                enter_value = false;

                Button num = (Button)sender;
                if (num.Text == ".")
                {
                    if (!textBox1.Text.Contains("."))
                        textBox1.Text = textBox1.Text + num.Text;
                }
                else
                    textBox1.Text = textBox1.Text + num.Text;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            results = 0;
            lblshowup.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void Aritmathmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (results != 0)
            {
                equal_btn.PerformClick();
                operation = num.Text;
                lblshowup.Text = System.Convert.ToString(results) + " " + operation;
                enter_value = true; 
            }
            else
            {
                try
                {
                    operation = num.Text;
                    results = Double.Parse(textBox1.Text);
                    lblshowup.Text = System.Convert.ToString(results) + " " + operation;
                    enter_value = true;
                }
                catch
                {
                    textBox1.Text = "Big Error";
                }
            
            }
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            lblshowup.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "x":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(textBox1.Text) == 0)
                    {
                        textBox1.Text = "Cannot divide by zero";
                        return;
                    }
                    else
                        textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
                default:
                    break;
            }
            results = Double.Parse(textBox1.Text);
            lblshowup.Text = "";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = System.Convert.ToString(System.Convert.ToDouble(textBox1.Text) * 3.141592653589976323);
        }
        private void btnLog_Click_1(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            lblshowup.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double isqrt = Double.Parse(textBox1.Text);
                lblshowup.Text = System.Convert.ToString("sqrt" + "(" + (textBox1.Text) + ")");
                isqrt = Math.Sqrt(isqrt);
                textBox1.Text = System.Convert.ToString(isqrt);
            }
            catch
            {
                textBox1.Text = "Error! Try otherwise.";
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double isin = Double.Parse(textBox1.Text);
            lblshowup.Text = System.Convert.ToString("sin" + "(" + (textBox1.Text) + ")");
            isin = Math.Sin(isin);
            textBox1.Text = System.Convert.ToString(isin);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double icos = Double.Parse(textBox1.Text);
            lblshowup.Text = System.Convert.ToString("cos" + "(" + (textBox1.Text) + ")");
            icos = Math.Cos(icos);
            textBox1.Text = System.Convert.ToString(icos);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double itan = Double.Parse(textBox1.Text);
            lblshowup.Text = System.Convert.ToString("tan" + "(" + (textBox1.Text) + ")");
            itan = Math.Tan(itan);
            textBox1.Text = System.Convert.ToString(itan);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                textBox1.Text = System.Convert.ToString(a, 2);
            }
            catch 
            {
                textBox1.Text = "Cannot convert to Binar";
            }
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                textBox1.Text = System.Convert.ToString(a, 16);
            }
            catch
            {
                textBox1.Text = "Cannot convert to Hexazecimal";
            }
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                textBox1.Text = System.Convert.ToString(a, 8);
            }
            catch
            {
                textBox1.Text = "Cannot convert to Octal";
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                textBox1.Text = System.Convert.ToString(a);
            }
            catch
            {
                textBox1.Text = "Cannot convert to Decimal";
            }
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btn1div_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btnLnx_Click(object sender, EventArgs e)
        {
            try
            {
                double ilog = Double.Parse(textBox1.Text);
                lblshowup.Text = System.Convert.ToString("ln" + "(" + (textBox1.Text) + ")");
                ilog = Math.Log(ilog);
                textBox1.Text = System.Convert.ToString(ilog);
            }
            catch
            {
                textBox1.Text = "Error! Try otherwise.";
            }
        }

        private void BtnPrs_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if ((Double.Parse(textBox1.Text) <= 25) && (Double.Parse(textBox1.Text) >=0))
            {
                try
                {
                int i, number;
                long fact = 1;
                number = int.Parse(textBox1.Text);
                lblshowup.Text = System.Convert.ToString( (textBox1.Text) + "!");
                for (i=1; i<=number; i++)
                {
                    fact = fact * i;
                }
                textBox1.Text = System.Convert.ToString(fact);
                }
                catch
                {
                    textBox1.Text = "Error! Try otherwise.";
                }
            }
            else
            {
                textBox1.Text = "Error! Try otherwise.";
            }   
        }

        //Memory save
        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(textBox1.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
        }

        //Memory read
        private void btnMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
        }

        //Memory clear
        private void btnMC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            memory = 0;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }
        
        private void btnMplus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(textBox1.Text);
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(textBox1.Text);
        }

        private void ChangeSign(object sender, EventArgs e)
        {
                textBox1.Text = (double.Parse(textBox1.Text) * -1).ToString();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void equal2_btn(object sender, MouseEventArgs e)
        {
            equal = true;
        }
    }
}
