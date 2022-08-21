using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + 5;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
            lblResult.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + 4;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + 9;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
            //valiadando operacao

            if(operacao == "SOMA")
            {
                textResult.Text = Convert.ToString( valor1 + valor2);
            }
            else if(operacao == "SUB"){
                textResult.Text = Convert.ToString(valor1 - valor2);
            } 
            else if (operacao == "DIV")
            {
                textResult.Text = Convert.ToString(valor1 / valor2);
            } 
            else 
            {
                textResult.Text = Convert.ToString(valor1 * valor2);
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + 0;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
            textResult.Text = "";
            operacao = "SOMA";
            lblResult.Text = "+";
        }

        private void Calculadora_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + ".";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
            textResult.Text = "";
            operacao = "MULT";
            lblResult.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
            textResult.Text = "";
            operacao = "DIV";
            lblResult.Text = "/";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
            textResult.Text = "";
            operacao = "SUB";
            lblResult.Text = "-";
        }
    }
}
