using Grafico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoSys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SWITCH TEMPORAL PARA VER LAS VENTANAS DE CADA ROL
            string nombre = txtUsuario.Text;
            switch (nombre)
            {
                case "Recepcion":
                    Program.frmLogin.Hide();
                    Program.frmRecepcion.Show();
                    break;
                case "Admin":
                    Program.frmLogin.Hide();
                    Program.frmAdministracion.Show();
                    break;
                case "Cocina":
                    Program.frmLogin.Hide();
                    Program.frmCocina.Show();
                    break;
                case "Gerente":
                    Program.frmLogin.Hide();
                    Program.frmGerente.Show();
                    break;
                case "Transporte":
                    Program.frmLogin.Hide();
                    Program.frmTransporte.Show();
                    break;
                case "root":
                    Program.frmLogin.Hide();
                    Program.frmInformatico.Show();
                    break;

            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
