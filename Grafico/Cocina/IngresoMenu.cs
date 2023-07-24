using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoSys.Administrador
{
    public partial class IngresoMenu : Form
    {
        public IngresoMenu()
        {
            InitializeComponent();
        }

        private void IngresoMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Al presionar Volver, se cierre la ventana
            this.Close();
        }
    }
}
