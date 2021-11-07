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
            String numero_afiliacion = textBox8.Text;
            String tipo_afiliacion = textBox7.Text;
            String sede = "IGSS";
            Boolean verificacion = false;

            if (nombre != "" || fecha_nacimiento != "" || sexo != "" || dpi != "" || enfermedad != "" || numero_afiliacion != "" || tipo_afiliacion != "")
            {
                //Verificacion de Paciente dentro del sistema
                verificacion = hospital.recorrerArreglo(numero_afiliacion);

                if (verificacion == false)
                {
                    if (user.ingresarPaciente())
                    {
                        //Creacion del Paciente
                        paciente = new Paciente(nombre, fecha_nacimiento, sexo, dpi, enfermedad, numero_afiliacion, tipo_afiliacion, sede);
                        //Asignacion del Paciente
                        hospital.asignarPaciente(paciente);
                        //Insercion de datos de Paciente en la base de datos
                        string query = "UPDATE paciente SET nombre=@nombre, tipo_afiliacion=@tipo_afiliacion, sexo=@sexo, dpi=@dpi, enfermedad=@enfermedad, fecha_nacimiento=@fecha_nacimiento, sede=@sede WHERE no_afiliacion=@numero_afiliacion";
                        MySqlCommand comando = new MySqlCommand(query, connection.Connect());
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@tipo_afiliacion", tipo_afiliacion);
                        comando.Parameters.AddWithValue("@sexo", sexo);
                        comando.Parameters.AddWithValue("@dpi", dpi);
                        comando.Parameters.AddWithValue("@enfermedad", enfermedad);
                        comando.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                        comando.Parameters.AddWithValue("@sede", sede);
                        comando.Parameters.AddWithValue("@numero_afiliacion", numero_afiliacion);
                        try
                        {
                            comando.ExecuteNonQuery();
                            //Mensaje de ingreso exitoso
                            ingresoExitoso("Ha podido ingresar de manera correcta");
                        }
                        catch(Exception ex)
                        {
                            ingresoExitoso("Error de tipo: " + ex);
                        }
                        this.Close();//cerrar este form
                    }
                    else
                    {
                        //En caso de no tener los permisos de Admin
                        ingresoExitoso("No tiene suficientes permisos para ingresar a un paciente");
                    }
                }
                else
                {
                    //En caso de que el Paciente ya haya sido ingresado
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

            if (textBox8.Text != "")
            {
                String numero_afiliacion = textBox8.Text;
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "server=" + "localhost" + ";" + "user=" + "root" + ";" + "password=" + "" + ";" + "database=" + "sgh" + ";";
                connection.Open();
                String query = "select * from paciente where no_afiliacion='" + numero_afiliacion + "'";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = connection;
                comando.CommandText = query;
                MySqlDataReader myReader = comando.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        textBox1.ReadOnly = false;
                        textBox2.ReadOnly = false;
                        textBox3.ReadOnly = false;
                        textBox4.ReadOnly = false;
                        textBox5.ReadOnly = false;
                        textBox7.ReadOnly = false;
                        myReader.Read();
                        textBox1.Text = myReader["nombre"].ToString();
                        textBox2.Text = myReader["fecha_nacimiento"].ToString();
                        textBox3.Text = myReader["sexo"].ToString();
                        textBox4.Text = myReader["dpi"].ToString();
                        textBox5.Text = myReader["enfermedad"].ToString();
                        textBox7.Text = myReader["tipo_afiliacion"].ToString();


                    }
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero de afiliacion.");
            }
        }
    }
}
