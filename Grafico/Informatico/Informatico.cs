using Grafico;
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

        private void Login_Disposed(object sender, EventArgs e)
        {
            Program.frmLogin.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmCambioRol.ShowDialog();
        }

        private void Informatico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.frmStock.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.frmClientes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.frmPedidos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.frmMenu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.frmVerZonas.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Program.frmVehículos.ShowDialog();
        }
    }
}
