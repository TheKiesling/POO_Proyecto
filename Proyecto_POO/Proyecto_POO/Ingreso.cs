using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Proyecto_POO
{
    public partial class Ingreso : Form
    {
        Paciente paciente;
        Hospital hospital;
        Usuario user;
        public Ingreso(Hospital hospital, Usuario user)
        {
            InitializeComponent();
            this.hospital = hospital;
            paciente = null;
            this.user = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ingresoExitoso(String s)
        {
            MessageBox.Show(s);
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
                if (user.ingresarPaciente())
                {
                    paciente = new Paciente(nombre, fecha_nacimiento, sexo, dpi, enfermedad, numero_afiliacion, tipo_afiliacion);
                    hospital.asignarPaciente(paciente);
                    ingresoExitoso("Ha podido ingresar de manera correcta");
                    this.Close();//cerrar este form
                }
                else {
                    ingresoExitoso("No tiene suficientes permisos para ingresar a un paciente");
                }
            }
            else
            {
                ingresoExitoso("Por favor llene todos los datos");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//cerrar este form
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox2.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
