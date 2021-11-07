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
            MySqlConnection connectionb = new MySqlConnection();
            connectionb.ConnectionString = "server=" + "localhost" + ";" + "user=" + "root" + ";" + "password=" + "" + ";" + "database=" + "sgh" + ";";
            connectionb.Open();
            String query = "select * from paciente where no_afiliacion='" + numero_afiliacion + "'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = connectionb;
            comando.CommandText = query;
            MySqlDataReader myReader = comando.ExecuteReader();
            connectionb.Close();

            if (numero_afiliacion != ""){
                if (user.darAltaPaciente(numero_afiliacion))
                {
                        //Retiro de paciente exitos
                        string queryd = "DELETE FROM paciente WHERE no_afiliacion='" +numero_afiliacion+"'";
                        MySqlCommand comandod = new MySqlCommand(queryd, connection.Connect());
                        try
                        {
                            comandod.ExecuteNonQuery();
                            retiroExitoso("Ha podido retirar de manera correcta");
                        }
                        catch (MySqlException ex) 
                        {
                            retiroExitoso("Error de tipo: " + ex);
                        }
                        
                        this.Close();//cerrar este form
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
