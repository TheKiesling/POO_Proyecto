﻿using System;
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
        public FormModificarSesion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicioSesion IS = new FormInicioSesion();
            IS.Show();//mostrar el form del menú
            this.Close();//cerrar este form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInicioSesion IS = new FormInicioSesion();
            IS.Show();//mostrar el form del menú
            this.Close();//cerrar este form
        }
    }
}