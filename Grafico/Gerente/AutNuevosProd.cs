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
    public partial class AutNuevosProd : Form
    {
        public AutNuevosProd()
        {
            InitializeComponent();
        }

        public string Id_Menu { get; set; }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AutNuevosProd_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            string dato = lstProductos.Text.ToString();
            string[] palabras = dato.Split(' '); // Dividir el texto en palabras usando un espacio en blanco como separador

            if (palabras.Length > 0)
            {
                Id_Menu = palabras[0]; //Traigo valor Id_Menu
            }

            sql = "delete from aut_menu where Id_Menu=" + Id_Menu;

            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
                MessageBox.Show("Menú autorizado correctamente");
            }
            catch
            {
                MessageBox.Show("Error en la sentencia delete from aut_menu");
            }

            btnActualizar_Click(this, EventArgs.Empty);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            lstProductos.Items.Clear();

            try
            {

                if (Program.cn.State != 0)
                {


                    sql = "select aut_menu.Id_Menu,menu.nombre from aut_menu,menu where aut_menu.Id_Menu = menu.Id_Menu and not menu.nombre = 'Personalizado'";
                    try
                    {
                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de menu");
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
                            string Id = rs.Fields[0].Value.ToString();
                            string nombre = rs.Fields[1].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            string cadena = Id + " " + nombre;
                            //  lstClientes.Items.Add("CI              NOMBRE            APELLIDOS                  DIRECCION");
                            lstProductos.Items.Add(cadena);
                            rs.MoveNext(); //nos movemos al siguiente registro
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }//TRY

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            string dato = lstProductos.Text.ToString();
            string[] palabras = dato.Split(' '); // Dividir el texto en palabras usando un espacio en blanco como separador

            if (palabras.Length > 0)
            {
                Id_Menu = palabras[0]; //Traigo valor Id_Menu
            }

            sql = "delete from aut_menu where Id_Menu=" + Id_Menu;

            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error en la sentencia delete from aut_menu");
            }

            sql = "delete from conforma where Id_Menu=" + Id_Menu;

            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error en la sentencia conforma");
            }

            sql = "delete from pertenece where Id_Menu=" + Id_Menu;

            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
            }
            catch
            {
                MessageBox.Show("Error en la sentencia pertenece");
            }

            sql = "delete from menu where Id_Menu=" + Id_Menu;

            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
                MessageBox.Show("Menú rechazado y eliminado correctamente");
            }
            catch
            {
                MessageBox.Show("Error en la sentencia delete from menu");
            }

            btnActualizar_Click(this, EventArgs.Empty);
        }
    }
}
