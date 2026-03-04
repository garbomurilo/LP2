using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PCalc : Form
    {
        double numero1, numero2, resultado;
        public PCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultado = numero1 + numero2;
            TxtResultado.Text = resultado.ToString();
        }

        private void TxtNumero2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(TxtNumero2.Text, out numero2))
            {
                MessageBox.Show("número 2 inválido");
                TxtNumero1.Focus();
            }
        }

        private void BtnSub(object sender, EventArgs e)
        {
            resultado = numero1 - numero2;
            TxtResultado.Text = resultado.ToString();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (numero2 == 0)
            {
                MessageBox.Show("Divisão inválida");
                TxtNumero2.Focus();
            }
            else
                resultado = numero1 / numero2;
            TxtResultado.Text = resultado.ToString();
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            resultado = numero1 * numero2;
            TxtResultado.Text = resultado.ToString();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNumero1.Clear();
            TxtNumero2.Clear();
            TxtResultado.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            resultado = numero1 + numero2;
            TxtResultado.Text = resultado.ToString();
        }

        private void TxtNumero1_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(TxtNumero1.Text, out numero1))
            {
                MessageBox.Show("número 1 inválido");
                TxtNumero1.Focus();
            }
        }
    }
}
