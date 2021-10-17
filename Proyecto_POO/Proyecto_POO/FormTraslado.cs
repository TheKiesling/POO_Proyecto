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
    public partial class FormTraslado : Form
    {
        Hospital hospital;
        Usuario user;
        public FormTraslado(Hospital hospital, Usuario user)
        {
            InitializeComponent();
            this.hospital = hospital;
            this.user = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public String trasladoExitoso(String s)
        {
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Numero de afiliacion
            String numero_afiliacion = textBox2.Text;
            String sede = textBox1.Text;

            if (numero_afiliacion != "")
            {
                if (user.trasladoPaciente(numero_afiliacion))
                {
                    Boolean traslado = hospital.trasladoPaciente(numero_afiliacion,sede);
                    if (traslado == true)
                    {
                        //Traslado de paciente exitoso
                        trasladoExitoso("Ha podido retirar de manera correcta");
                        MessageBox.Show("Se ha trasladado al paciente: " + numero_afiliacion);
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
                    trasladoExitoso("No tiene suficientes permisos para retirar al paciente");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//cerrar este form
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
