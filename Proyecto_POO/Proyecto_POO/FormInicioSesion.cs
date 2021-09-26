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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicio I = new FormInicio();
            I.Show();//mostrar el form del menú
            this.Close();//cerrar este form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain m = new FormMain();
            m.Show();//mostrar el form del menú
            this.Close();//cerrar este form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormModificarSesion MS = new FormModificarSesion();
            MS.Show();//mostrar el form del menú
            this.Hide();//cerrar este form
        }
    }
}
