using ADODB;
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
            {

            }

        }

        public static string rol { get; set; }
        public static string usuario { get; set; }
        public static string contraseña { get; set; }

        public static string connectionString { get; set; }

        public static string consultaSQL { get; set; }


        public static bool ValidarInicioSesion(string connectionString, string usuario, string contraseña)
        {
            Recordset rs = new Recordset();
            //ClaseCliente c = new ClaseCliente();

            try
            {
                Program.cn.Open(connectionString);

                // Supongamos que tienes una tabla llamada 'usuarios' con columnas 'nombre_usuario' y 'contraseña'
                consultaSQL = $"SELECT COUNT(*) FROM usuarios WHERE Usuario = '{Login.usuario}' AND Contraseña = '{Login.contraseña}'";

                rs.Open(consultaSQL, Program.cn);

                // Obtener el resultado de la consulta
                int cantidadFilas = Convert.ToInt32(rs.Fields[0].Value);


                return cantidadFilas != 0;

            }
            finally
            {
                rs.Close();
                Program.cn.Close();
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            connectionString = "miodbc";
            usuario = txtUsuario.Text;
            contraseña = txtPass.Text;

            bool inicioSesionExitoso = ValidarInicioSesion(connectionString, usuario, contraseña);

            if (inicioSesionExitoso)
            {

                string sql;
                object cantFilas;
                ADODB.Recordset rs = new ADODB.Recordset();

                MessageBox.Show("Inicio de sesión exitoso.");


                Program.cn.Open(connectionString);
                sql = "Select Rol from usuarios where Usuario='" + usuario + "' and Contraseña='" + contraseña + "'";

                try
                {
                    rs = Program.cn.Execute(sql, out cantFilas);
                    rol = rs.Fields[0].Value.ToString();

                    switch (rol)
                    {
                        case "Recepcion":
                            Program.frmLogin.Hide();
                            Program.frmRecepcion.Show();
                            break;
                        case "Administrativo":
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
                        case "Informatico":
                            Program.frmLogin.Hide();
                            Program.frmInformatico.Show();
                            break;

                    }
                }
                catch
                {
                    MessageBox.Show("Error a obtener datos de usuario" + sql);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Verifica tus credenciales.");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


