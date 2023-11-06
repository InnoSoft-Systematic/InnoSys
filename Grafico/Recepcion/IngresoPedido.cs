using InnoSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafico
{
    public partial class IngresoPedido : Form
    {
        public IngresoPedido()
        {
            InitializeComponent();
            btnBCI.Enabled = false;
            btnBRUT.Enabled = false;
            txtCIb.Enabled = false;
            txtRUTb.Enabled = false;

        }
        private Int32 numero(String valor)
        {
            Int32 retorno;
            if (!Int32.TryParse(valor, out retorno))
            {
                retorno = 0;
            }
            return (retorno);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void IngresoPedido_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

            switch (c.buscar())
            {
                case 0:  //Encontré
                    MessageBox.Show("Cédula encontrada");

                    break;
                case 1: //La conexión está cerrada.
                    MessageBox.Show("Se perdió la sesión. Debe loguearse nuevamente.");
                    break;
                case 2:
                case 4:
                    MessageBox.Show("Hubo errores al efectuar operación");
                    break;
                case 3: //No encontré
                    respuesta = MessageBox.Show("Cédula no encontrada");
                    break;
            }


            string sql;
            object cantlineas;

            if (btnBCI.Enabled == true)
            {

                sql = "SELECT Primer_nombre,Primer_apellido,Tel from cliente INNER JOIN persona ON persona.Id_Cliente = cliente.Id_Cliente where CI = " + c.CI;

                try
                {

                    rs = Program.cn.Execute(sql, out cantlineas, -1); //resultado RS
                }
                catch
                {
                    MessageBox.Show("ERROR"); //error al ejecutar sentencia SQL.
                    return;
                }
                //   cboCiudad.Items.Clear(); //Por si tenia datos anteriormente

                while (!rs.EOF)
                {
                    string Nombre = rs.Fields[0].Value.ToString();
                    string Apeliido = rs.Fields[1].Value.ToString();
                    string tel = rs.Fields[2].Value.ToString();
                    //PARA QUE SE CARGEN LOS DATOS EN EL LABEL
                    string cadena = Nombre + " " + Apeliido + " " + tel;
                    lblInformacionClienteCI.Text = "Cliente: " + cadena + "";

                    rs.MoveNext();
                }
                lblInformacionClienteRUT.Hide();
                lblInformacionClienteCI.Show();
            }

        }//VOID



        private void btnBRUT_Click(object sender, EventArgs e)
        {
            ClaseCliente c = new ClaseCliente();
            DialogResult respuesta;

            c.RUT = numero(txtRUTb.Text);
            txtRUTb.Text = Convert.ToString(c.RUT);

            c.conexion = Program.cn;
            ADODB.Recordset rs = new ADODB.Recordset();

            switch (c.buscarRUT())
            {
                case 0:  //Encontré
                    MessageBox.Show("RUT encontrado");

                    break;
                case 1: //La conexión está cerrada.
                    MessageBox.Show("Se perdió la sesión. Debe loguearse nuevamente.");
                    break;
                case 2:
                case 4:
                    MessageBox.Show("Hubo errores al efectuar operación");
                    break;
                case 3: //No encontré
                    respuesta = MessageBox.Show("RUT no encontrado");
                    break;
            }


            if (btnBCI.Enabled == false)
            {
                string sql;
                object cantlineas;

                sql = "SELECT Nombre_fant,Tel from cliente INNER JOIN empresa ON empresa.Id_Cliente = cliente.Id_Cliente where RUT = " + c.RUT;

                try
                {

                    rs = Program.cn.Execute(sql, out cantlineas, -1); //resultado RS
                }//TRY
                catch
                {
                    MessageBox.Show("ERROR"); //error al ejecutar sentencia SQL.
                    return;
                }//CATCH
                while (!rs.EOF)
                {
                    string Empresa = rs.Fields[0].Value.ToString();
                    string Tel = rs.Fields[1].Value.ToString();
                    //PARA QUE SE CARGEN LOS DATOS EN EL LABEL
                    string cadena = Empresa + " " + Tel;
                    lblInformacionClienteRUT.Text = "Cliente: " + cadena + "";

                    rs.MoveNext();
                }//WHILE
                lblInformacionClienteRUT.Show();
                lblInformacionClienteCI.Hide();
            }//IF
        }

        private void rboPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (rboPersona.Checked)
            {


                txtCIb.Enabled = true;
                txtRUTb.Enabled = false;
                btnBCI.Enabled = true;
                btnBRUT.Enabled = false;
                lblInformacionClienteCI.Hide();
                lblInformacionClienteRUT.Show();

            }
            if (!rboPersona.Checked)
            {
                txtCIb.Enabled = false;
                txtRUTb.Enabled = true;
                btnBCI.Enabled = false;
                btnBRUT.Enabled = true;
                lblInformacionClienteCI.Show();
                lblInformacionClienteRUT.Hide();


            }
        }

        private void rboEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rboEmpresa.Checked) //Si Empresa está seleccionado, se mostraran los siguientes efectos
            {

                txtCIb.Enabled = false;
                txtRUTb.Enabled = true;
                btnBCI.Enabled = false;
                btnBRUT.Enabled = true;
                lblInformacionClienteCI.Hide();
                lblInformacionClienteRUT.Show();
            }
            if (!rboEmpresa.Checked)//De lo contrario, se mantendrán oculto
            {
                txtCIb.Enabled = false;
                txtRUTb.Enabled = true;
                btnBCI.Enabled = false;
                btnBRUT.Enabled = true;
                lblInformacionClienteCI.Show();
                lblInformacionClienteRUT.Hide();
            }
        }
    }
}
