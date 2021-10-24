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
    public partial class FormModificarSesion : Form
    {
        Hospital hospital;
        SQL.Connection connection;
        public FormModificarSesion(Hospital hospital, SQL.Connection connection)
        {
            InitializeComponent();
            this.hospital = hospital;
            this.connection = connection;
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

        //Modificacion de sesion
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string usuario2 = textBox4.Text;
            string contraseña2 = textBox3.Text;

            //Falta de datos de sesion anterior
            if (usuario == "" || contraseña == "")
            {
                inicioExitoso("Por favor llenar todos los datos de su sesion anterior");
            }
            //Falta de datos de sesion nuevo
            else if (usuario2 == "" || contraseña2 == "")
            {
                inicioExitoso("Por favor llenar todos los datos de su sesion nueva");
            }
            //Datos completos
            else
            {
                Usuario user = null;
                //Verificacion Admin
                if (contraseña == "123POO" && usuario == "ADMIN")
                {
                    //Cambio Admin
                    user = new Usuario_admin(usuario2, contraseña2, "admin");
                    FormMain m = new FormMain(hospital, user,connection);
                    m.Show();//mostrar el form del menú
                    this.Close();//cerrar este form
                }
                else if (contraseña != "123POO" && usuario == "ADMIN")
                {
                    inicioExitoso("Datos de sesion no registrados");
                }
                //Cambio Usuario
                else
                {
                    user = new Usuario_paciente(usuario2, contraseña2, "paciente");
                    FormMain m = new FormMain(hospital, user, connection);
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
