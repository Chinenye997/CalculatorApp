using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double enterfirstvalue, entersecondvalue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        // This line should take care of the numeric (all the numbers)
        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = " ";
            {
                if (num.Text == "0")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        double checker;

        // This line should take care of the operators
        private void numberOptr(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (double.TryParse(txtResult.Text, out checker))
            {
                enterfirstvalue = Convert.ToDouble(txtResult.Text);
            }
            op = num.Text;
            txtResult.Text = "";
        }



        // also for the operators
        private void btnEquel_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out checker))
            {
                entersecondvalue = Convert.ToDouble(txtResult.Text);
            }
            else
            {
                txtResult.Text = enterfirstvalue.ToString();
                return;
            }

            switch (op)
            {
                case "+":
                    txtResult.Text = (enterfirstvalue + entersecondvalue).ToString();
                    break;


                case "-":
                    txtResult.Text = (enterfirstvalue - entersecondvalue).ToString();
                    break;



                case "*":
                    txtResult.Text = (enterfirstvalue * entersecondvalue).ToString();
                    break;



                case "/":
                    txtResult.Text = (enterfirstvalue / entersecondvalue).ToString();
                    break;

                case "Mod":
                    txtResult.Text = (enterfirstvalue / entersecondvalue).ToString();
                    break;

                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j;
                    j = entersecondvalue;
                    txtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;

                default:
                    break;



            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        // this take care of CE butten (clear butten)
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            string f, s;

            f = Convert.ToString(enterfirstvalue);
            s = Convert.ToString(entersecondvalue);

            f = "";
            s = "";
        }


        // this should tate care of the +- sign
        private void PM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        // This should take care the backspace BS
        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0"; // IT take care of the zero reture after using BS 
            }
        }
          // This take care of the size of the form and answer display
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 320; //868
            txtResult.Width = 288;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 630; //868
            txtResult.Width = 595;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("comfirm if you want exit", "Scientific Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void btnSq_Click(object sender, EventArgs e)
        {
            double Sq = Convert.ToDouble(txtResult.Text);
            Sq = Math.Sqrt(Sq);
            txtResult.Text = Convert.ToString(Sq);
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            double x, q, p, m;

            q = Convert.ToDouble(txtResult.Text);
            p = Convert.ToDouble(txtResult.Text);
            m = Convert.ToDouble(txtResult.Text);

            x = (q * p * m);
           
            txtResult.Text = Convert.ToString(x);
        }

       
        private void btnSinh_Click(object sender, EventArgs e)
        {
            double Sh = Convert.ToDouble(txtResult.Text);
            Sh = Math.Sinh(Sh);
            txtResult.Text = Convert.ToString(Sh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {

            double Sin = Convert.ToDouble(txtResult.Text);
            Sin = Math.Sin(Sin);
            txtResult.Text = Convert.ToString(Sin);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {

            double Cosh = Convert.ToDouble(txtResult.Text);
            Cosh = Math.Cosh(Cosh);
            txtResult.Text = Convert.ToString(Cosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {

            double Cos = Convert.ToDouble(txtResult.Text);
            Cos = Math.Cos(Cos);
            txtResult.Text = Convert.ToString(Cos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {

            double Tanh = Convert.ToDouble(txtResult.Text);
            Tanh = Math.Tanh(Tanh);
            txtResult.Text = Convert.ToString(Tanh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {

            double Tan = Convert.ToDouble(txtResult.Text);
            Tan = Math.Tan(Tan);
            txtResult.Text = Convert.ToString(Tan);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(0.1 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = Convert.ToString(a);
        }

        private void btnInx_Click(object sender, EventArgs e)
        {
            double Inx = Convert.ToDouble(txtResult.Text);
            Inx = Math.Log(Inx);
            txtResult.Text = Convert.ToString(Inx);
        }

        private void Pre_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = Convert.ToString(a);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void Oct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Width = 320; //868
            txtResult.Width = 288;
        }



    }
}
