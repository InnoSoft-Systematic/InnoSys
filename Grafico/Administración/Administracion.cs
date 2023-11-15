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
        private void Login_Disposed(object sender, EventArgs e)
        {
            Program.frmLogin.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmAutCuentas.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.frmClientes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cocina.frmModEstados.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.frmEstadoEnvios.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.frmVehículos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmIngresoZonas.ShowDialog();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Recepcion.frmAltaBajaCliente.ShowDialog();
        }
    }
}
