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
    public partial class FormModificarSesion : Form
    {
        Hospital hospital;
        public FormModificarSesion(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
        }

        string nombre, contraseña;
        public string obtenernombre()
        {
            return nombre;
        }

        private void inicioExitoso(String s)
        {
            MessageBox.Show(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string usuario2 = textBox4.Text;
            string contraseña2 = textBox3.Text;

            if (usuario == "" || contraseña == "" ||  usuario2 == "" || contraseña2 == "")
            {
                inicioExitoso("Por favor llenar todos los datos");
            }
            else if (usuario == "" || contraseña == "")
            {
                inicioExitoso("Por favor llenar todos los datos de su sesion anterior");
            }
            else if (usuario2 == "" || contraseña2 == "")
            {
                inicioExitoso("Por favor llenar todos los datos de su sesion nueva");
            }
            else
            {
                Usuario user = null;
                if (contraseña == "123POO" && usuario == "ADMIN")
                {
                    user = new Usuario_admin(usuario2, contraseña2, "admin");
                    FormMain m = new FormMain(hospital, user);
                    m.Show();//mostrar el form del menú
                    this.Close();//cerrar este form
                }
                else if (contraseña != "123POO" && usuario == "ADMIN")
                {
                    inicioExitoso("Datos de sesion no registrados");
                }
                else
                {
                    user = new Usuario_paciente(usuario2, contraseña2, "paciente");
                    FormMain m = new FormMain(hospital, user);
                    m.Show();//mostrar el form del menú
                    this.Close();//cerrar este form
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicioSesion IS = new FormInicioSesion(hospital);
            IS.Show();//mostrar el form del menú
            this.Close();//cerrar este form
        }
    }
}
