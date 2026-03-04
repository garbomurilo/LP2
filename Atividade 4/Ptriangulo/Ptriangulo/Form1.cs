using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulo
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;

        private void txtB_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtB.Text, out ladoB) || (txtB.Text == "0") || (txtB.Text == ""))
            {
                MessageBox.Show("Lado B inválido");
                txtB.Focus();
            }
        }

        private void txtC_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtC.Text, out ladoC) || (txtC.Text == "0") || (txtC.Text == ""))
            {
                MessageBox.Show("Lado C inválido");
                txtC.Focus();
            }
        }

        private void txtA_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out ladoA) || (txtA.Text == "0") || (txtA.Text == ""))
            {
                MessageBox.Show("Lado A inválido");
                txtA.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if ((Math.Abs(ladoB - ladoC) < ladoA) & (ladoA < ladoB + ladoC))
            {
                if ((Math.Abs(ladoA - ladoC) < ladoB) & (ladoB < ladoA + ladoC))
                {
                    if ((Math.Abs(ladoA - ladoB) < ladoC) & ladoC < (ladoB + ladoA))
                    {
                        if ((ladoA == ladoC) && (ladoB == ladoC))
                        
                            MessageBox.Show("Tipo de triangulo: Equilatero");

                        
                        else if ((ladoA == ladoB) | (ladoA == ladoC) | (ladoB == ladoC))
                        
                            MessageBox.Show("Tipo de triangulo: Isosceles");
                        
                        else

                            MessageBox.Show("Tipo de triangulo: Escaleno");
                    }
                    else
                        MessageBox.Show("Lado C invalido");
                }
                else
                    MessageBox.Show("Lado B invalido");
            }
            else
                MessageBox.Show("Lado A invalido");
        }

    }

}
