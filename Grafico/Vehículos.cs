using Grafico;
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
    public partial class Vehículos : Form
    {
        public Vehículos()
        {
            InitializeComponent();
            gbIngresar.Enabled = false; //Para que no pueda ingresar sin antes buscar
            btnModificar.Enabled = false;
            btnActualizarCapacidad.Enabled = false;
            btnEliminar.Enabled = false;

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

        private void button4_Click(object sender, EventArgs e)
        {
            Program.frmVehículos.Hide();
        }

        private void btnAñadirVehiculo_Click(object sender, EventArgs e)
        {

            ClaseCliente c = new ClaseCliente();

            c.matricula = txtMatricula.Text;
            c.capacidad = numero(txtCapacidad.Text);
            txtCapacidad.Text = Convert.ToString(c.capacidad);


            ADODB.Recordset rs = new ADODB.Recordset();

            if (txtCapacidad.Text == "")
            {
                MessageBox.Show("Debe ingresar capacidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //INVOCO AL MÉTODO GUARDAR
                if (gbIngresar.Enabled == true)
                {
                    byte resultado = c.guardarVehiculo(true);
                    switch (resultado)
                    {
                        case 0:
                            MessageBox.Show("Alta efectuada correctamente");
                            btnAñadirVehiculo.Enabled = false; break;
                        case 1: MessageBox.Show("Debe loguearse nuevamente"); break;
                        case 2: MessageBox.Show("Error sentencia SQL"); break;
                    }

                }


            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClaseCliente c = new ClaseCliente();

            ADODB.Recordset rs = new ADODB.Recordset();

            DialogResult respuesta;

            c.matricula = txtMatricula.Text;
            c.capacidad = numero(txtCapacidad.Text);
            txtCapacidad.Text = Convert.ToString(c.capacidad);

            


            switch (c.buscarmat())
            {
                case 0:  //Encontré
                    MessageBox.Show("La matrícula ya se encuentra en el sistema");
                    gbIngresar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    break;
                case 1: //La conexión está cerrada.
                    MessageBox.Show("Se perdió la sesión. Debe loguearse nuevamente.");
                    break;
                case 2: MessageBox.Show("Error a ejecutar consulta"); break;
                case 4:
                    MessageBox.Show("Hubo errores al efectuar operación");
                    break;
                case 3: //No encontré
                    respuesta = MessageBox.Show("Matrícula no encontrada ¿Desea efectuar el alta?", "¿Alta?", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        btnEliminar.Enabled = false;
                        btnActualizarCapacidad.Enabled = false;
                        btnAñadirVehiculo.Enabled = true;
                        gbIngresar.Enabled = true;
                    }
                    else { gbIngresar.Enabled = false; }

                    break;
            };
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            btnEliminar.Enabled = true;
            lstVehiculos.Items.Clear();


            try
            {

                if (Program.cn.State != 0)
                {


                    sql = "SELECT matricula,capacidad from vehiculo";
                    try
                    {

                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario");
                        return;

                    }
                    if (rs.RecordCount == 0)
                    {
                        MessageBox.Show("No se encontraron datos");
                    }
                    else
                    {

                        while (!rs.EOF)
                        {
                            string matricula = rs.Fields[0].Value.ToString();
                            string capacidad = rs.Fields[1].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            string cadena = matricula + " " + capacidad;
                            lstVehiculos.Items.Add(cadena);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }

                    }
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
                btnModificar.Enabled = false;
                btnActualizarCapacidad.Enabled = true;
                btnAñadirVehiculo.Enabled = false;

                ClaseCliente c = new ClaseCliente();

                c.matricula = txtMatricula.Text;
                c.capacidad = numero(txtCapacidad.Text);
                txtCapacidad.Text = Convert.ToString(c.capacidad);


                try
                {

                    if (Program.cn.State != 0)
                    {

                        sql = "select capacidad from vehiculo where matricula='" + c.matricula + "'";
                        try
                        {
                            rs = Program.cn.Execute(sql, out cantlineas);
                        }
                        catch
                        {
                            MessageBox.Show("Error a obtener datos");
                            return;

                        }
                        if (rs.RecordCount == 0)
                        {
                            MessageBox.Show("No se encontró dato");
                        }
                        else
                        {
                            gbIngresar.Enabled = true; //ACTIVAMOS PARA QUE PUEDA MODIFICAR


                            while (!rs.EOF)
                            {

                                string capacidad = rs.Fields[0].Value.ToString();
                                txtCapacidad.Text = capacidad;

                                rs.MoveNext(); //nos movemos al siguiente registro
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }//TRY MODIFICAR Vehiculo
        }

        private void btnActualizarCapacidad_Click(object sender, EventArgs e)
        {
            ClaseCliente c = new ClaseCliente();

            c.matricula = txtMatricula.Text;
            c.capacidad = numero(txtCapacidad.Text);
            txtCapacidad.Text = Convert.ToString(c.capacidad);

            string sql;
            object cantFilas;
            ADODB.Recordset rs = new ADODB.Recordset();

            sql = "	update vehiculo ";
            sql = sql + "set capacidad ='" + c.capacidad + "'";
            sql = sql + " where matricula = '" + c.matricula + "'";
            try
            {
                MessageBox.Show(sql);
                rs = Program.cn.Execute(sql, out cantFilas);
            }
            catch
            {
                return; //error al ejecutar sentencia SQL.
            }

            MessageBox.Show("Capacidad actualizada correctamente");




        }

        private void Vehículos_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClaseCliente c = new ClaseCliente();
            ADODB.Recordset rs = new ADODB.Recordset();

            string sql;
            object cantlineas;


            c.matricula = txtMatricula.Text;
            c.capacidad = numero(txtCapacidad.Text);
            txtCapacidad.Text = Convert.ToString(c.capacidad);

            
            string letras;
            string numeros;
            string matricula = null;
            string dato = lstVehiculos.Text.ToString();
            string[] palabras = dato.Split(' '); // Dividir el texto en palabras usando un espacio en blanco como separador

            if (palabras.Length > 0)
            {
                letras = palabras[0]; //Traigo valor matricula
                numeros = palabras[1]; //Traigo valor matricula
                matricula = letras + " " + numeros;

            }

            DialogResult result = MessageBox.Show("¿Confirma la baja de este vehículo?", "Baja", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                btnModificar.Enabled = false;
                btnActualizarCapacidad.Enabled = false;
                btnAñadirVehiculo.Enabled = false;

                try
                {
                    if (Program.cn.State != 0)
                    {

                        sql = "delete from vehiculo where matricula='" + matricula + "'";
                        try
                        {
                            rs = Program.cn.Execute(sql, out cantlineas);
                        }
                        catch
                        {
                            MessageBox.Show("Error a obtener datos de matricula");
                            return;
                        }
                        if (rs.RecordCount == 0)
                        {
                            MessageBox.Show("No se encontró matrícula");
                        }
                        MessageBox.Show("Vehículo dado de baja correctamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }//TRY MODIFICAR Vehiculo
        }

        private void lstVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

