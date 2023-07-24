using Grafico;
using InnoSys.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoSys.Administración
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }
        //Declaro formularios unicos de Administracion
        public static AutCuentas frmAutCuentas = new AutCuentas();
        public static IngresarZona frmIngresoZonas = new IngresarZona();
        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAutCuentas.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.frmClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.frmPedidos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.frmVehículos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmIngresoZonas.Show();
        }
    }
}
