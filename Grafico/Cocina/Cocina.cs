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

namespace InnoSys
{
    public partial class Cocina : Form
    {
        public Cocina()
        {
            InitializeComponent();
        }

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
    }
}
