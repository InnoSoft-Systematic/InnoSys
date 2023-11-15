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
    public partial class EstadoEnvios : Form
    {
        public EstadoEnvios()
        {
            InitializeComponent();
            string Id_Pedido = "";
            string Id_Caja = "";
            string dgestado = "";
            btnRechazar.Enabled = false;
            btnEntregado.Enabled = false;
            btnRechazado.Enabled = false;
            btnEnviado.Enabled = false;
            btnConfirmado.Enabled = false;
            btnRechazar.Enabled = false;
            lblEntregado.Hide();

            
        }

        private dynamic Id_Pedido { get; set; }
        private dynamic Id_Caja { get; set; }
        private dynamic dgestado { get; set; }
        private void btmVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lstEnvios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            try
            {

                if (Program.cn.State != 0)
                {



                    sql = "select pedido.Id_Pedido,estados_pedido.estado,p_pasa_por.fecha_solicitud,cliente.Tel,zona.nombre,cliente.Direccion from pedido,cliente,p_pasa_por,estados_pedido,zona where pedido.Id_Cliente = cliente.Id_Cliente and estados_pedido.Id_Estado_p = p_pasa_por.Id_Estado_p and pedido.Id_Pedido = p_pasa_por.Id_Pedido and cliente.Id_Zona = zona.Id_Zona and p_pasa_por.fecha_entrega is null";
                    try
                    {

                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de la consula main");
                        return;

                    }
                    if (rs.RecordCount == 0)
                    {
                        MessageBox.Show("No se encontraron datos");
                    }
                    else
                    {
                        //Creamos tabla
                        DataTable dataTable = new DataTable();
                        //Creamos columnas
                        dataTable.Columns.Add("ID", typeof(int));
                        dataTable.Columns.Add("Estado", typeof(string));
                        dataTable.Columns.Add("Fecha Solicitud", typeof(DateTime));
                        dataTable.Columns.Add("Teléfono", typeof(int));
                        dataTable.Columns.Add("Zona", typeof(string));
                        dataTable.Columns.Add("Dirección", typeof(string));



                        while (!rs.EOF)
                        {
                            int id = Convert.ToInt32(rs.Fields[0].Value);
                            string estado = rs.Fields[1].Value.ToString();
                            DateTime fechael = rs.Fields[2].Value;
                            int tel = Convert.ToInt32(rs.Fields[3].Value);
                            string zona = rs.Fields[4].Value.ToString();
                            string dir = rs.Fields[5].Value.ToString();




                            //Relacionamos los datos
                            dataTable.Rows.Add(id, estado, fechael, tel, zona, dir);

                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }
                        //Agregamos a la tabla

                        dgEstados.DataSource = dataTable;

                    }
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnVerConsulta_Click(object sender, EventArgs e)
        {

            if (Login.rol.ToString() == "Gerente")
            {
                btnConfirmado.Enabled = false;
                btnEnviado.Enabled = false;
                btnEntregado.Enabled = false;
                btnRechazado.Enabled = false;
                btnRechazar.Enabled = false;

            }

            //Tomo dos valores en los cuales podré usarlos para resolver condiciones
            if (dgEstados.SelectedRows.Count > 0)
            {

                DataGridViewRow filaSeleccionada = dgEstados.SelectedRows[0];

                // Obtengo valor de una celda específica
                object valorCelda = filaSeleccionada.Cells["ID"].Value;
                object valorEstado = filaSeleccionada.Cells["Estado"].Value;


                // Realizar acciones con el valor de la celda
                Id_Pedido = valorCelda.ToString();
                dgestado = valorEstado.ToString();
                btnRechazar.Enabled = true;

            }

            else
            {
                MessageBox.Show("Debe seleccionar una fila completa");
                btnRechazar.Enabled = false;

            }
            if (dgestado == "Solicitado")
            {
                MessageBox.Show("Los pedidos solicitados no se pueden gestionar");

                btnEnviado.Enabled = false;
                btnEntregado.Enabled = false;
                btnRechazar.Enabled = false;

                btnEntregado.BackColor = Color.Gray;
                btnRechazado.BackColor = Color.Gray;
                btnEnviado.BackColor = Color.Gray;
                btnConfirmado.BackColor = Color.Gray;
            }

            if (dgestado == "Confirmado")
            {
                btnConfirmado.BackColor = Color.DarkGreen;
                btnEnviado.BackColor = Color.Blue;
                btnEntregado.BackColor = Color.Gray;
                btnRechazado.BackColor = Color.Gray;

                if (Login.rol.ToString() == "Gerente")
                {
                    btnConfirmado.Enabled = false;
                    btnEnviado.Enabled = false;
                    btnEntregado.Enabled = false;
                    btnRechazado.Enabled = false;
                    btnRechazar.Enabled = false;

                }
                else
                {
                    btnEnviado.Enabled = true;
                    btnEntregado.Enabled = false;
                    btnRechazar.Enabled = true;
                }

                lblEntregado.Hide();
            }

            if (dgestado == "Enviado")
            {
                btnConfirmado.BackColor = Color.DarkGreen;
                btnEnviado.BackColor = Color.DarkGreen;
                btnEntregado.BackColor = Color.Blue;
                btnRechazado.BackColor = Color.Gray;

                if (Login.rol.ToString() == "Gerente")
                {
                    btnConfirmado.Enabled = false;
                    btnEnviado.Enabled = false;
                    btnEntregado.Enabled = false;
                    btnRechazado.Enabled = false;
                    btnRechazar.Enabled = false;

                }
                else
                {
                    btnEnviado.Enabled = false;
                    btnEntregado.Enabled = true;

                    btnRechazar.Enabled = false;
                }


                //Solo en estado enviado habilitamos botón DEVUELTO


                lblEntregado.Hide();

            }

            if (dgestado == "Entregado")
            {
                btnConfirmado.BackColor = Color.DarkGreen;
                btnEnviado.BackColor = Color.DarkGreen;
                btnEntregado.BackColor = Color.DarkGreen;
                btnRechazado.BackColor = Color.Gray;

                if (Login.rol.ToString() == "Gerente")
                {
                    btnConfirmado.Enabled = false;
                    btnEnviado.Enabled = false;
                    btnEntregado.Enabled = false;
                    btnRechazado.Enabled = false;
                    btnRechazar.Enabled = false;

                }
                else
                {
                    btnConfirmado.Enabled = false;
                    btnEnviado.Enabled = false;
                    btnEntregado.Enabled = false;
                    btnRechazar.Enabled = false;
                }




                lblEntregado.Show();

            }

            if (dgestado == "Rechazado")
            {
                btnConfirmado.BackColor = Color.Gray;
                btnEnviado.BackColor = Color.Gray;
                btnEntregado.BackColor = Color.Gray;
                btnRechazado.BackColor = Color.Red;

                if (Login.rol.ToString() == "Gerente")
                {
                    btnConfirmado.Enabled = false;
                    btnEnviado.Enabled = false;
                    btnEntregado.Enabled = false;
                    btnRechazado.Enabled = false;
                    btnRechazar.Enabled = false;

                }else
                {

                    btnConfirmado.Enabled = false;
                    btnEnviado.Enabled = false;
                    btnEntregado.Enabled = false;
                }



                lblEntregado.Hide();
            }

            if (dgestado == "Devuelto")
            {
                //Si se devuelve la caja, se habilitará la opción de CONFIRMARLO NUEVAMENTE para enviarlo O RECHAZARLO


                btnConfirmado.BackColor = Color.Gray;
                btnEnviado.BackColor = Color.Gray;
                btnEntregado.BackColor = Color.Gray;
                btnRechazado.BackColor = Color.Gray;

                if (Login.rol.ToString() == "Gerente")
                {
                    btnConfirmado.Enabled = false;
                    btnEnviado.Enabled = false;
                    btnEntregado.Enabled = false;
                    btnRechazado.Enabled = false;
                    btnRechazar.Enabled = false;

                }
                else
                {
                    btnConfirmado.Enabled = true;
                    btnEnviado.Enabled = false;
                    btnEntregado.Enabled = false;
                    btnRechazar.Enabled = true;
                }



                lblEntregado.Hide();

            }

        }

        private void btnEnviado_Click(object sender, EventArgs e)
        {

            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            //ACTUALIZAMOS LA FECHA ENTREGA A CURRENT TIME Y CREAMOS UN NUEVO PROCESO
            sql = "UPDATE p_pasa_por";
            sql = sql + " set fecha_entrega = CURRENT_TIME()";
            sql = sql + " where Id_Estado_p = 2 AND Id_Pedido=" + Id_Pedido;
            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error a obtener datos de p_pasa_por");
                return;
            }

            //INSERTO NUEVO ESTADO A ENVIADO
            sql = "insert into p_pasa_por (Id_Estado_p,Id_Pedido)";
            sql = sql + " values (3," + Id_Pedido + ")";
            //ENVIADO = 3
            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);

            }
            catch
            {
                //MessageBox.Show(sql);
                MessageBox.Show("Error a insertar en tabla p_pasa_por");
                return;

            }

            btnEnviado.Enabled = false;
            btnEnviado.BackColor = Color.DarkGreen;
            btnEntregado.Enabled = true;
            btnActualizar_Click(this, EventArgs.Empty);

        }

        private void EstadoEnvios_Load(object sender, EventArgs e)
        {

        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            //ACTUALIZAMOS LA FECHA ENTREGA A CURRENT TIME Y CREAMOS UN NUEVO PROCESO
            sql = "UPDATE p_pasa_por";
            sql = sql + " set fecha_entrega = CURRENT_TIME()";
            sql = sql + " where Id_Estado_p = 3 AND Id_Pedido=" + Id_Pedido;
            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error a obtener datos de p_pasa_por");
                return;
            }

            //INSERTO NUEVO ESTADO A ENVIADO
            sql = "insert into p_pasa_por (Id_Estado_p,Id_Pedido)";
            sql = sql + " values (4," + Id_Pedido + ")";
            //ENVIADO = 3
            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);

            }
            catch
            {
                //MessageBox.Show(sql);
                MessageBox.Show("Error a insertar en tabla p_pasa_por");
                return;

            }

            btnEntregado.Enabled = false;
            btnEntregado.BackColor = Color.DarkGreen;

            btnActualizar_Click(this, EventArgs.Empty);
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            //ACTUALIZAMOS LA FECHA ENTREGA A CURRENT TIME Y CREAMOS UN NUEVO PROCESO
            sql = "UPDATE p_pasa_por";
            sql = sql + " set fecha_entrega = CURRENT_TIME()";

            if (btnEnviado.Enabled == true)
            {
                sql = sql + " where Id_Estado_p = 2 AND Id_Pedido=" + Id_Pedido;
            }
            if (btnEnviado.Enabled == false)
            {
                sql = sql + " where Id_Estado_p = 3 AND Id_Pedido=" + Id_Pedido;
            }

            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error a obtener datos de p_pasa_por");
                return;
            }

            //INSERTO NUEVO ESTADO A RECHAZADO
            sql = "insert into p_pasa_por (Id_Estado_p,Id_Pedido)";
            sql = sql + " values (5," + Id_Pedido + ")";
            //ENVIADO = 3
            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);

            }
            catch
            {
                //MessageBox.Show(sql);
                MessageBox.Show("Error a insertar en tabla p_pasa_por");
                return;

            }
            btnConfirmado.Enabled = false;
            btnEnviado.Enabled = false;
            btnEntregado.Enabled = false;
            btnRechazar.Enabled = false;

            btnRechazado.BackColor = Color.Red;
            btnRechazar.BackColor = Color.Gray;
            btnConfirmado.BackColor = Color.Gray;
            btnEnviado.BackColor = Color.Gray;
            btnRechazado.BackColor = Color.Gray;



            btnActualizar_Click(this, EventArgs.Empty);
        }

        private void btnRechazado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDevuelto_Click(object sender, EventArgs e)
        {

        }
    }
}
