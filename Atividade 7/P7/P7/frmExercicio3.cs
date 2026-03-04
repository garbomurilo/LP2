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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void txtTexto_Validated(object sender, EventArgs e)
        {
            if (txtTexto.Text.Length > 50)
            {
                MessageBox.Show("Não foi possível realizar o teste, o texto é muito grande");
                txtTexto.Clear();
                txtTexto.Focus();
            }
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            int qtdeDiferentes = 0;
            string p = "";

            txtTexto.Text = txtTexto.Text.Replace(" ", "").ToUpper();

            char[] palindromo = txtTexto.Text.ToCharArray();
            Array.Reverse(palindromo);

                for (int i = 0; i < palindromo.Length; i++)
                {
                    p = p + palindromo[i].ToString();
                    if ((palindromo[i] != txtTexto.Text[i]))
                    {
                        qtdeDiferentes += 1;
                    }
                }

            txtTexto2.Text = p;

            if (qtdeDiferentes > 0)
                MessageBox.Show("O texto não é um palíndromio");
            else
                MessageBox.Show("O texto é um palíndromio");

            txtTexto.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            txtTexto2.Clear();

            txtTexto.Focus();
        }
    }
}
