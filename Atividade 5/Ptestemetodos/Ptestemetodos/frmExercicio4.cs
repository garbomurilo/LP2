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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int contNum = 0;

            while (contador < rchtxtFrase.Text.Length)
            {
                if (char.IsNumber(rchtxtFrase.Text[contador]))
                {
                  contNum++;
                }
                contador++;
            }

            MessageBox.Show($"Tem {contNum} números");
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            int contLetra = 0;
            char[] letras = rchtxtFrase.Text.ToCharArray();

            foreach (char c in letras)
                if (char.IsLetter(c))
                {
                    contLetra++;
                }
           MessageBox.Show($"Tem {contLetra} letras");
        }

        private void btnPosicao_Click(object sender, EventArgs e)
        {
            int contEspaco = 0;
            int espacoTotal = 0;

          for (int contador = 0; contador < rchtxtFrase.Text.Length; contador++ )
            {
                if (Char.IsWhiteSpace(rchtxtFrase.Text[contador]))
                {
                    contEspaco = contador;
                    espacoTotal++;
                    break;
                }
            }

          if (espacoTotal > 0)
              MessageBox.Show($"O 1° caracter branco é {contEspaco}");
          else
              MessageBox.Show("Não tem nenhum caracter branco");
        }
    }
}
