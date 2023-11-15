using Grafico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoSys.Gerente
{
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
        }

        public static AutNuevosProd frmAutorizarProd = new AutNuevosProd();


        private void Login_Disposed(object sender, EventArgs e)
        {
            Program.frmLogin.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.frmStock.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.frmMenu.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.frmEstadoEnvios.ShowDialog();
        }

        private void Gerente_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAutorizarProd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.frmVerZonas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
