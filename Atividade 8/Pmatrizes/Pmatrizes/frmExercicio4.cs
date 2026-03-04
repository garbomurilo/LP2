using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pmatrizes
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];
            string auxiliar = "";
            
            for (int i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox($"Digite o {i + 1}º nome: ", "Entrada de dados");

                if (auxiliar == "")
                    break;
                else
                {
                    nomes[i] = auxiliar;

                    string nomeSemEspaco = auxiliar.Replace(" ", "");

                    int quantidade = nomeSemEspaco.Length;
                    lstbxNomes.Items.Add($"O nome {auxiliar} tem {quantidade} letras");
                                       
                    }
                }


            }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstbxNomes.Items.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

