using ADODB;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InnoSys
{
    public partial class ModEstados : Form
    {
        public ModEstados()
        {
            InitializeComponent();
            string Id_Estado = "";
            string Id_Caja = "";
            string dgestado = "";
            string Id_Menu = "";
            string Id_Pedido = "";
            btnDesechar.Enabled = false;
            btnStock.Enabled = false;
            btnEnvasado.Enabled = false;
            btnEntregado.Enabled = false;
            btnProduccion.Enabled = false;
            btnDevuelto.Enabled = false;
            btnDesechado.Enabled = false;


        }
        private dynamic Id_Estado { get; set; }
        private dynamic Id_Caja { get; set; }
        private dynamic dgestado { get; set; }
        private dynamic Id_Menu { get; set; }

        private dynamic Id_Pedido { get; set; }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lstEnvios_SelectedIndexChanged(object sender, EventArgs e)
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



                    sql = "select caja.Id_Caja,menu.nombre,estados_de_m.tipo_de_estado,fecha_elaboracion,fecha_vencimiento from caja,c_pasa_por,estados_de_m,menu where c_pasa_por.Id_Caja = caja.Id_Caja and estados_de_m.Id_Estado_m = c_pasa_por.Id_Estado_m and menu.Id_Menu = caja.Id_Menu and c_pasa_por.fecha_fin is null";
                    try
                    {

                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de MENU");
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
                        dataTable.Columns.Add("Menú", typeof(string));
                        dataTable.Columns.Add("Estado", typeof(string));
                        dataTable.Columns.Add("Fecha Elaboración", typeof(DateTime));
                        dataTable.Columns.Add("Fecha Vencimiento", typeof(DateTime));


                        while (!rs.EOF)
                        {
                            int id = Convert.ToInt32(rs.Fields[0].Value);
                            string estado = rs.Fields[1].Value.ToString();
                            string menu = rs.Fields[2].Value.ToString();
                            DateTime fechael = rs.Fields[3].Value;
                            DateTime fechaven = rs.Fields[4].Value;

                            //Relacionamos los datos
                            dataTable.Rows.Add(id, estado, menu, fechael, fechaven);

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

        private void ModEstados_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterarEstado_Click(object sender, EventArgs e)
        {

            //Tomo dos valores en los cuales podré usarlos para resolver condiciones
            if (dgEstados.SelectedRows.Count > 0)
            {

                DataGridViewRow filaSeleccionada = dgEstados.SelectedRows[0];

                // Obtengo valor de una celda específica
                object valorCelda = filaSeleccionada.Cells["ID"].Value;
                object valorEstado = filaSeleccionada.Cells["Estado"].Value;


                // Realizar acciones con el valor de la celda
                Id_Caja = valorCelda.ToString();
                dgestado = valorEstado.ToString();
                btnDesechar.Enabled = true;

            }

            else
            {
                MessageBox.Show("Debe seleccionar una fila completa");
                btnDesechar.Enabled = false;

            }

            //TRAIGO VALOR DE Id_Menu para usarlo después en stock
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            sql = "select menu.Id_Menu from menu,caja where caja.Id_Menu = menu.Id_Menu and caja.Id_Caja=" + Id_Caja;
            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);
                Id_Menu = rs.Fields[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error a obtener datos de MENU");
                return;

            }

            if (dgestado == "En stock")
            {
                btnStock.BackColor = Color.Green;
                btnProduccion.BackColor = Color.Blue;
                btnEnvasado.BackColor = Color.Gray;
                btnProduccion.Enabled = true;
            }

            if (dgestado == "En producción")
            {
                btnStock.BackColor = Color.Green;
                btnProduccion.BackColor = Color.Green;
                btnEnvasado.BackColor = Color.Blue;

                btnProduccion.Enabled = false;
                btnEnvasado.Enabled = true;
            }

            if (dgestado == "Envasado")
            {
                btnStock.BackColor = Color.Green;
                btnProduccion.BackColor = Color.Green;
                btnEnvasado.BackColor = Color.Green;

                btnEnvasado.Enabled = false;
                btnProduccion.Enabled = false;
                btnEnvasado.Enabled = false;

            }

            if (dgestado == "Entregado")
            {
                btnStock.BackColor = Color.Green;
                btnProduccion.BackColor = Color.Green;
                btnEnvasado.BackColor = Color.Green;

                btnEnvasado.Enabled = false;
                btnProduccion.Enabled = false;
                btnEnvasado.Enabled = false;
                btnDesechar.Enabled = false;
            }

            if (dgestado == "Devuelto")
            {
                btnDevuelto.BackColor = Color.Yellow;

                btnEnvasado.Enabled = false;
                btnProduccion.Enabled = false;
                btnEnvasado.Enabled = false;
                btnDesechar.Enabled = false;
            }

            if (dgestado == "Desechado")
            {
                btnDesechado.BackColor = Color.Yellow;
                btnDevuelto.BackColor = Color.Gray;
                btnDevuelto.BackColor = Color.Gray;

                btnEnvasado.Enabled = false;
                btnProduccion.Enabled = false;
                btnEnvasado.Enabled = false;
                btnDesechar.Enabled = false;

            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {

        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            //AL CAMBIAR EL ESTADO, SE GENERA SU FECHA FIN DE ESTADO
            sql = "UPDATE c_pasa_por";
            sql = sql + " set fecha_fin = CURRENT_TIME()";
            sql = sql + " where Id_Estado_m = 2 AND Id_Caja=" + Id_Caja;

            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error a obtener datos de update c_pasa_por");
                return;

            }
            //AL CAMBIAR EL ESTADO, TAMBIEN SE CREA UN NUEVO ESTADO en c_pasa_por
            sql = "insert into c_pasa_por (Id_Estado_m,Id_Caja)";
            sql = sql + " values (3," + Id_Caja + ")";
            //En producción = 3
            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);
                MessageBox.Show(sql);
            }
            catch
            {
                MessageBox.Show(sql);
                MessageBox.Show("Error a obtener datos de insert");
                return;

            }

            //MODIFICO EL STOCK RESTANDO Y AGREGANDO UNA PRODUCCION

            sql = "update stock";
            sql = sql + " SET stock_actual = stock_actual -1";
            //sql = sql + ", producido";
            sql = sql + " where Id_Menu=" + Id_Menu;

            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);
                MessageBox.Show(sql);
            }
            catch
            {
                MessageBox.Show("Error a actualizar datos de stock" + sql);

                return;

            }

            btnProduccion.Enabled = false;
            btnEnvasado.Enabled = true;
            btnDevuelto.Enabled = true;

            btnDevuelto.BackColor = Color.Blue;
            btnStock.BackColor = Color.Green;
            btnProduccion.BackColor = Color.Green;
            btnEnvasado.BackColor = Color.Blue;
            btnDesechado.BackColor = Color.Gray;


            //LLAMO A ACTUALIZAR BOTON PARA ACTUALIZAR LOS DATOS
            btnActualizar_Click(this, EventArgs.Empty);

        }

        private void btnEnvasado_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            //AL CAMBIAR EL ESTADO, SE GENERA SU FECHA FIN DE ESTADO
            sql = "UPDATE c_pasa_por";
            sql = sql + " set fecha_fin = CURRENT_TIME()";
            sql = sql + " where Id_Estado_m = 3 AND Id_Caja=" + Id_Caja;

            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error a obtener datos de update c_pasa_por");
                return;

            }

            //AL CAMBIAR EL ESTADO, TAMBIEN SE CREA UN NUEVO ESTADO en c_pasa_por
            sql = "insert into c_pasa_por (Id_Estado_m,Id_Caja)";
            sql = sql + " values (4," + Id_Caja + ")";
            //En producción = 3
            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);

            }
            catch
            {
                //MessageBox.Show(sql);
                MessageBox.Show("Error a obtener datos de insert");
                return;

            }
            //BUSCO Id_Pedido en relación a la caja que estoy modificando
            sql = "SELECT caja.Id_Pedido from caja,p_pasa_por where caja.Id_Pedido = p_pasa_por.Id_Pedido and caja.Id_Caja=" + Id_Caja;
            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);
                Id_Pedido = rs.Fields[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error a obtener datos de select Id_Pedido");
                return;

            }

            //UNA VEZ QUE LA CAJA PASA A ENVASADO, CAMBIA EL ESTADO DE PEDIDO A CONFIRMADO, NO SIN ANTES AGREGARLE FECHA FIN AL ANTERIOR PROCESO
            sql = "UPDATE p_pasa_por";
            sql = sql + " set fecha_entrega = CURRENT_TIME()";
            sql = sql + " where Id_Estado_p = 1 AND Id_Pedido=" + Id_Pedido;
            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error a obtener datos de p_pasa_por");
                return;
            }

            //INSERTO NUEVO ESTADO A CONFIRMADO
            sql = "insert into p_pasa_por (Id_Estado_p,Id_Pedido)";
            sql = sql + " values (2," + Id_Pedido + ")";
            //CONFIRMADO = 2
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

            btnProduccion.Enabled = false;
            btnEnvasado.Enabled = false;
            btnDevuelto.Enabled = true;
            btnDevuelto.BackColor = Color.Blue;
            btnStock.BackColor = Color.Green;
            btnProduccion.BackColor = Color.Green;
            btnEnvasado.BackColor = Color.Green;
            btnDesechado.BackColor = Color.Gray;

            btnActualizar_Click(this, EventArgs.Empty);
        }

        private void btnDevuelto_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            //AL CAMBIAR EL ESTADO, SE GENERA SU FECHA FIN DE ESTADO
            sql = "UPDATE c_pasa_por";
            sql = sql + " set fecha_fin = CURRENT_TIME()";

            //COMO CAMBIO LOS ESTADOS DE DOS VALORES DIFERENTES, HICE CONDICION CON SUS RESPECTIVOS BOTONES
            if (btnEnvasado.Enabled == true)
            {
                sql = sql + " where Id_Estado_m = 3 AND Id_Caja=" + Id_Caja;
            }
            if (btnEnvasado.Enabled == false)
            {
                sql = sql + " where Id_Estado_m = 4 AND Id_Caja=" + Id_Caja;
            }

            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error a obtener datos de update c_pasa_por");
                return;

            }

            //AL CAMBIAR EL ESTADO A DEVUELTO, TAMBIEN SE CREA UN NUEVO ESTADO en c_pasa_por
            sql = "insert into c_pasa_por (Id_Estado_m,Id_Caja)";
            sql = sql + " values (6," + Id_Caja + ")";

            try
            {

                rs = Program.cn.Execute(sql, out filasAfectadas);

            }
            catch
            {
                //MessageBox.Show(sql);
                MessageBox.Show("Error a obtener datos de insert c_pasa_por");
                return;
            }
            btnDevuelto.Enabled = false;
            btnDevuelto.BackColor = Color.Yellow;
            btnStock.BackColor = Color.Gray;
            btnProduccion.BackColor = Color.Gray;
            btnEnvasado.BackColor = Color.Gray;
            btnActualizar_Click(this, EventArgs.Empty);
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            //ACTUALIZO VALORES, AGREGO FECHA FINAL AL ESTADO ACTUAL
            sql = "UPDATE c_pasa_por";
            sql = sql + " set fecha_fin = CURRENT_TIME()";

            if (dgestado == "En stock")
            {
                sql = sql + " where Id_Estado_m = 2 AND Id_Caja=" + Id_Caja;
            }
            if (dgestado == "En producción")
            {
                sql = sql + " where Id_Estado_m = 3 AND Id_Caja=" + Id_Caja;
            }
            if (dgestado == "Envasado")
            {
                sql = sql + " where Id_Estado_m = 4 AND Id_Caja=" + Id_Caja;
            }

            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error a obtener datos de c_pasa_por");
                return;
            }

            //INSERTO NUEVO ESTADO A DESECHADO
            sql = "insert into c_pasa_por (Id_Estado_m,Id_Caja)";
            sql = sql + " values (7," + Id_Caja + ")";
            //RECHAZADO
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

            btnDesechado.BackColor = Color.Yellow;
            btnStock.BackColor = Color.Gray;
            btnProduccion.BackColor = Color.Gray;
            btnEnvasado.BackColor = Color.Gray;
            btnDesechar.BackColor = Color.Gray;



            btnDesechado.Enabled = false;
            btnDesechar.Enabled = false;
            btnProduccion.Enabled = false;
            btnEnvasado.Enabled = false;

            btnActualizar_Click(this, EventArgs.Empty);
        }

        private void btnDesechado_Click(object sender, EventArgs e)
        {

        }
    }
}
