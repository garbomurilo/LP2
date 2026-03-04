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
    public partial class frmExercicio2 : Form
    {
        Double numeroN;

        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void txtNumeroN_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumeroN.Text, out numeroN) || ((int)numeroN == 0))
            {
                MessageBox.Show("Número inválido");
                txtNumeroN.Clear();
                txtNumeroN.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           double valorH = 0;

            for (double n = 1; n <= numeroN; n++)
                valorH += 1 / n;

            txtNumeroH.Text = valorH.ToString();
            txtNumeroN.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumeroN.Clear();
            txtNumeroH.Clear();

            txtNumeroN.Focus();
        }
    }
}
