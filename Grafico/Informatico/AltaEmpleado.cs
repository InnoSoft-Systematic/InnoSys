using Grafico;
using InnoSys.Administración;
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
    public partial class AltaEmpleado : Form
    {
        public AltaEmpleado()
        {
            InitializeComponent();
            cboCargo.Items.Add("Informatico");
            cboCargo.Items.Add("Cocina");
            cboCargo.Items.Add("Recepcion");
            cboCargo.Items.Add("Administrativo");
            cboCargo.Items.Add("Transporte");
            cboCargo.Items.Add("Gerente");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btmVolver_Click(object sender, EventArgs e)
        {
            txtCI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtApellido2.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            this.Hide();


        }

        private void AltaEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            string CI = txtCI.Text;
            string Nombre = txtNombre.Text;
            string Apellido1 = txtApellido.Text;
            string Apellido2 = txtApellido2.Text;
            string rol = cboCargo.SelectedItem.ToString();
            string usuario = txtUsuario.Text;
            string contraseña = txtContra.Text;


            sql = "insert into usuarios (CI,Nombre,Apellido_uno,Apellido_dos,Usuario,Contraseña,Rol)";
            sql = sql + " values(" + CI + ",'" + Nombre + "','" + Apellido1 + "','" + Apellido2 + "','" + usuario + "','" + contraseña + "','" + rol + "')";
            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas, -1);
                MessageBox.Show("Alta usuario efectuada correctamente");
            }
            catch 
            {
                MessageBox.Show("Error sentencia SQL");
            }
        }
    }
}
