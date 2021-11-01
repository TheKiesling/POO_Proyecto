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
    public partial class FormBuscar : Form
    {
        Hospital hospital;
        SQL.Connection connection;
        public FormBuscar(Hospital hospital, SQL.Connection connection)
        {
            InitializeComponent();
            this.hospital = hospital;
            this.connection = connection;
        }

        private void button1_Click(object sender, EventArgs e)
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
                        myReader.Read();
                        textBox1.Text = myReader["nombre"].ToString();
                        textBox2.Text = myReader["fecha_nacimiento"].ToString();
                        textBox3.Text = myReader["sexo"].ToString();
                        textBox4.Text = myReader["dpi"].ToString();
                        textBox5.Text = myReader["enfermedad"].ToString();
                        textBox7.Text = myReader["sede"].ToString();
                        textBox6.Text = myReader["tipo_afiliacion"].ToString();


                    }
                }
            connection.Close();
            
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
