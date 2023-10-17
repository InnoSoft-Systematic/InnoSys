using Grafico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoSys.Transporte
{
    public partial class Transporte : Form
    {
        public Transporte()
        {
            InitializeComponent();
        }
        //Declaro formularios propios de este
        public static ModEnvio frmModEnvio = new ModEnvio();
        public static IngresoEnvío frmIngresoEnvio = new IngresoEnvío();
        public static EstadoEnvios frmEstadoEnvios = new EstadoEnvios();

        
        private void Login_Disposed(object sender, EventArgs e)
        {   //Cuando el programa cierra, cierra login también que estaba oculto
            Program.frmLogin.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.frmVehículos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.frmVerZonas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.frmSucursales.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEstadoEnvios.Show();
        }

        private void Transporte_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmModEnvio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIngresoEnvio.Show();
        }
    }
}
