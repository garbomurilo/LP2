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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            double num1;
            double num2; 

            if(!Double.TryParse(txtNumero1.Text, out num1) || !Double.TryParse(txtNumero2.Text, out num2) || (num2 <= num1))
            {
                MessageBox.Show("Número Inválido");
                txtNumero1.Focus();
            }
            else
            {
                 Random Obj5 = new Random();
                 int x = Obj5.Next((int) num1,(int) num2);
                MessageBox.Show($"Número {x} sorteado");
            }
        }
    }
}
