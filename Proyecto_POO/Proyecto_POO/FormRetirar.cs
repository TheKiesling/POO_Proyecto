using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_POO
{
    public partial class FormRetirar : Form
    {
        Hospital hospital;
        Usuario user;
        SQL.Connection connection;
        public FormRetirar(Hospital hospital, Usuario user, SQL.Connection connection)
        {
            InitializeComponent();
            this.hospital = hospital;
            this.user = user;
            this.connection = connection;
        }

        public void retiroExitoso(String s)
        {
            MessageBox.Show(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Numero de afiliacion
            String numero_afiliacion = textBox1.Text;

            if (numero_afiliacion != ""){
                if (user.darAltaPaciente(numero_afiliacion))
                {
                    Boolean retiro = hospital.retirar_paciente(numero_afiliacion);
                    if (retiro == true)
                    {
                        //Retiro de paciente exitos
                        string query = "DELETE FROM paciente WHERE numero_afiliacion=@numero_afiliacion";
                        MySqlCommand comando = new MySqlCommand(query, connection.Connect());
                        try
                        {
                            comando.Parameters.AddWithValue("@numero_afiliacion", numero_afiliacion);
                            comando.ExecuteNonQuery();
                            retiroExitoso("Ha podido retirar de manera correcta");
                        }
                        catch (MySqlException ex) 
                        {
                            retiroExitoso("Error de tipo: " + ex);
                        }
                        
                        this.Close();//cerrar este form
                    }
                    else
                    {
                        //En caso de retiro de paciente no exitoso
                        MessageBox.Show("El paciente: " + numero_afiliacion + ", no esta registrado en el sistema.");
                    }
                }
                else{
                    retiroExitoso("No tiene suficientes permisos para retirar al paciente");
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
