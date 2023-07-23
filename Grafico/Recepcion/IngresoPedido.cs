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
    public partial class IngresoPedido : Form
    {
        public IngresoPedido()
        {
            InitializeComponent();
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void IngresoPedido_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        Recepcion.frmIngresoPedido.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recepcion.PopIngresoPedido.Show();
        }
    }
}
