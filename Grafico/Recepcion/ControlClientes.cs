using InnoSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafico
{
    public partial class ControlClientes : Form
    {
        public ControlClientes()
        {
            InitializeComponent();
        }

        //Declaro nuevos forms, en privado
        public static AltaCliente frmAltaCliente = new AltaCliente();
        public static BajaCliente frmBajaCliente = new BajaCliente();

        private void button1_Click(object sender, EventArgs e)
        {
            Recepcion.frmControlClientes.Hide();
            frmAltaCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recepcion.frmControlClientes.Hide();
            frmBajaCliente.Show();
        }
    }
}
