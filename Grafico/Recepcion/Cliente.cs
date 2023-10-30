using InnoSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafico
{
    public partial class Cliente : Form
    {

        //LISTA DE USUARIOS
        List<string> listaUsuarios = new List<string>();

        public Cliente()
        {
            InitializeComponent();

            gbAlta.Hide();
            gbBaja.Hide();
            lblCIb.Hide();
            lblRUTb.Hide();
            txtCIb.Hide();
            txtRUTb.Hide();
            btnBCI.Hide();
            btnBRUT.Hide();
            lblSiCI.Hide();
            lblNoCI.Hide();


        }
        //???
        private Int32 numero(String valor)
        {
            Int32 retorno;
            if (!Int32.TryParse(valor, out retorno))
            {
                retorno = 0;
            }
            return (retorno);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btmVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btmAceptar_Click(object sender, EventArgs e)
        {
            //Botón aceptar
            //Defino la clase cliente para darle uso
            ClaseCliente c = new ClaseCliente();

            //Declaro CI desde ClaseCliente (c) y la convierto en String
            c.CI = numero(txtCIb.Text);
            txtCIb.Text = Convert.ToString(c.CI);
            //Declaro nombre desde ClaseCliente (c)
            c.nombre = txtNombre.Text;
            c.apellido1 = txtPrimerApe.Text;
            c.apellido2 = txtSegApe.Text;
            c.mail = txtEmail.Text;
            //// c.telefonos = numero (txtTel.Text);
            ////txtTel.Text = Convert.ToString (txtTel.Text);
            c.conexion = Program.cn;

            //cboTelefonos.SelectedIndex = -1;

            //Si los campos están vacíos, sale mensaje de error
            if (txtNombre.Text == "" || txtPrimerApe.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Existen campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string cadena = c.CI + " " + c.nombre + " " + c.apellido1 + " " + c.apellido2 + " " + c.direccion + " " + c.mail + " ";
                listaUsuarios.Add(cadena);

                //INVOCO AL MÉTODO GUARDAR
                byte resultado = c.guardar(true);

                switch (resultado)
                {
                    case 0: MessageBox.Show("Alta efectuada correctamente"); break;
                    case 1: MessageBox.Show("Debe loguearse nuevamente"); break;
                    case 2: MessageBox.Show("Error sentencia SQL"); break;
                    case 3: MessageBox.Show("Error sentencia"); break;
                    case 4: MessageBox.Show("Error 4"); break;
                }



                //Para que se vaya agregando en la list box
                lstCliente.DataSource = null;
                lstCliente.DataSource = listaUsuarios;
                //Se limpian los campos luego de haber ingresado
                txtPrimerApe.Clear();
                txtNombre.Clear();
                txtEmail.Clear();
                txtTel.Clear();
                txtDireccion.Clear();
                txtSegApe.Clear();



            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rboPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (rboPersona.Checked)
            {
                txtCIb.Show();
                lblCIb.Show();
                btnBCI.Show();
            }
            if (!rboPersona.Checked)
            {
                txtCIb.Hide();
                lblCIb.Hide();
                btnBCI.Hide();
            }
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCialta_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInfoBaja_Click(object sender, EventArgs e)
        {

        }

        private void lblNoCI_Click(object sender, EventArgs e)
        {

        }

        private void gbTipo_Enter(object sender, EventArgs e)
        {

        }

        private void rboEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rboEmpresa.Checked)
            {
                txtRUTb.Show();
                lblRUTb.Show();
                btnBRUT.Show();
            }
            if (!rboEmpresa.Checked)
            {
                txtRUTb.Hide();
                lblRUTb.Hide();
                btnBRUT.Hide();
            }
        }

        private void txtRUTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBCI_Click(object sender, EventArgs e)
        {
            ClaseCliente c = new ClaseCliente();
            DialogResult respuesta;

            c.CI = numero(txtCIb.Text);
            txtCIb.Text = Convert.ToString(c.CI);

            c.conexion = Program.cn;
            ADODB.Recordset rs = new ADODB.Recordset();
            //cboTelefonos.SelectedIndex = -1;

            switch (c.buscar())
            {
                case 0:  //Encontré
                    MessageBox.Show("La cédula ingresada ya se encuentra en el sistema");
                    lblSiCI.Show();
                    // _CI = Convert.ToString(rs.Fields[0].Value);
                    break;
                case 1: //La conexión está cerrada.
                    MessageBox.Show("Se perdió la sesión. Debe loguearse nuevamente.");
                    break;
                case 2:
                case 4:
                    MessageBox.Show("Hubo errores al efectuar operación");
                    break;
                case 3: //No encontré
                    respuesta = MessageBox.Show("Registro no encontrado ¿Desea efectuar el alta?", "¿Alta?", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        gbAlta.Visible = true;
                    }
                    break;
            };
            c = null;
        } //btnBuscar_Click





    }
}

