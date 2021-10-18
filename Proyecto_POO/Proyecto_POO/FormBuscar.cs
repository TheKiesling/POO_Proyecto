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
            if (textBox8.Text == "")
            {
                string[] datos = hospital.buscar_paciente(textBox8.Text);
                textBox1.Text = datos[0];
                textBox2.Text = datos[1];
                textBox3.Text = datos[2];
                textBox4.Text = datos[3];
                textBox5.Text = datos[4];
                textBox7.Text = datos[5];
                textBox6.Text = datos[6];
                if (datos.Contains<string>("")||textBox1.Text=="")
                {
                    MessageBox.Show("No se ha podido encontrar");
                }
                else
                {
                    MessageBox.Show("Se ha podido encontrar al paciente correctamente");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero de afiliacion.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//cerrar este form
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
