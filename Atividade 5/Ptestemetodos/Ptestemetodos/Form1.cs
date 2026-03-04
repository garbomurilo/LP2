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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Executou o copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Executou o colar");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                Application.OpenForms["frmExercio2"].BringToFront();
            }
            else
            {
                frmExercicio2 obj2 = new frmExercicio2();
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Minimized;
                obj2.Show();
            }
        }

        private void exercícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                Application.OpenForms["frmExercio3"].BringToFront();
            }
            else
            {
                frmExercicio3 obj3 = new frmExercicio3();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Minimized;
                obj3.Show();
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercio4"].BringToFront();
            }
            else
            {
                frmExercicio4 obj4 = new frmExercicio4();
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Minimized;
                obj4.Show();
            }
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                Application.OpenForms["frmExercio5"].BringToFront();
            }
            else
            {
                frmExercicio5 obj5 = new frmExercicio5();
                obj5.MdiParent = this;
                obj5.WindowState = FormWindowState.Minimized;
                obj5.Show();
            }
        }
    }
}
