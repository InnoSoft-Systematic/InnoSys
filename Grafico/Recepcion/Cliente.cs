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
            /* string nombre = txtNombre.Text;
             string primerape = txtPrimerApe.Text;
             string segape = txtSegApe.Text;*/

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
            c.CI = numero (txtCialta.Text);
            txtCialta.Text = Convert.ToString(c.CI);
            //Declaro nombre desde ClaseCliente (c)
            c.nombre = txtNombre.Text;

            //cboTelefonos.SelectedIndex = -1;

            //Si los campos están vacíos, sale mensaje de error
            if (txtNombre.Text == "" || txtPrimerApe.Text == "")
            {
                MessageBox.Show("Existen campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //QUEDA HACER EL INSERT INTO

                string cadena = c.nombre + " " + c.CI + " ";
                string sql;
                sql = "insert into clientes(CI,nombre) values (" + c.CI + ",'" + c.nombre + "')";

                listaUsuarios.Add(cadena);

                //Para que se vaya agregando
                lstCliente.DataSource = null;
                lstCliente.DataSource = listaUsuarios;
                //Se limpian los campos luego de haber ingresado
                txtPrimerApe.Clear();
                txtNombre.Clear();

                

            }
            //Guardar datos
                List<String> telefonos = new List<String>();
                
              /*  foreach (string t in cboTelefonos.Items)
                {
                    telefonos.Add(t);
                }
                //c.telefonos = telefonos;*/
              /*  switch (c.guardar(!btnEliminar.Enabled)) //Si btnEliminar está inhabilitado, es un alta
                {
                    case 0:  //Se pudo efectuar el alta o modificación sin problemas.
                      //  gbBuscar.Enabled = true;
                       // gbDatos.Visible = false;
                        break;
                    case 1: //La conexión está cerrada.
                        MessageBox.Show("Se perdió la sesión. Debe loguearse nuevamente.");
                        break;
                    case 2:
                    case 3:
                    case 4:
                    default:
                        MessageBox.Show("Hubo errores al efectuar operación");
                        break;
                };
                c = null;*/
            
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

        }
    }
}
