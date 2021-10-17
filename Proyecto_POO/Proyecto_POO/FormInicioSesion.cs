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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }
        string nombre, contraseña;
        public string obtenernombre(){  
            return nombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicio I = new FormInicio();
            I.Show();//mostrar el form del menú
            this.Close();//cerrar este form
        }
        private void inicioExitoso(String s) {
            MessageBox.Show(s);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            if (usuario == "" || contraseña == "")
            {
                inicioExitoso("Por favor llenar todos los datos");
            }
            else
            {
                Usuario user=null;
                if (contraseña == "123POO" && usuario == "ADMIN") {
                    user = new Usuario_admin(usuario, contraseña, "admin");
                    FormMain m = new FormMain(user);
                    m.Show();//mostrar el form del menú
                    this.Close();//cerrar este form
                }
                else if(contraseña != "123POO" && usuario == "ADMIN")
                {
                    inicioExitoso("Contraseña incorrecta");
                }
                else{
                    user = new Usuario_paciente(usuario, contraseña, "paciente");
                    FormMain m = new FormMain(user);
                    m.Show();//mostrar el form del menú
                    this.Close();//cerrar este form
                }
                
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormModificarSesion MS = new FormModificarSesion();
            MS.Show();//mostrar el form del menú
            this.Hide();//cerrar este form
        }
    }
}
