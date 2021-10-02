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
    public partial class FormInicio : Form
    {
        Hospital hospital;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.Show();//mostrar el form del menú
            this.Hide();//cerrar este form
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInicioSesion IS = new FormInicioSesion();
            IS.Show();//mostrar el form del menú
            this.Hide();//cerrar este form
            hospital = new Hospital();

        }
        public Hospital GetHospital() {
            return hospital;
        }
    }
}
