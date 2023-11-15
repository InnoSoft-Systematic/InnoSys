using ADODB;
using InnoSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grafico
{
    public partial class Cliente : Form
    {

        //LISTA DE USUARIOS
        List<string> listaUsuarios = new List<string>();

        public Cliente()
        {
            InitializeComponent();

            gbAlta.Enabled = false;
            txtCIb.Enabled = false;
            txtRUTb.Enabled = false;
            btnBCI.Enabled = false;
            btnBRUT.Enabled = false;
            lblSiCI.Hide();
            lblNoCI.Hide();
            lblSiRUT.Hide();
            lblNoRUT.Hide();
            btnBaja.Hide();
            btnModificar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBaja.Enabled = false;




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

        private Int64 numeroRUT(String valor)
        {

            Int64 retorno;
            if (!Int64.TryParse(valor, out retorno))
            {
                retorno = 0;

            }
            return (retorno);
        }

        public void CargarZonas()
        {
            ADODB.Recordset rs = new ADODB.Recordset();

            string sql;
            object cantFilas;

            sql = "select nombre from zona";

            try
            {

                rs = Program.cn.Execute(sql, out cantFilas, -1); //resultado RS
            }
            catch
            {
                MessageBox.Show("Error a ver Zonas"); //error al ejecutar sentencia SQL.
                return;
            }
            cboCiudad.Items.Clear(); //Por si tenia datos anteriormente
            while (!rs.EOF)
            {
                cboCiudad.Items.Add(Convert.ToString(rs.Fields[0].Value)); //Va corriendo hasta el final
                rs.MoveNext();
            }
        }

        public void Limpiar()
        {
            txtEmpresa.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTel.Clear();
            txtNombre.Clear();
            txtPrimerApe.Clear();
            txtSegApe.Clear();
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
            //Defino la clase cliente para darle uso
           ClaseCliente c = new ClaseCliente();

            //Declaro CI desde ClaseCliente (c) y la convierto en String
            c.CI = numero(txtCIb.Text);
            txtCIb.Text = Convert.ToString(c.CI);

            c.telefonos = numero(txtTel.Text);
            txtTel.Text = Convert.ToString(c.telefonos);

            c.RUT = numero(txtRUTb.Text);
            txtRUTb.Text = Convert.ToString(c.RUT);
            //Declaro nombre desde ClaseCliente (c)
            c.nombre = txtNombre.Text;
            c.apellido1 = txtPrimerApe.Text;
            c.apellido2 = txtSegApe.Text;
            c.mail = txtEmail.Text;
            c.direccion = txtDireccion.Text;
            c.empresa = txtEmpresa.Text;

            c.conexion = Program.cn;

            string zonaseleccionada = cboCiudad.SelectedIndex.ToString(); //De seguro hay otra forma mas facil de hacerlo...
            if (zonaseleccionada == "0")
            {
                c.zona = 1;
            }
            if (zonaseleccionada == "1")
            {
                c.zona = 2;
            }
            if (zonaseleccionada == "2")
            {
                c.zona = 3;
            }
            if (zonaseleccionada == "3")
            {
                c.zona = 4;
            }
            if (zonaseleccionada == "4")
            {
                c.zona = 5;
            }
            if (zonaseleccionada == "5")
            {
                c.zona = 6;
            }
            if (zonaseleccionada == "6")
            {
                c.zona = 7;
            }

            //Si los campos están vacíos, sale mensaje de error
            if (txtRUTb.Text == "" || txtCIb.Text == "")
            {
                MessageBox.Show("Existen campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string cadena = " " + c.RUT + " " + c.empresa + " " + c.CI + " " + c.nombre + " " + c.apellido1 + " " + c.apellido2 + " " + c.direccion + " " + c.mail + " " + c.telefonos + " " + c.zona + " ";
                listaUsuarios.Add(cadena);

                //INVOCO AL MÉTODO GUARDAR
                if (btnBCI.Enabled == true)
                {
                    byte resultado = c.guardar(true);
                    switch (resultado)
                    {
                        case 0: MessageBox.Show("Alta efectuada correctamente"); break;
                        case 1: MessageBox.Show("Debe loguearse nuevamente"); break;
                        case 2: MessageBox.Show("Error sentencia SQL"); break;
                        case 3: MessageBox.Show("Error sentencia"); break;
                        case 4: MessageBox.Show("Error 4"); break;
                    }

                }
                else
                {
                    byte resultado = c.guardarRUT(true);

                    switch (resultado)
                    {
                        case 0: MessageBox.Show("Alta efectuada correctamente"); break;
                        case 1: MessageBox.Show("Debe loguearse nuevamente"); break;
                        case 2: MessageBox.Show("Error sentencia SQL"); break;
                        case 3: MessageBox.Show("Error sentencia"); break;
                        case 4: MessageBox.Show("Error 4"); break;
                    }
                }

                //Para que se vaya agregando en la list box
                lstCliente.DataSource = null;
                lstCliente.DataSource = listaUsuarios;
                //Se limpian los campos luego de haber ingresado
                Limpiar();
                 
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


                txtCIb.Enabled = true;
                txtRUTb.Enabled = false;
                btnBCI.Enabled = true;
                btnBRUT.Enabled = false;

            }
            if (!rboPersona.Checked)
            {
                txtCIb.Enabled = false;
                txtRUTb.Enabled = true;
                btnBCI.Enabled = false;
                btnBRUT.Enabled = true;


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
            if (rboEmpresa.Checked) //Si Empresa está seleccionado, se mostraran los siguientes efectos
            {

                txtCIb.Enabled = false;
                txtRUTb.Enabled = true;
                btnBCI.Enabled = false;
                btnBRUT.Enabled = true;
            }
            if (!rboEmpresa.Checked)//De lo contrario, se mantendrán oculto
            {
                txtCIb.Enabled = false;
                txtRUTb.Enabled = true;
                btnBCI.Enabled = false;
                btnBRUT.Enabled = true;


            }
        }

        private void txtRUTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBCI_Click(object sender, EventArgs e)
        {
            /* ClaseCliente c = new ClaseCliente();
             DialogResult respuesta;
             string sql;

                 c.CI = numero(txtCIb.Text);
                 txtCIb.Text = Convert.ToString(c.CI);

                 c.conexion = Program.cn;
                 ADODB.Recordset rs = new ADODB.Recordset();
                 lblSiRUT.Hide();
                 lblNoRUT.Hide();

                 switch (c.buscar())
                 {
                     case 0:  //Encontré
                         MessageBox.Show("La cédula ingresada ya se encuentra en el sistema");
                         gbAlta.Enabled = false;
                         btnAceptar.Enabled = false;
                         lblSiCI.Show();
                         btnModificar.Enabled = true;
                         btnBaja.Enabled = true;
                         btnBaja.Show();
                         lblNoCI.Hide();
                         //LIMPIAR
                         txtEmpresa.Clear();
                         txtEmail.Clear();
                         txtDireccion.Clear();
                         txtTel.Clear();
                         txtNombre.Clear();
                         txtPrimerApe.Clear();
                         txtSegApe.Clear();
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
                             gbAlta.Enabled = true;
                             btnAceptar.Enabled = true;
                         }else { gbAlta.Enabled = false; }
                         lblNoCI.Show();
                         lblSiCI.Hide();
                         txtEmpresa.Hide();
                         lblEmpresa.Hide();
                         txtNombre.Show();
                         lblNombre.Show();
                         txtPrimerApe.Show();
                         lblPrimerApe.Show();
                         txtSegApe.Show();
                         lblSegApe.Show();
                         btnModificar.Enabled = false;
                         btnBaja.Enabled = false;
                         btnActualizar.Enabled = false;
                         //LIMPIAR
                         txtEmpresa.Clear();
                         txtEmail.Clear();
                         txtDireccion.Clear();
                         txtTel.Clear();
                         txtNombre.Clear();
                         txtPrimerApe.Clear();
                         txtSegApe.Clear();

                         break;
                 };
                 c = null;

                 object cantlineas;

                 sql = "select nombre from zona";


                 try
                 {

                     rs = Program.cn.Execute(sql, out cantlineas, -1); //resultado RS
                 }
                 catch
                 {
                     MessageBox.Show("ERROR"); //error al ejecutar sentencia SQL.
                     return;
                 }
                 cboCiudad.Items.Clear(); //Por si tenia datos anteriormente
                 while (!rs.EOF)
                 {
                     cboCiudad.Items.Add(Convert.ToString(rs.Fields[0].Value)); //Va corriendo hasta el final
                     rs.MoveNext();
                 }*/


            ADODB.Recordset rs = new ADODB.Recordset();
            lblSiRUT.Hide();
            lblNoRUT.Hide();
            string nombre = txtNombre.Text;
            string apellido1 = txtPrimerApe.Text;
            string apellido2 = txtSegApe.Text;
            string mail = txtEmail.Text;
            string direccion = txtDireccion.Text;
            string empresa = txtEmpresa.Text;
            string CI = txtCIb.Text;

            string cedula = "";
            string sql;
            object cantFilas;

            CargarZonas();

            sql = "Select CI from persona where CI=" + CI;
            try
            {
                rs = Program.cn.Execute(sql, out cantFilas);
                if (!rs.EOF)
                {
                    cedula = rs.Fields[0].Value.ToString();
                    MessageBox.Show("La cédula ingresada ya se encuentra en el sistema");
                    gbAlta.Enabled = false;
                    btnAceptar.Enabled = false;
                    lblSiCI.Show();
                    btnModificar.Enabled = true;
                    btnBaja.Enabled = true;
                    btnBaja.Show();
                    lblNoCI.Hide();
                    //LIMPIAR
                    Limpiar();
                }
                else
                {
                    
                    DialogResult respuesta = MessageBox.Show("Registro no encontrado ¿Desea efectuar el alta?", "¿Alta?", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        gbAlta.Enabled = true;
                        btnAceptar.Enabled = true;
                    }
                    else
                    {
                        gbAlta.Enabled = false;
                    }
                    lblNoCI.Show();
                    lblSiCI.Hide();
                    txtEmpresa.Hide();
                    lblEmpresa.Hide();
                    txtNombre.Show();
                    lblNombre.Show();
                    txtPrimerApe.Show();
                    lblPrimerApe.Show();
                    txtSegApe.Show();
                    lblSegApe.Show();
                    btnModificar.Enabled = false;
                    btnBaja.Enabled = false;
                    btnActualizar.Enabled = false;
                    //LIMPIAR
                    Limpiar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en consulta usuario: " + ex.Message);
            }


        
            finally
            {
                rs.Close();
            }


        } //btnBuscar_Click

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBRUT_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            string RUT = "";
            string empresa = txtEmpresa.Text;



            ADODB.Recordset rs = new ADODB.Recordset();

            string sql;
            object cantFilas;

            CargarZonas();

            sql = "Select RUT from empresa where RUT=" + txtRUTb.Text;
            try
            {
                rs = Program.cn.Execute(sql, out cantFilas);
                if (!rs.EOF)
                {
                    RUT = rs.Fields[0].Value.ToString();
                    MessageBox.Show("El RUT ingresado ya se encuentra en el sistema");
                    gbAlta.Enabled = false;
                    btnAceptar.Enabled = false;
                    lblSiRUT.Show();
                    btnBaja.Show();
                    lblNoCI.Hide();
                    lblSiCI.Hide();
                    lblNoRUT.Hide();
                    btnModificar.Enabled = true;
                    btnBaja.Enabled = true;
                    //LIMPIAR
                    Limpiar();
                }
                else
                {

                    respuesta = MessageBox.Show("Registro no encontrado ¿Desea efectuar el alta?", "¿Alta?", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        gbAlta.Enabled = true;
                        btnAceptar.Enabled = true;
                    }
                    else { gbAlta.Enabled = false; }
                    lblNoRUT.Show();
                    lblSiRUT.Hide();
                    txtNombre.Hide();
                    lblNombre.Hide();
                    txtPrimerApe.Hide();
                    lblPrimerApe.Hide();
                    txtSegApe.Hide();
                    lblSegApe.Hide();
                    txtEmpresa.Show();
                    lblEmpresa.Show();
                    btnModificar.Enabled = false;
                    btnBaja.Enabled = false;
                    btnActualizar.Enabled = false;
                    //LIMPIAR
                    Limpiar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en consulta usuario: " + ex.Message);
            }
            finally
            {
                rs.Close();
            }

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            
            ClaseCliente c = new ClaseCliente();

            c.CI = numero(txtCIb.Text);
            txtCIb.Text = Convert.ToString(c.CI);

            c.RUT = numero(txtRUTb.Text);
            txtRUTb.Text = Convert.ToString(c.RUT);

            ADODB.Recordset rs = new ADODB.Recordset();

            DialogResult respuesta = MessageBox.Show("¿Seguro que quiere proceder a realizarle baja al dato ingresado?", "Baja", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                if (btnBRUT.Enabled == false)
                {

                 byte resultado = c.baja(true);
                 
                    switch (resultado)
                    {
                        case 0: MessageBox.Show("Solicitud de baja enviado correctamente"); break;
                        case 1: MessageBox.Show("Debe loguearse nuevamente"); break;
                        case 2: MessageBox.Show("Error sentencia SQL"); break;
                        case 3: MessageBox.Show("Error sentencia"); break;
                        case 4: MessageBox.Show("Error 4"); break;
                    }

                }
                if (btnBRUT.Enabled == true)
                {
                    byte resultado = c.baja(!true);

                    switch (resultado)
                    {
                        case 0: MessageBox.Show("Solicitud de baja enviado correctamente"); break;
                        case 1: MessageBox.Show("Debe loguearse nuevamente"); break;
                        case 2: MessageBox.Show("Error sentencia SQL"); break;
                        case 3: MessageBox.Show("Error sentencia"); break;
                        case 4: MessageBox.Show("Error 4"); break;
                    }
                }
                btnBaja.Enabled = false;
                
                //Falta programar para enviarle una solicitud a administración
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClaseCliente c = new ClaseCliente();
            string zonaseleccionada = cboCiudad.SelectedIndex.ToString(); //De seguro hay otra forma mas facil de hacerlo..
            if (zonaseleccionada == "0")
            {
                c.zona = 1;
            }
            if (zonaseleccionada == "1")
            {
                c.zona = 2;
            }
            if (zonaseleccionada == "2")
            {
                c.zona = 3;
            }
            if (zonaseleccionada == "3")
            {
                c.zona = 4;
            }
            if (zonaseleccionada == "4")
            {
                c.zona = 5;
            }
            if (zonaseleccionada == "5")
            {
                c.zona = 6;
            }
            if (zonaseleccionada == "6")
            {
                c.zona = 7;
            }

            if (txtCIb.Enabled == false)
            {
                
                c.RUT = numero(txtRUTb.Text);
                txtRUTb.Text = Convert.ToString(c.RUT);
                string sql;
                object cantFilas;
                ADODB.Recordset rs = new ADODB.Recordset();

                sql = "	update cliente INNER JOIN empresa ON empresa.Id_Cliente = cliente.Id_Cliente ";
                sql = sql + "set Mail ='" + txtEmail.Text + "'";
                sql = sql + ",Nombre_fant ='" + txtEmpresa.Text + "' ";
                sql = sql + ",Tel =" + txtTel.Text + "";
                sql = sql + ",Direccion ='" + txtDireccion.Text + "' ";
                sql = sql + ",Id_Zona =" + c.zona + "";
                sql = sql + " where RUT=" + c.RUT;



                try
                {
                    MessageBox.Show(sql);
                    rs = Program.cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return; //error al ejecutar sentencia SQL.
                }

                MessageBox.Show("Datos actualizados correctamente");

            }else
            {
                
                c.CI = numero(txtCIb.Text);
                txtCIb.Text = Convert.ToString(c.CI);
                string sql;
                object cantFilas;
                ADODB.Recordset rs = new ADODB.Recordset();

                sql = "	update cliente INNER JOIN persona ON persona.Id_Cliente = cliente.Id_Cliente ";
                sql = sql + "set Mail ='" + txtEmail.Text + "'";
                sql = sql + ",Primer_nombre ='" + txtNombre.Text + "' ";
                sql = sql + ",Primer_apellido ='" + txtPrimerApe.Text + "' ";
                sql = sql + ",Segundo_apellido ='" + txtSegApe.Text + "' ";
                sql = sql + ",Tel =" + txtTel.Text + "";
                sql = sql + ",Direccion ='" + txtDireccion.Text + "' ";
                sql = sql + ",Id_Zona =" + c.zona + "";
                sql = sql + " where CI=" + c.CI;

                try
                {
                    MessageBox.Show(sql);
                    rs = Program.cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return; //error al ejecutar sentencia SQL.
                }
                MessageBox.Show("Datos actualizados correctamente");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            string sql;
            object cantlineas;
            DialogResult result = MessageBox.Show("¿Seguro que quiere modificar los datos en relación a este parámetro?", "Actualizar datos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                gbAlta.Enabled = true;
                btnActualizar.Enabled = true;
                btnAceptar.Enabled = false;
                btnBaja.Enabled = false;

                ClaseCliente c = new ClaseCliente();

                c.RUT = numero(txtRUTb.Text);
                txtRUTb.Text = Convert.ToString(c.RUT);

                c.CI = numero(txtCIb.Text);
                txtCIb.Text = Convert.ToString(c.CI);

                if (txtCIb.Enabled == false)
                {

                    try
                    {

                        if (Program.cn.State != 0)
                        {

                            sql = "SELECT Mail,Tel,Direccion,Nombre_fant FROM cliente INNER JOIN empresa ON empresa.Id_Cliente = cliente.Id_Cliente WHERE RUT=" + c.RUT; //Defino la sentencia SQL
                            try
                            {
                                rs = Program.cn.Execute(sql, out cantlineas);
                            }
                            catch
                            {
                                MessageBox.Show("Error a obtener datos del usuario");
                                return;

                            }
                            if (rs.RecordCount == 0)
                            {
                                MessageBox.Show("No se encontró usuario");
                            }
                            else
                            {
                                gbAlta.Enabled = true; //ACTIVAMOS PARA QUE PUEDA MODIFICAR

                                txtNombre.Hide();
                                lblNombre.Hide();
                                txtPrimerApe.Hide();
                                lblPrimerApe.Hide();
                                txtSegApe.Hide();
                                lblSegApe.Hide();

                                txtEmpresa.Clear();
                                txtEmail.Clear();
                                txtDireccion.Clear();
                                txtTel.Clear();
                                txtNombre.Clear();
                                txtPrimerApe.Clear();
                                txtSegApe.Clear();

                                while (!rs.EOF)
                                {

                                    string mail = rs.Fields[0].Value.ToString();
                                    string Tel = rs.Fields[1].Value.ToString();
                                    string Direccion = rs.Fields[2].Value.ToString();
                                    string Empresa = rs.Fields[3].Value.ToString();

                                    txtEmail.Text = mail;
                                    txtTel.Text = Tel;
                                    txtDireccion.Text = Direccion;
                                    txtEmpresa.Text = Empresa;


                                    rs.MoveNext(); //nos movemos al siguiente registro
                                }

                                CargarZonas();

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    
                }//TRY MODIFICAR RUT
                else
                {
                    try
                    {

                        if (Program.cn.State != 0)
                        {

                            sql = "SELECT Primer_nombre,Primer_apellido,Segundo_apellido,Mail,Tel,Direccion FROM cliente INNER JOIN persona ON persona.Id_Cliente = cliente.Id_Cliente WHERE CI=" + c.CI; //Defino la sentencia SQL
                            try
                            {
                                rs = Program.cn.Execute(sql, out cantlineas);
                            }
                            catch
                            {
                                MessageBox.Show("Error a obtener datos del usuario");
                                return;

                            }
                            if (rs.RecordCount == 0)
                            {
                                MessageBox.Show("No se encontró usuario");
                            }
                            else
                            {
                                gbAlta.Enabled = true; //ACTIVAMOS PARA QUE PUEDA MODIFICAR

                                txtNombre.Show();
                                lblNombre.Show();
                                txtPrimerApe.Show();
                                lblPrimerApe.Show();
                                txtSegApe.Show();
                                lblSegApe.Show();
                                txtEmpresa.Hide();
                                lblEmpresa.Hide();

                                txtEmpresa.Clear();
                                txtEmail.Clear();
                                txtDireccion.Clear();
                                txtTel.Clear();

                                while (!rs.EOF)
                                {

                                    string p_nombre = rs.Fields[0].Value.ToString();
                                    string p_apellido = rs.Fields[1].Value.ToString();
                                    string s_apellido = rs.Fields[2].Value.ToString();
                                    string mail = rs.Fields[3].Value.ToString();
                                    string tel = rs.Fields[4].Value.ToString();
                                    string Direccion = rs.Fields[5].Value.ToString();
                                    //PARA QUE SE CARGEN LOS DATOS EN LOS TXTBOX
                                    txtEmail.Text = mail;
                                    txtTel.Text = tel;
                                    txtDireccion.Text = Direccion;
                                    txtNombre.Text = p_nombre;
                                    txtPrimerApe.Text = p_apellido;
                                    txtSegApe.Text = s_apellido;


                                    rs.MoveNext(); //nos movemos al siguiente registro
                                }

                                CargarZonas();



                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }



            }

        }
    }
}


