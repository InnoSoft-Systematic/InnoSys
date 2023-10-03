using Grafico;
using MySql.Data.MySqlClient;
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
            //Program es la clase estática que tiene el procedimiento main
            try
            {
                //Trato de abrir conexión a la BASE DE DATOS (usuario root)
                Program.cn.Open("miodbc", txtUsuario.Text, txtPass.Text, -1);
                if (Program.cn.State == 1)
                {
                    MessageBox.Show("Conexión abierta");
                    
                }else
                {
                    MessageBox.Show("Conexión cerrada");
                }
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }
            Program.cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
           

            //SWITCH PARA ELEGIR LOS USUARIOS QUE VAN A INGRESAR
            string nombre = txtUsuario.Text;
            switch (nombre)
            {
                case "recepcion":
                    Program.frmLogin.Hide();
                    Program.frmRecepcion.Show();
                    break;
                case "admin":
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
        {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
    }
}


