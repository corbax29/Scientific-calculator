using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Advanced_calculator
{
    public partial class lblDisplay : Form
    {
        public bool inputstatus;
        public bool commaCounter = false;
        public string no1, constfun;
        public int powPower, powSolution;
        public int txtBoxLenght;
        public string logBase;
        public bool stateDeg;
        public lblDisplay()
        {
            InitializeComponent();
            no1 = "";
            textBox1.ReadOnly = true;

        }

        //rad deg
        private void rbtnDeg_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnDeg.Checked == true)
            {
                stateDeg = true;
            }
            else
            {
                stateDeg = false;
            }
        }

        //num pad
        #region value input
        private void lblNum0_Click(object sender, EventArgs e)
        {
            if(inputstatus == true)
            {
                textBox1.Text += lblNum0.Text;
            }
            else
            {
                textBox1.Text = lblNum0.Text;
                inputstatus = true;
            }
           
        }
        private void lblNum1_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += lblNum1.Text;
            }
            else
            {
                textBox1.Text = lblNum1.Text;
                inputstatus = true;
            }
        }

        private void lblNum2_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += lblNum2.Text;
            }
            else
            {
                textBox1.Text = lblNum2.Text;
                inputstatus = true;
            }
        }

        private void lblNum3_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += lblNum3.Text;
            }
            else
            {
                textBox1.Text = lblNum3.Text;
                inputstatus = true;
            }
        }

        private void lblNum4_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += lblNum4.Text;
            }
            else
            {
                textBox1.Text = lblNum4.Text;
                inputstatus = true;
            }
        }

        private void lblNum5_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += lblNum5.Text;
            }
            else
            {
                textBox1.Text = lblNum5.Text;
                inputstatus = true;
            }
        }

        private void lblNum6_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += lblNum6.Text;
            }
            else
            {
                textBox1.Text = lblNum6.Text;
                inputstatus = true;
            }
        }

        private void lblNum7_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += lblNum7.Text;
            }
            else
            {
                textBox1.Text = lblNum7.Text;
                inputstatus = true;
            }
        }

        private void lblNum8_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += lblNum8.Text;
            }
            else
            {
                textBox1.Text = lblNum8.Text;
                inputstatus = true;
            }
        }

        private void lblNum9_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += lblNum9.Text;
            }
            else
            {
                textBox1.Text = lblNum9.Text;
                inputstatus = true;
            }
        }

        private void lblComma_Click(object sender, EventArgs e)
        {
            if (inputstatus == true && commaCounter == false)
            {
                textBox1.Text += lblComma.Text;
                commaCounter = true;
            }
        }

        #endregion input value
        // add operator
        private void lblPlus_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "+";
        }


        //sub operator
        private void lblMinus_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "-";
        }

        //multily operator
        private void lblMultiply_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "*";
        }

        //divide operator
        private void lblDivide_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "/";
        }

        //pow
        private void btnPow_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "pow";
            funcal();
        }

        //sqrt
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "sqrt";
            funcal();
        }
        //powX
        private void btnPowX_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "powX";
        }

        //sin
        private void btnSin_Click(object sender, EventArgs e)
        {
            if(rbtnRad.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        //cos
        private void btnCos_Click(object sender, EventArgs e)
        {
            if (rbtnRad.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        //tan
        private void btnTan_Click(object sender, EventArgs e)
        {
            if (rbtnRad.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        //clr
        private void btnAC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        //del
        private void btnDEL_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

        }

        //log
        private void btnLog_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "log";
            funcal();
        }

        //ln
        private void btnLn_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "ln";
            funcal();
        }
        //logxy
        private void button23_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "logxy";

        }

        //x^-1
        private void btnInvers_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "inv";
            funcal();
        }

        public void lblEqual_Click(object sender, EventArgs e)
        {
            funcal();
            inputstatus = false;
        }

        private void funcal()
        {
            switch (constfun)
            {
                case "+":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) + Convert.ToInt32(textBox1.Text));
                    break;

                case "-":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) + Convert.ToInt32(textBox1.Text));
                    break;

                case "*":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) * Convert.ToInt32(textBox1.Text));
                    break;

                case "/":
                    if(textBox1.Text == "0")
                    {
                        textBox1.Text = "Infinity";
                    } 
                    else 
                    {
                        textBox1.Text = Convert.ToString(Convert.ToInt32(no1) / Convert.ToInt32(textBox1.Text));
                    }
                    break;

                case "pow":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(no1) * Convert.ToInt32(no1));
                    break;

                case "powX":
                    textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(no1), Convert.ToInt32(textBox1.Text)));

                    break;

                case "sqrt":
                    textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(no1)));
                    break;

                case "log":
                    textBox1.Text = Convert.ToString(Math.Log10(Convert.ToInt32(no1)));
                    break;

                case "ln":
                    textBox1.Text = Convert.ToString(Math.Log(Convert.ToDouble(no1)));
                    break;

                case "logxy":
                    textBox1.Text = Convert.ToString(Math.Log(Convert.ToDouble(no1),Convert.ToDouble(textBox1.Text)));
                    break;

                case "inv":
                    textBox1.Text =Convert.ToString(1 / Convert.ToDouble(no1));
                    break;
            }
        }
    }
}
