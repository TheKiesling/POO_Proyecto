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
        public FormRetirar(Hospital hospital)
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
            //Numero de afiliacion
            String numero_afiliacion = textBox1.Text;

            if (numero_afiliacion != ""){
                Boolean retiro = hospital.retirar_paciente(numero_afiliacion);

                if (retiro == true)
                {
                    //Retiro de paciente exitoso
                    retiroExitoso("Ha podido retirar de manera correcta");
                    MessageBox.Show("Se ha retirado al paciente: "+numero_afiliacion);
                    this.Close();//cerrar este form
                }
                else
                {
                    //En caso de retiro de paciente no exitoso
                    MessageBox.Show("El paciente: " + numero_afiliacion + ", no esta registrado en el sistema.");
                }
            }
            else
            {
                //En caso de que no se haya ingresado un numero de afiliacion
                retiroExitoso("Por favor ingrese un numero de afiliacion.");
                MessageBox.Show("Por favor ingrese un numero de afiliacion.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//cerrar este form
        }
    }
}
