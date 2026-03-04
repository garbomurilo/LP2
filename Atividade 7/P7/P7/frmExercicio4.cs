using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7
{
    public partial class frmExercicio4 : Form
    {
        double nome, matricula, producao, salario, gratificacao, salarioBruto;

        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNome.Text, out nome))
            {
                MessageBox.Show("Nome inválido");
                txtNome.Clear();
                txtNome.Focus();
            }
        }

        private void txtMatricula_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtMatricula.Text, out matricula))
            {
                MessageBox.Show("Matrícula inválida");
                txtMatricula.Clear();
                txtMatricula.Focus();
            }
        }

        private void txtProducao_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtProducao.Text, out producao))
            {
                MessageBox.Show("Valor da produção inválida");
                txtProducao.Clear();
                txtProducao.Focus();
            }
        }

        private void mskdSalario_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mskdSalario.Text, out salario))
            {
                MessageBox.Show("Salário inválido");
                mskdSalario.Clear();
                mskdSalario.Focus();
            }
        }

        private void mskdGratificacao_Validated(object sender, EventArgs e)
        {
            if ((!Double.TryParse(mskdGratificacao.Text, out gratificacao) && (mskdGratificacao.Text == "")))
            {
                MessageBox.Show("Valor da gratificação inválida");
                mskdGratificacao.Clear();
                mskdGratificacao.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double b = 0, c = 0, d = 0;

                if (producao >= 100 && producao < 120 && salario <= 7000.00)
                    b = 1;
                else
                    if (producao >= 120 && producao < 150 && salario <= 7000.00)
                    {
                        b = 1;
                        c = 1;
                    }
                    else
                        if ((producao >= 150 && salario <= 7000.00) || (producao >= 150 && salario > 7000.00 && gratificacao > 0))
                        {
                            b = 1;
                            c = 1;
                            d = 1;
                        }
        
            if ((b == 1) || ((producao < 100) && (salario <= 7000.00)))
            {
                salarioBruto = salario + (salario * (0.05 * b + 0.1 * c + 0.1 * d)) + gratificacao;
                mskdSalarioBruto.Text = salarioBruto.ToString("N2");
            }
            else
                MessageBox.Show("Não foi possível calcular o salário bruto.");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMatricula.Clear();
            txtProducao.Clear();
            mskdSalario.Clear();
            mskdGratificacao.Clear();
            mskdSalarioBruto.Clear();

            txtNome.Focus();

        }

        //private void txtSalario_Validated(object sender, EventArgs e)

    }
}

