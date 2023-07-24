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
    public partial class EstadoEnvios : Form
    {
        public EstadoEnvios()
        {
            InitializeComponent();
        }

        private void btmVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
