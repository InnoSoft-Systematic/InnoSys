﻿using Grafico;
using InnoSys.Informatico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoSys.Administrador
{
    public partial class Informatico : Form
    {
        public Informatico()
        {
            InitializeComponent();
        }
        public static CambioRol frmCambioRol = new CambioRol();
        public static AltaEmpleado frmAltaEmpleado = new AltaEmpleado();
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmCambioRol.Show();
        }

        private void Informatico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.frmStock.Show();
        }
    }
}
