using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class FormMain : Form
    {
        Hospital hospital;
        Usuario user;
        SQL.Connection connection;
        public FormMain(Hospital hospital,Usuario user, SQL.Connection connection)
        {
            InitializeComponent();
            this.hospital = hospital;
            this.user = user;
            this.connection = connection;
        }
        string unidad;
        
        public struct paciente
        {
            string nombre;
            int edad;
            string sexo;
            string DPI;
            string Enfermedad;
            string fechadenac;
            string noafiliacion;
            string tipoafiliacion;
        }
        public void aignarpaciente(paciente Paciente)
        {

        }
        public void retirarpaciente(paciente Paciente)
        {

        }

        public void modificarpaciente(paciente Paciente)
        {

        }
        public void Buscarpaciente(paciente Paciente)
        {

        }
        public void trasladopaciente(paciente Paciente)
        {

        }
        public void guardarpaciente(paciente Paciente)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso f = new Ingreso(hospital,user, connection);
            f.Show();//mostrar form de ingreso
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRetirar f = new FormRetirar(hospital, user, connection);
            f.Show();//mostrar form de retiro
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormModificar f = new FormModificar(hospital, user, connection);
            f.Show();//mostrar form de modificacion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBuscar f = new FormBuscar(hospital, connection);
            f.Show();//mostrar form de buscar
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTraslado f = new FormTraslado(hospital,user);
            f.Show(); //mostrar form de traslado
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormInicio I = new FormInicio(hospital);
            I.Show();//mostrar el form del menú
            this.Close();//cerrar este form

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
