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
using System.IO;

namespace Proyecto_POO
{
    public partial class FormTraslado : Form
    {
        Paciente paciente;
        Hospital hospital;
        Usuario user;
        SQL.Connection connection;

        public FormTraslado(Hospital hospital, Usuario user)
        {
            InitializeComponent();
            this.hospital = hospital;
            paciente = null;
            this.user = user;
            this.connection = connection;
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
            //Nueva sede de traslado
            String sede = textBox1.Text;

            //Se verifica que haya un id ingresado
            if (numero_afiliacion != "")
            {
                //Conexion a db
                MySqlConnection connectionb = new MySqlConnection();
                connectionb.ConnectionString = "server=" + "localhost" + ";" + "user=" + "root" + ";" + "password=" + "" + ";" + "database=" + "sgh" + ";";
                connectionb.Open();
                String query = "select * from paciente where no_afiliacion='" + numero_afiliacion + "'";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connectionb;
                comando.CommandText = query;
                MySqlDataReader myReader = comando.ExecuteReader();
                connectionb.Close();

                //Se guardan los datos que no seran modificados
                String nom = myReader["nombre"].ToString();
                String fec = myReader["fecha_nacimiento"].ToString();
                String sex = myReader["sexo"].ToString();
                String dpi = myReader["dpi"].ToString();
                String enf = myReader["enfermedad"].ToString();
                String tip = myReader["tipo_afiliacion"].ToString();

                //Verificacion de traslado
                if (user.trasladoPaciente(numero_afiliacion))
                {

                    //Se realiza la actualizacion de los datos (solo cambia sede)
                    String querym = "UPDATE paciente SET nombre='" + nom + "', fecha_nacimiento='" + fec + "', sexo='"+sex+"', dpi='"+dpi+"', enfermedad='"+enf+"', sede='"+sede+"', tipo_afiliacion='"+tip+"' WHERE no_afiliacion='"+numero_afiliacion+"'";
                    MySqlCommand comandod = new MySqlCommand(querym, connection.Connect());
                    try
                    {
                        comandod.ExecuteNonQuery();
                        trasladoExitoso("Ha podido trasladar de manera correcta");
                        MessageBox.Show("Se ha trasladado al paciente: " + numero_afiliacion);
                    }
                    catch (MySqlException ex)
                    {
                        trasladoExitoso("Error de tipo: " + ex);
                        MessageBox.Show("El paciente: " + numero_afiliacion + ", no ha podido ser trasladado.");
                    }

                    this.Close();//cerrar este form
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
