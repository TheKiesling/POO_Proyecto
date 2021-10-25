﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Proyecto_POO
{
    public partial class FormModificar : Form
    {
        Hospital hospital;
        Paciente paciente;
        Usuario user;
        SQL.Connection connection;

        public FormModificar(Hospital hospital, Usuario user, SQL.Connection connection)
        {
            InitializeComponent();
            this.hospital = hospital;
            paciente = null;
            this.user = user;
            this.connection = connection;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//cerrar este form
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
            String sede = "IGSS";
            Boolean verificacion = false;

            if (nombre != "" || fecha_nacimiento != "" || sexo != "" || dpi != "" || enfermedad != "" || numero_afiliacion != "" || tipo_afiliacion != "")
            {
                verificacion = hospital.recorrerArreglo(numero_afiliacion);

                if (verificacion == false)
                {
                    if (user.ingresarPaciente())
                    {
                        paciente = new Paciente(nombre, fecha_nacimiento, sexo, dpi, enfermedad, numero_afiliacion, tipo_afiliacion, sede);
                        hospital.asignarPaciente(paciente);
                        string query = "INSERT INTO paciente (nombre,tipo_afiliacion,sexo,dpi,enfermedad,fecha_nacimiento,no_afiliacion,sede) VALUES (@nombre,@tipo_afiliacion,@sexo,@dpi,@enfermedad,@fecha_nacimiento,@no_afiliacion,@sede)";
                        MySqlCommand comando = new MySqlCommand(query, connection.Connect());
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@tipo_afiliacion", tipo_afiliacion);
                        comando.Parameters.AddWithValue("@sexo", sexo);
                        comando.Parameters.AddWithValue("@dpi", dpi);
                        comando.Parameters.AddWithValue("@enfermedad", enfermedad);
                        comando.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                        comando.Parameters.AddWithValue("@no_afiliacion", numero_afiliacion);
                        comando.Parameters.AddWithValue("@sede", sede);
                        comando.ExecuteNonQuery();
                        ingresoExitoso("Ha podido ingresar de manera correcta");
                        this.Close();//cerrar este form
                    }
                    else
                    {
                        ingresoExitoso("No tiene suficientes permisos para ingresar a un paciente");
                    }
                }
                else
                {
                    ingresoExitoso("El paciente ya esta registrado en el sistema");
                }
            }
            else
            {
                ingresoExitoso("Por favor llene todos los datos");
            }
        }

        private void button6_Click(object sender, EventArgs e)
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
                if (datos.Contains<string>("") || textBox1.Text == "")
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
    }
}
