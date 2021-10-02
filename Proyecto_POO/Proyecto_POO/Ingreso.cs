﻿using System;
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
    public partial class Ingreso : Form
    {
        Paciente paciente;
        Hospital hospital;
        public Ingreso(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            paciente = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("si se pudio");
                FormMain f = new FormMain();
                this.Close();//cerrar este form
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
            FormMain f = new FormMain();
            this.Close();//cerrar este form
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
