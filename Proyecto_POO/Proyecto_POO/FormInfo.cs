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
    public partial class FormInfo : Form
    {
        Hospital hospital;
        public FormInfo(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormInicio I = new FormInicio(hospital);
            I.Show();//mostrar el form del menú
            this.Close();//cerrar este form
        }
    }
}
