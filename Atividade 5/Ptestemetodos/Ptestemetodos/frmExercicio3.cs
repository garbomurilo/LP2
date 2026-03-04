using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            char[] vetor = txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor);

            txtPalavra2.Text = "";

            foreach (char c in vetor)
            {
                txtPalavra2.Text += c;
            }
        }
    }
}
