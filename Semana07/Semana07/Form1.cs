using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var Calculo = new Semana07.LogicaNegocio.EjemploCalculos();
            var PrimerCalculo = (Semana07.LogicaNegocio.IEjemploCalculos)Calculo;
            tbS1.Text = PrimerCalculo.Show(tbM1.Text);
            var SegundoCalculo = (Semana07.LogicaNegocio.IejemploCalculosDos)Calculo;
            tbS2.Text = SegundoCalculo.Show(tbM2.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
