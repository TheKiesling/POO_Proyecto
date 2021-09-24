using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso f = new Ingreso();
            f.Show();//mostrar form de ingreso
            this.Hide();//ocultar este form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRetirar f = new FormRetirar();
            f.Show();//mostrar form de retiro
            this.Hide();//ocultar este form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormModificar f = new FormModificar();
            f.Show();//mostrar form de modificacion
            this.Hide();//ocultar este form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBuscar f = new FormBuscar();
            f.Show();//mostrar form de buscar
            this.Hide();//ocultar este form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTraslado f = new FormTraslado();
            f.Show(); //mostrar form de traslado
            this.Hide();//ocultar este form
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
