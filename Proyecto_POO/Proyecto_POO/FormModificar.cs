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
    public partial class FormModificar : Form
    {
        Hospital hospital;
        Paciente paciente;
        public FormModificar()
        {
            InitializeComponent();
            hospital = new Hospital();
            paciente = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            this.Close();//cerrar este form
        }

        public String ingresoExitoso(String s)
        {
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String fecha_nacimiento = textBox2.Text;
            String sexo = textBox3.Text;
            String dpi = textBox4.Text;
            String enfermedad = textBox5.Text;
            String numero_afiliacion = textBox6.Text;
            String tipo_afiliacion = textBox7.Text;
            if (nombre != "" || fecha_nacimiento != "" || sexo != "" || dpi != "" || enfermedad != "" || numero_afiliacion != "" || tipo_afiliacion != "")
            {
                paciente = new Paciente(nombre, fecha_nacimiento, sexo, dpi, enfermedad, numero_afiliacion, tipo_afiliacion);
                hospital.asignarPaciente(paciente);
                ingresoExitoso("Ha podido ingresar de manera correcta");
            }
            else
            {
                ingresoExitoso("Por favor llene todos los datos");
            }
        }
    }
}
