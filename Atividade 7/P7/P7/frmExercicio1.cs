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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            int qtdeEspaco = 0;

            for (int i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[i]))
                    qtdeEspaco += 1;
            }

            if (qtdeEspaco > 0)
                MessageBox.Show($"A frase tem {qtdeEspaco} espaço(s) em branco.");
            else
                MessageBox.Show("A frase não tem nenhum espaço em branco.");
        }

        private void btnNumeroR_Click(object sender, EventArgs e)
        {
            int qtdeR = 0;
            char[] letrasR = rchtxtFrase.Text.ToCharArray();

            foreach (char i in letrasR)
                if((i == 'R') || (i == 'r'))
                    qtdeR += 1;

            if(qtdeR > 0)
                MessageBox.Show($"A frase tem {qtdeR} letra(s) R.");
            else
                MessageBox.Show("A frase não tem nenhuma letra R.");
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int i = 0;
            int qtdePares = 0;

            while (i < rchtxtFrase.Text.Length)
            {
                if ((char.IsLetter(rchtxtFrase.Text[i])) && (i != rchtxtFrase.Text.Length - 1) && (rchtxtFrase.Text[i] == rchtxtFrase.Text[i + 1])) 
                    qtdePares += 1;

                i++;
            }


            if(qtdePares > 0)
                MessageBox.Show($"A frase tem {qtdePares} Par(es) de letras.");
            else
                MessageBox.Show("A frase não tem nenhum par de letras.");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rchtxtFrase.Clear();
            rchtxtFrase.Focus();
        }
    }
}
