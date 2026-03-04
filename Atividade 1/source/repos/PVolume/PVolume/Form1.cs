using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        double raio, altura, volume;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRaio.Text, out raio) ||
                (raio <= 0))
            {
                MessageBox.Show("Raio inválido");
                txtRaio.Focus();
            }
            else if (double.TryParse(txtAltura.Text, out altura) ||
                (altura <= 0))
            {
                MessageBox.Show("altura inválida");
                txtAltura.Focus();  
            }
            else volume=Math.PI * Math.Pow (raio, 2) * altura;
            txtVolume.Text = volume.ToString("N2");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtVolume.Clear();
            txtAltura.Text = string.Empty;
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            if (double.TryParse(txtRaio.Text, out raio) ||
                (raio <= 0))
            {
                MessageBox.Show("Raio inválido");
            }
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if (double.TryParse(txtAltura.Text, out altura) ||
                (altura <= 0))
            {
                MessageBox.Show("altura inválida");

            }
        }

    }
}
