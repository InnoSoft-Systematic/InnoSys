using ADODB;
using Grafico;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnoSys.Administrador
{
    public partial class IngresoMenu : Form
    {
        public IngresoMenu()
        {
            InitializeComponent();
            string tipo = "";
            string Id_Dieta = "";
            string Id_Vianda = "";
            string Id_Menu = "";
        }

        public dynamic tipo { get; set; }
        public dynamic Id_Dieta { get; set; }

        public dynamic Id_Vianda { get; set; }

        public dynamic Id_Menu { get; set; }

        private void InsertarDietaRelacion(Recordset rs, string valor)
        {
            object filasAfectadas;
            string sql = $"INSERT INTO pertenece (Id_Dieta,Id_Menu) VALUES ('{valor}'," + Id_Menu + ")";

            rs = Program.cn.Execute(sql, out filasAfectadas);

            
        }
        private void InsertarViandaRelacion(Recordset rs, string valor)
        {
            object filasAfectadas;
            string sql = $"INSERT INTO conforma (Id_Vianda,Id_Menu) VALUES ('{valor}'," + Id_Menu + ")";

            rs = Program.cn.Execute(sql, out filasAfectadas);

            
        }

        private void IngresoMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Al presionar Volver, se cierre la ventana
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            //PARA QUE NO SE REPITAN VALORES CADA VEZ QUE DOY ACTUALIZAR
            chlDieta.Items.Clear();
            chlMenu.Items.Clear();

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
                            chlMenu.Items.Add(Id_Vianda + " " + vianda);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }

                    }
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            try
            {

                if (Program.cn.State != 0)
                {


                    sql = "SELECT Id_Dieta,tipo_dieta from dieta";
                    try
                    {

                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de dieta");
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
                            Id_Dieta = rs.Fields[0].Value.ToString();
                            string dieta = rs.Fields[1].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            chlDieta.Items.Add(Id_Dieta + " " + dieta);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }

                    }
                }
                rs.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAñadirMenu_Click(object sender, EventArgs e)
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
                    sql = sql + " values('" + txtNombre.Text + "','" + tipo + "')";

                    try
                    {

                        //MessageBox.Show(sql);
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

                    string dieta;
                    string vianda;
                    //RELACIONO DIETAS CON MENU INGRESADO
                    //USO FOREACH PARA TRAER A TODOS LOS OBJETOS SELECCIONADOS
                    foreach (var item in chlMenu.CheckedItems)
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

                    //RELACIONAR DIETAS SELECCIONADAS CON EL MENU
                    foreach (var item in chlDieta.CheckedItems)
                    {
                        string[] id = item.ToString().Split(' ');

                        if (id.Length > 0)
                        {
                            dieta = id[0]; //Traigo valor Id_Dieta
                                           //Cada elemento es un ID
                            string valorChequeado = dieta;

                            // Insertar el valor en la base de datos
                            InsertarDietaRelacion(rs, valorChequeado);
                        }
                    }

                    //INGRESO EN TABLA AUT_MENU PARA SU APROBACIÓN O ELIMINACION
                    sql = "insert into aut_menu (Id_Menu)";
                    sql = sql + " values(" + Id_Menu + ")";

                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas, -1);

                    }
                    catch
                    {
                        MessageBox.Show("Error a ejectutar sentencia para consulta aut_menu");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            MessageBox.Show("Menú ingresado correctamente");


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

        private void rboMenusal_CheckedChanged(object sender, EventArgs e)
        {


            if (rboMensual.Checked)
            {
                tipo = "Mensual";
            }
            else
            { tipo = ""; }
        }
    }
}
