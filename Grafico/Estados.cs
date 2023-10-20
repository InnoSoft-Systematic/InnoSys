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
    public partial class Estados : Form
    {
        public Estados()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.frmEstados.Hide();
        }
    }
}
