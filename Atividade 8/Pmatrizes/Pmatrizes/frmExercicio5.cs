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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string[,] alunos = new string[6, 10];
            string[] gabarito = { "B", "B", "C", "D", "E", "A", "C", "D", "A", "E" };
            string[] auxiliarEscolha = new string[10];

            for (int aluno = 0; aluno < 6; aluno++)
                for (int escolha = 0; escolha < 10; escolha++)
                {
                    auxiliarEscolha[escolha] = Interaction.InputBox($"Digite a {escolha + 1}º alternativa do {aluno + 1}º aluno", "Entrada de dados");

                    if (auxiliarEscolha[escolha] == "")
                        break;
                                     
                    string resposta = auxiliarEscolha[escolha].ToUpper();
                    alunos[aluno, escolha] = resposta;

                    if (resposta == gabarito[escolha])
                        { 
                            lstbxAlunos.Items.Add($"Aluno {aluno + 1} acertou a questão {escolha + 1}. Era a {gabarito[escolha]} e assinalou {auxiliarEscolha[escolha]}");
                        }
                        else
                            lstbxAlunos.Items.Add($"Aluno {aluno + 1} errou a questão {escolha + 1}. Era a {gabarito[escolha]} e assinalou {auxiliarEscolha[escolha]}");
                    }
                }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstbxAlunos.Items.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
                     