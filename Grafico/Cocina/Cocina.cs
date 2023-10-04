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

namespace InnoSys
{
    public partial class Cocina : Form
    {
        public Cocina()
        {
            InitializeComponent();
        }

        //Declaro formularios exclusivos de ventana COCINA
        public static IngresoMenu frmIngresoMenu = new IngresoMenu();
        public static ModEstados frmModEstados = new ModEstados();

        private void Login_Disposed(object sender, EventArgs e)
        {
            Program.frmLogin.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.frmStock.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.frmMenu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.frmEstados.ShowDialog();
        }

        private void Cocina_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIngresoMenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.frmPedidos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmModEstados.ShowDialog();

        }
    }
}
