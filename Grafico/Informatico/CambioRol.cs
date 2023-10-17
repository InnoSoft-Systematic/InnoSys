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

namespace InnoSys.Informatico
{
    public partial class CambioRol : Form
    {
        public CambioRol()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.frmGerente.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.frmAdministracion.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Program.frmCocina.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.frmTransporte.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.frmRecepcion.Show();
        }

        private void CambioRol_Load(object sender, EventArgs e)
        {

        }
    }
}
