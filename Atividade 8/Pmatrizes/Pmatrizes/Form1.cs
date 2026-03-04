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
using System.Collections;
using System.Drawing.Drawing2D;
using System.Net.Http.Headers;

namespace Pmatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox($"Digite o {i + 1}º número", "Entrada de dados");

                if (auxiliar == "") //se clicar em cancelar
                {
                    break;
                }

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }
            }
            Array.Reverse(vetor);//inverte os dados
            auxiliar = "";
            foreach (int j in vetor)
            {
                auxiliar += j + "\n";

                //ou
                //for (int j = 19; i>=0; i--)
                //auxiliar += vetor[j] + "\n";
            }
            MessageBox.Show(auxiliar);
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList() { "Ana", "André", "Beatriz", "Camila", "João", "Joana", "Otávio", "Marcelo", "Pedro", "Thaís" };

            lista.Remove("Otávio");

            string resultado = string.Join("\n", lista.ToArray());

            MessageBox.Show(resultado);

        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[20, 3];
            double[] media = new double[20];
            string auxiliar = "";

            for (int aluno = 0; aluno < 20; aluno++)
                for (int nota = 0; nota < 3; nota++)
                {
                    auxiliar = Interaction.InputBox($"Digite a {nota + 1}º nota do aluno {aluno + 1}", "Notas dos alunos");

                    if (auxiliar == "")
                    {
                        break;
                    }

                    if (!Double.TryParse(auxiliar, out matriz[aluno, nota]) || (matriz[aluno, nota] < 0) || (matriz[aluno, nota] > 10))
                    {
                        MessageBox.Show("Valor inválido!");
                        nota--;
                    }
                    else
                    {
                        media[aluno] += matriz[aluno, nota];
                    }
                }

            for (int aluno = 0; aluno < 20; aluno++)
            {
                media[aluno] = media[aluno] / 3;
                MessageBox.Show($"Aluno {aluno + 1} Média: {media[aluno]:N2}");
            }

        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront();
            }
            else
            {
                frmExercicio4 obj1 = new frmExercicio4();
                obj1.Show();
            }
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                Application.OpenForms["frmExercicio5"].BringToFront();
            }
            else
            {
                frmExercicio5 obj2 = new frmExercicio5();
                obj2.Show();
            }

        }
    }
}

