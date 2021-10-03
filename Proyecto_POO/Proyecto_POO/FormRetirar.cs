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
    public partial class FormRetirar : Form
    {
        Hospital hospital;
        public FormRetirar()
        {
            InitializeComponent();
            this.hospital = hospital;
        }

        public String retiroExitoso(String s)
        {
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String numero_afiliacion = textBox1.Text;

            if (numero_afiliacion != ""){
                Boolean retiro = hospital.retirar_paciente(numero_afiliacion);

                if (retiro == true)
                {
                    retiroExitoso("Ha podido retirar de manera correcta");
                    MessageBox.Show("Se ha retirado al paciente: "+numero_afiliacion);
                    FormMain f = new FormMain();
                    this.Close();//cerrar este form
                }
                else
                {
                    MessageBox.Show("El paciente: " + numero_afiliacion + ", no esta registrado en el sistema.");
                }
            }
            else
            {
                retiroExitoso("Por favor ingrese un numero de afiliacion.");
                MessageBox.Show("Por favor ingrese un numero de afiliacion.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            this.Close();//cerrar este form
        }
    }
}
