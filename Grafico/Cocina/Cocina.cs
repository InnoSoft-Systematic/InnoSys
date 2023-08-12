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


        private void button10_Click(object sender, EventArgs e)
        {
            Program.frmStock.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.frmMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.frmEstados.Show();
        }

        private void Cocina_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIngresoMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.frmPedidos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmModEstados.Show();

        }
    }
}
