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
    public partial class FormBuscar : Form
    {
        Hospital hospital;
        public FormBuscar(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] datos = hospital.buscar_paciente(textBox8.Text);
            textBox1.Text = datos[0];
            textBox2.Text = datos[1];
            textBox3.Text = datos[2];
            textBox4.Text = datos[3];
            textBox5.Text = datos[4];
            textBox7.Text = datos[5];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            this.Close();//cerrar este form
        }
    }
}
