using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstanciar1_Click(object sender, EventArgs e)
        {
         //   Empregado objEmpregado = new Empregado(vai dar erro);
         Mensalista objMensalista = new Mensalista();
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);

            MessageBox.Show("Nome = " + objMensalista.NomeEmpregado + "\n" + "Matricula = " + objMensalista.Matricula + "\n" + "Tempo de Trabalho = " + objMensalista.TempoTrabalho() + "\n" + "Salario Final = " + objMensalista.SalarioBruto().ToString("N2"));
        }
    }
}
