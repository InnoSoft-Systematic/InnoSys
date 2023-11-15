using ADODB;
using InnoSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            gbFijog.Enabled = false;
            gbPersonalizado.Enabled = false;
            gbTipoMenu.Enabled = false;
            string Id_Menu = "";
            string tipo = "";
            string Id_Vianda = "";
            string Id_Cliente = "";
            string Id_Pedido = "";
            string Id_Caja = "";
            int stock = 0;

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

        //STRING ID MENU ESTATICO GLOBAL
        public dynamic Id_Menu { get; private set; }
        public dynamic Id_Pedido { get; private set; }
        public dynamic Id_Caja { get; private set; }
        public dynamic tipo { get; private set; }
        public dynamic stock { get; private set; }
        public dynamic Id_Vianda { get; private set; }
        public dynamic Id_Cliente { get; private set; }
        private void InsertarViandaRelacion(Recordset rs, string valor)
        {
            object filasAfectadas;
            string sql = $"INSERT INTO conforma (Id_Vianda,Id_Menu) VALUES ('{valor}'," + Id_Menu + ")";

            rs = Program.cn.Execute(sql, out filasAfectadas);

            // Puedes realizar alguna operación adicional si es necesario
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

            lstPedidoCliente.Items.Clear();

            switch (c.buscar())
            {
                case 0:  //Encontré
                    //MessageBox.Show("Cédula encontrada");
                    gbTipoMenu.Enabled = true;

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
                    gbTipoMenu.Enabled = false;
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
                    MessageBox.Show("Error en en sinstaxis SQL"); //error al ejecutar sentencia SQL.
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
                btnActualizar_Click(this, EventArgs.Empty);
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

            lstPedidoCliente.Items.Clear();

            switch (c.buscarRUT())
            {
                case 0:  //Encontré
                    //MessageBox.Show("RUT encontrado");
                    gbTipoMenu.Enabled = true;

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
                btnActualizar_Click(this, EventArgs.Empty);
                
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

        private void chlViandas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            chlViandas.Items.Clear();

            string Id_Menu;

            try
            {

                if (Program.cn.State != 0)
                {


                    sql = "SELECT Id_Vianda,nombre from vianda";
                    try
                    {

                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de vianda");
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
                            Id_Vianda = rs.Fields[0].Value.ToString();
                            string vianda = rs.Fields[1].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            chlViandas.Items.Add(Id_Vianda + " " + vianda);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }

                    }
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


            cboMenu.Items.Clear();


            try
            {

                if (Program.cn.State != 0)
                {


                    sql = "SELECT Id_Menu,nombre,tipo_menu from menu where not nombre='Personalizado'";
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
                            Id_Menu = rs.Fields[0].Value.ToString();
                            string menu = rs.Fields[1].Value.ToString();
                            string tipo = rs.Fields[2].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            cboMenu.Items.Add(Id_Menu + " " + menu + " " + tipo);
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

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void rboFijo_CheckedChanged(object sender, EventArgs e)
        {
            if (rboFijo.Checked)
            {
                gbFijog.Enabled = true;
                gbPersonalizado.Enabled = false;
            }
            if (!rboFijo.Checked)
            {
                gbPersonalizado.Enabled = true;
                gbPersonalizado.Enabled = false;
            }
        }

        private void cboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblInformacionClienteRUT_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ClaseCliente c = new ClaseCliente();
            string sql;
            object cantFilas;



            //Tomo el nombre del menú
            string menu = cboMenu.Text.ToString();
            //Tomo la cantidad de pedidos que serán cantidad de CAJAS

            c.conexion = Program.cn;
            ADODB.Recordset rs = new ADODB.Recordset();


            string dato = cboMenu.Text.ToString();
            string[] palabras = dato.Split(' '); // Dividir el texto en palabras usando un espacio en blanco como separador

            //BUSCO ID MENU
            if (palabras.Length > 0)
            {
                Id_Menu = palabras[0]; //Traigo valor Id_Menu

            }


            if (c.conexion.State == 0)
            {
                MessageBox.Show("Conexion cerrada");
            }

            //BUSCO STOCK ACTUAL DEL MENU INGRESADO PARA VERIFICAR SI HAY STOCK
            sql = "select stock_actual from stock,menu where menu.Id_Menu = stock.Id_Menu AND menu.Id_Menu=" + Id_Menu;
            try
            {

                rs = Program.cn.Execute(sql, out cantFilas, -1);
                stock = Convert.ToInt32(rs.Fields[0].Value);
                //MessageBox.Show(stock.ToString());

            }
            catch
            {
                MessageBox.Show("No hay stock para el menú seleccionado");
            }


            if (btnBCI.Enabled == false)
            {

                if (stock > 1)
                {
                    //BUSCO ID CLIENTE EMPRESA
                    sql = "SELECT empresa.Id_Cliente from cliente INNER JOIN empresa ON empresa.Id_Cliente = cliente.Id_Cliente where RUT = " + txtRUTb.Text;

                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas, -1); //resultado RS
                        Id_Cliente = rs.Fields[0].Value.ToString();
                    }//TRY
                    catch
                    {
                        MessageBox.Show("Error sentencia SQL cliente"); //error al ejecutar sentencia SQL.
                        return;
                    }//CATCH


                    //PASARLO A UNA CLASE?
                    //INSERTO PEDIDO
                    sql = "insert into pedido (Id_Cliente)";
                    sql = sql + " values('" + Id_Cliente + "')";

                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejecutar sentencia para PEDIDO");
                    }

                    //BUSCO ÚLITMO Id_Pedido
                    sql = "select MAX(Id_Pedido) from pedido";

                    try
                    {

                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                        Id_Pedido = rs.Fields[0].Value.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta MAX");
                    }

                    //INSERTO en TABLA p_pasa_por
                    sql = "insert into p_pasa_por (Id_Estado_p,Id_Pedido)";
                    //Id_Estado_p en numero 1 = Solicitado
                    sql = sql + " values('" + 1 + "'," + Id_Pedido + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta p_pasa_por");
                    }

                    //INSERTO en TABLA estado_pedido
                    sql = "insert into estado_pedido (Id_Cliente,Id_Pedido,Id_Estado_p)";
                    //Id_Estado_p en numero 1 = Solicitado
                    sql = sql + " values(" + Id_Cliente + "," + Id_Pedido + "," + 2 + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta estado_pedido");
                    }


                    //CAJA


                    //INSERTO EN TABLA caja
                    // 40 DIAS POR SU FECHA DE VENCIMIENTO CAJA

                    sql = "insert into caja (fecha_vencimiento,Id_Pedido,Id_Menu)";
                    sql = sql + " values(CURRENT_DATE() + INTERVAL 40 DAY," + Id_Pedido + "," + Id_Menu + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);


                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta caja");
                    }

                    //Busco Id_Caja
                    sql = "select MAX(Id_Caja) from caja";
                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                        Id_Caja = rs.Fields[0].Value.ToString();

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta MAX");
                    }

                    //INSERTO EN TABLA caja_sucursal
                    //Aplico la sucursal que está seleccionada en Sucursales
                    
                    Sucursales s = new Sucursales();


                    sql = "insert into caja_sucursal (Id_Caja,Id_Sucursal)";
                    sql = sql + " values(" + Id_Caja + "," + 1 + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta caja_sucursal");
                    }

                    //INSERTO EN compone
                    sql = "insert into compone (Id_Caja,Id_Pedido)";
                    sql = sql + " values(" + Id_Caja + "," + Id_Pedido + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta compone");
                    }

                    //INSERTO en envasa

                    sql = "insert into envasa (Id_Menu, Id_Caja)";
                    sql = sql + " values(" + Id_Menu + "," + Id_Caja + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);


                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta envasa");
                    }

                    //INSERTO en c_pasa_por
                    //fecha_fin queda NULO hasta que se cambie de estado
                    sql = "insert into c_pasa_por (Id_Estado_m,Id_Caja)";
                    sql = sql + " values(" + 2 + "," + Id_Caja + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta c_pasa_por");
                    }

                    //CARGO EN LA LISTA
                    sql = "SELECT menu.nombre, menu.tipo_menu from menu where Id_Menu=" + Id_Menu;

                    try
                    {

                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de vianda");
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
                            string nombre = rs.Fields[0].Value.ToString();
                            string tipo = rs.Fields[1].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            lstPedidoCliente.Items.Add(nombre + " " + tipo);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }
                    }

                    MessageBox.Show("Pedido ingresado correctamente");
                }
                else
                {
                    MessageBox.Show("No hay stock de menú seleccionado");

                }
                

            }


            if (btnBCI.Enabled == true)
            {
                if (stock > 1)
                {
                    //BUSCO CLIENTE PERSONA
                    sql = "SELECT cliente.Id_Cliente from cliente INNER JOIN persona ON persona.Id_Cliente = cliente.Id_Cliente where CI =" + txtCIb.Text;

                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas, -1); //resultado RS
                        Id_Cliente = rs.Fields[0].Value.ToString();
                    }//TRY
                    catch
                    {
                        MessageBox.Show("Error sentencia SQL cliente"); //error al ejecutar sentencia SQL.
                        return;
                    }//CATCH


                    //PASARLO A UNA CLASE?
                    //INSERTO PEDIDO
                    sql = "insert into pedido (Id_Cliente)";
                    sql = sql + " values('" + Id_Cliente + "')";

                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejecutar sentencia para PEDIDO");
                    }

                    //BUSCO ÚLITMO Id_Pedido
                    sql = "select MAX(Id_Pedido) from pedido";

                    try
                    {

                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                        Id_Pedido = rs.Fields[0].Value.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta MAX");
                    }

                    //INSERTO en TABLA p_pasa_por
                    sql = "insert into p_pasa_por (Id_Estado_p,Id_Pedido)";
                    //Id_Estado_p en numero 1 = Solicitado
                    sql = sql + " values('" + 1 + "'," + Id_Pedido + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta p_pasa_por");
                    }

                    //INSERTO en TABLA estado_pedido
                    sql = "insert into estado_pedido (Id_Cliente,Id_Pedido,Id_Estado_p)";
                    //Id_Estado_p en numero 1 = Solicitado
                    sql = sql + " values(" + Id_Cliente + "," + Id_Pedido + "," + 2 + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta estado_pedido");
                    }


                    //CAJA


                    //INSERTO EN TABLA caja
                    // 40 DIAS POR SU FECHA DE VENCIMIENTO CAJA

                    sql = "insert into caja (fecha_vencimiento,Id_Pedido,Id_Menu)";
                    sql = sql + " values(CURRENT_DATE() + INTERVAL 40 DAY," + Id_Pedido + "," + Id_Menu + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);


                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta caja");
                    }

                    //Busco Id_Caja
                    sql = "select MAX(Id_Caja) from caja";
                    try
                    {

                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                        Id_Caja = rs.Fields[0].Value.ToString();


                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta MAX");
                    }

                    //INSERTO EN TABLA caja_sucursal
                    //Sujeto a edición, por defecto sucursal 1
                    sql = "insert into caja_sucursal (Id_Caja,Id_Sucursal)";
                    sql = sql + " values(" + Id_Caja + "," + 1 + ")";

                    try
                    {

                        rs = Program.cn.Execute(sql, out cantFilas, -1);


                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta caja_sucursal");
                    }
                    //INSERTO EN compone
                    sql = "insert into compone (Id_Caja,Id_Pedido)";
                    sql = sql + " values(" + Id_Caja + "," + Id_Pedido + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta compone");
                    }

                    //INSERTO en envasa

                    sql = "insert into envasa (Id_Menu, Id_Caja)";
                    sql = sql + " values(" + Id_Menu + "," + Id_Caja + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);


                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta envasa");
                    }

                    //INSERTO en c_pasa_por
                    //fecha_fin queda NULO hasta que se cambie de estado
                    sql = "insert into c_pasa_por (Id_Estado_m,Id_Caja)";
                    sql = sql + " values(" + 2 + "," + Id_Caja + ")";

                    try
                    {
                        //MessageBox.Show(Id_Caja);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta c_pasa_por");
                    }


                    //CARGO EN LA LISTA
                    sql = "SELECT menu.nombre, menu.tipo_menu from menu where Id_Menu=" + Id_Menu;

                    try
                    {

                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de vianda");
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
                            string nombre = rs.Fields[0].Value.ToString();
                            string tipo = rs.Fields[1].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            lstPedidoCliente.Items.Add(nombre + " " + tipo);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }
                    }
                    MessageBox.Show("Pedido ingresado correctamente");
                }
                else
                {
                    MessageBox.Show("No hay stock de menú seleccionado");

                }
                
            }


        }


        private void rboMensual_CheckedChanged(object sender, EventArgs e)
        {
            if (rboMensual.Checked)
            {
                tipo = "Mensual";
            }
            else
            { tipo = ""; }
        }

        private void rboPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            if (rboPersonalizado.Checked)
            {
                gbFijog.Enabled = false;
                gbPersonalizado.Enabled = true;
            }
            if (!rboPersonalizado.Checked)
            {
                gbPersonalizado.Enabled = false;
                gbPersonalizado.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClaseCliente c = new ClaseCliente();
            string sql;
            object cantFilas;
            ADODB.Recordset rs = new ADODB.Recordset();
            try
            {

                if (Program.cn.State == 0)
                {
                    MessageBox.Show("Conexion cerrada");
                }
                else
                {
                    //INSERTO DATOS EN MENU
                    sql = "insert into menu (nombre,tipo_menu)";
                    sql = sql + " values('Personalizado ','" + tipo + "')";

                    try
                    {

                        rs = Program.cn.Execute(sql, out cantFilas, -1);

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta menu");
                    }

                    //BUSCO ULTIMO VALOR ID MENU
                    sql = "select MAX(Id_Menu) from menu";
                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                        Id_Menu = rs.Fields[0].Value.ToString();

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta MAX");
                    }

                    string vianda;
                    //RELACIONO DIETAS CON MENU INGRESADO
                    //USO FOREACH PARA TRAER A TODOS LOS OBJETOS SELECCIONADOS
                    foreach (var item in chlViandas.CheckedItems)
                    {
                        string[] id = item.ToString().Split(' ');

                        if (id.Length > 0)
                        {
                            vianda = id[0]; //Traigo valor Id_Vianda
                                            //Cada elemento es un ID
                            string valorChequeado = vianda;

                            //Inserto CADA VALOR EN LA BASE DE DATOS LLAMANDO AL SIGUIENTE MÉTODO
                            InsertarViandaRelacion(rs, valorChequeado);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            if (btnBCI.Enabled == false)
            {
                //BUSCO ID CLIENTE EMPRESA
                sql = "SELECT empresa.Id_Cliente from cliente INNER JOIN empresa ON empresa.Id_Cliente = cliente.Id_Cliente where RUT = " + txtRUTb.Text;

                try
                {
                    rs = Program.cn.Execute(sql, out cantFilas, -1); //resultado RS
                    Id_Cliente = rs.Fields[0].Value.ToString();
                }//TRY
                catch
                {
                    MessageBox.Show("Error sentencia SQL cliente"); //error al ejecutar sentencia SQL.
                    return;
                }//CATCH


                //PASARLO A UNA CLASE?
                //INSERTO PEDIDO
                sql = "insert into pedido (Id_Cliente)";
                sql = sql + " values('" + Id_Cliente + "')";

                try
                {
                    rs = Program.cn.Execute(sql, out cantFilas, -1);
                }
                catch
                {
                    MessageBox.Show("Error a ejecutar sentencia para PEDIDO");
                }

                //BUSCO ÚLITMO Id_Pedido
                sql = "select MAX(Id_Pedido) from pedido";

                try
                {

                    rs = Program.cn.Execute(sql, out cantFilas, -1);
                    Id_Pedido = rs.Fields[0].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Error a ejectutar sentencia para consulta MAX");
                }

                //INSERTO en TABLA p_pasa_por
                sql = "insert into p_pasa_por (Id_Estado_p,Id_Pedido)";
                //Id_Estado_p en numero 1 = Solicitado
                sql = sql + " values('" + 1 + "'," + Id_Pedido + ")";

                try
                {
                    //MessageBox.Show(sql);
                    rs = Program.cn.Execute(sql, out cantFilas, -1);
                }
                catch
                {
                    MessageBox.Show("Error a ejectutar sentencia para consulta p_pasa_por");
                }

                //INSERTO en TABLA estado_pedido
                sql = "insert into estado_pedido (Id_Cliente,Id_Pedido,Id_Estado_p)";
                //Id_Estado_p en numero 1 = Solicitado
                sql = sql + " values(" + Id_Cliente + "," + Id_Pedido + "," + 2 + ")";

                try
                {
                    //MessageBox.Show(sql);
                    rs = Program.cn.Execute(sql, out cantFilas, -1);
                }
                catch
                {
                    MessageBox.Show("Error a ejectutar sentencia para consulta estado_pedido");
                }

                //CAJA

                //INSERTO EN TABLA caja
                // 40 DIAS POR SU FECHA DE VENCIMIENTO CAJA

                sql = "insert into caja (fecha_vencimiento,Id_Pedido,Id_Menu)";
                sql = sql + " values(CURRENT_DATE() + INTERVAL 40 DAY," + Id_Pedido + "," + Id_Menu + ")";

                try
                {
                    //MessageBox.Show(sql);
                    rs = Program.cn.Execute(sql, out cantFilas, -1);


                }
                catch
                {
                    MessageBox.Show("Error a ejectutar sentencia para consulta caja");
                }

                //Busco Id_Caja
                sql = "select MAX(Id_Caja) from caja";
                try
                {
                    //MessageBox.Show(sql);
                    rs = Program.cn.Execute(sql, out cantFilas, -1);
                    Id_Caja = rs.Fields[0].Value.ToString();

                }
                catch
                {
                    MessageBox.Show("Error a ejectutar sentencia para consulta MAX");
                }

                //INSERTO EN TABLA caja_sucursal
                //Sujeto a edición, por defecto sucursal 1
                sql = "insert into caja_sucursal (Id_Caja,Id_Sucursal)";
                sql = sql + " values(" + Id_Caja + "," + 1 + ")";

                try
                {

                    rs = Program.cn.Execute(sql, out cantFilas, -1);


                }
                catch
                {
                    MessageBox.Show("Error a ejectutar sentencia para consulta caja_sucursal");
                }

                //INSERTO EN compone
                sql = "insert into compone (Id_Caja,Id_Pedido)";
                sql = sql + " values(" + Id_Caja + "," + Id_Pedido + ")";

                try
                {
                    //MessageBox.Show(sql);
                    rs = Program.cn.Execute(sql, out cantFilas, -1);

                }
                catch
                {
                    MessageBox.Show("Error a ejectutar sentencia para consulta compone");
                }

                //INSERTO en envasa

                sql = "insert into envasa (Id_Menu, Id_Caja)";
                sql = sql + " values(" + Id_Menu + "," + Id_Caja + ")";

                try
                {
                    //MessageBox.Show(sql);
                    rs = Program.cn.Execute(sql, out cantFilas, -1);


                }
                catch
                {
                    MessageBox.Show("Error a ejectutar sentencia para consulta envasa");
                }

                //INSERTO en c_pasa_por
                //fecha_fin queda NULO hasta que se cambie de estado
                sql = "insert into c_pasa_por (Id_Estado_m,Id_Caja)";
                sql = sql + " values(" + 2 + "," + Id_Caja + ")";

                try
                {
                    //MessageBox.Show(sql);
                    rs = Program.cn.Execute(sql, out cantFilas, -1);

                }
                catch
                {
                    MessageBox.Show("Error a ejectutar sentencia para consulta c_pasa_por");
                }

                //CARGO EN LA LISTA
                sql = "SELECT menu.nombre, menu.tipo_menu from menu where Id_Menu=" + Id_Menu;

                try
                {

                    rs = Program.cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    MessageBox.Show("Error a obtener datos de vianda");
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
                        string nombre = rs.Fields[0].Value.ToString();
                        string tipo = rs.Fields[1].Value.ToString();
                        //Creamos un string para juntar los datos nombre "cadena"
                        lstPedidoCliente.Items.Add(nombre + " " + tipo);
                        rs.MoveNext(); //Nos movemos al siguiente registro
                    }

                    MessageBox.Show("Pedido ingresado correctamente");
                }
            }

            

            if (btnBCI.Enabled == true)
            {
                
                    //BUSCO CLIENTE PERSONA
                    sql = "SELECT cliente.Id_Cliente from cliente INNER JOIN persona ON persona.Id_Cliente = cliente.Id_Cliente where CI =" + txtCIb.Text;

                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas, -1); //resultado RS
                        Id_Cliente = rs.Fields[0].Value.ToString();
                    }//TRY
                    catch
                    {
                        MessageBox.Show("Error sentencia SQL cliente"); //error al ejecutar sentencia SQL.
                        return;
                    }//CATCH


                    //PASARLO A UNA CLASE?
                    //INSERTO PEDIDO
                    sql = "insert into pedido (Id_Cliente)";
                    sql = sql + " values('" + Id_Cliente + "')";

                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejecutar sentencia para PEDIDO");
                    }

                    //BUSCO ÚLITMO Id_Pedido
                    sql = "select MAX(Id_Pedido) from pedido";

                    try
                    {

                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                        Id_Pedido = rs.Fields[0].Value.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta MAX");
                    }

                    //INSERTO en TABLA p_pasa_por
                    sql = "insert into p_pasa_por (Id_Estado_p,Id_Pedido)";
                    //Id_Estado_p en numero 1 = Solicitado
                    sql = sql + " values('" + 1 + "'," + Id_Pedido + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta p_pasa_por");
                    }

                    //INSERTO en TABLA estado_pedido
                    sql = "insert into estado_pedido (Id_Cliente,Id_Pedido,Id_Estado_p)";
                    //Id_Estado_p en numero 1 = Solicitado
                    sql = sql + " values(" + Id_Cliente + "," + Id_Pedido + "," + 2 + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta estado_pedido");
                    }


                    //CAJA


                    //INSERTO EN TABLA caja
                    // 40 DIAS POR SU FECHA DE VENCIMIENTO CAJA

                    sql = "insert into caja (fecha_vencimiento,Id_Pedido,Id_Menu)";
                    sql = sql + " values(CURRENT_DATE() + INTERVAL 40 DAY," + Id_Pedido + "," + Id_Menu + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);


                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta caja");
                    }

                    //Busco Id_Caja
                    sql = "select MAX(Id_Caja) from caja";
                    try
                    {

                        rs = Program.cn.Execute(sql, out cantFilas, -1);
                        Id_Caja = rs.Fields[0].Value.ToString();


                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta MAX");
                    }

                    //INSERTO EN TABLA caja_sucursal
                    //Sujeto a edición, por defecto sucursal 1
                    sql = "insert into caja_sucursal (Id_Caja,Id_Sucursal)";
                    sql = sql + " values(" + Id_Caja + "," + 1 + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);


                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta caja_sucursal");
                    }
                    //INSERTO EN compone
                    sql = "insert into compone (Id_Caja,Id_Pedido)";
                    sql = sql + " values(" + Id_Caja + "," + Id_Pedido + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta compone");
                    }

                    //INSERTO en envasa

                    sql = "insert into envasa (Id_Menu, Id_Caja)";
                    sql = sql + " values(" + Id_Menu + "," + Id_Caja + ")";

                    try
                    {
                        //MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);


                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta envasa");
                    }

                    //INSERTO en c_pasa_por
                    //fecha_fin queda NULO hasta que se cambie de estado
                    sql = "insert into c_pasa_por (Id_Estado_m,Id_Caja)";
                    sql = sql + " values(" + 2 + "," + Id_Caja + ")";

                    try
                    {
                        //MessageBox.Show(Id_Caja);
                        rs = Program.cn.Execute(sql, out cantFilas, -1);

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta c_pasa_por");
                    }


                    //CARGO EN LA LISTA
                    sql = "SELECT menu.nombre, menu.tipo_menu from menu where Id_Menu=" + Id_Menu;

                    try
                    {

                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de vianda");
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
                            string nombre = rs.Fields[0].Value.ToString();
                            string tipo = rs.Fields[1].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            lstPedidoCliente.Items.Add(nombre + " " + tipo);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }

                            MessageBox.Show("Pedido ingresado correctamente");
                    }
                
            }


        }

        private void rboSemanal_CheckedChanged(object sender, EventArgs e)
        {
            if (rboSemanal.Checked)
            {
                tipo = "Semanal";
                
            }
            else
            { tipo = ""; }
        }

        private void rboQuincenal_CheckedChanged(object sender, EventArgs e)
        {
            if (rboQuincenal.Checked)
            {
                tipo = "Quincenal";
            }
            else
            { tipo = ""; }
        }
    }
}
