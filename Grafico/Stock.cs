using Grafico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InnoSys
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            int minimo = 0;
            int maximo = 0;
            int actual = 0;
            string Id_Menu = "";
            lblAvisoStock.Hide();
            gbModStock.Hide();

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

        //Las declaro global para usarlas después
        private dynamic minimo { get; set; }
        private dynamic maximo { get; set; }
        private dynamic Id_Menu { get; set; }
        private dynamic actual { get; set; }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.frmStock.Hide();
        }

        private void cboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            lstMenu.Items.Clear();
            //SI EL QUE INICIO ES GERENTE O INFORMATICO
            if (Login.rol.ToString() == "Gerente")
            {
                gbModStock.Show();
            }
            if (Login.rol.ToString() == "Informatico")
            {
                gbModStock.Show();
            }
            try
            {
                if (Program.cn.State != 0)
                {

                    //QUITO LOS PERSONALIZADOS YA QUE ESTOS NO TIENEN VALORES Y LAS VIANDAS SON ILIMITADAS...
                    sql = "SELECT Id_Menu,nombre,tipo_menu from menu where not nombre = 'Personalizado'";
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
                            string Id = rs.Fields[0].Value.ToString();
                            string nombre = rs.Fields[1].Value.ToString();
                            string tipo = rs.Fields[2].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            lstMenu.Items.Add(Id + " " + nombre + " " + tipo);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }

                    }

                    sql = "select stock_minimo from stock";
                    try
                    {

                        rs = Program.cn.Execute(sql, out filasAfectadas);
                        minimo = rs.Fields[0].Value;
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario");
                        return;

                    }

                    sql = "select stock_maximo from stock";
                    try
                    {

                        rs = Program.cn.Execute(sql, out filasAfectadas);
                        maximo = rs.Fields[0].Value;
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario");
                        return;

                    }


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            string sql;
            object cantFilas;
            ADODB.Recordset rs = new ADODB.Recordset();


            string menu = lstMenu.Text.ToString();
            //  MessageBox.Show(menu);


            string[] palabras = menu.Split(' '); // Dividir el texto en palabras usando un espacio en blanco como separador

            if (palabras.Length > 0)
            {
                Id_Menu = palabras[0];

                //SELECCIONO STOCK ACTUAL DEL MENU SELECCIONADO
                sql = "SELECT stock_actual from stock INNER JOIN menu ON menu.Id_Menu = stock.Id_Menu where menu.Id_Menu=" + Id_Menu;

                try
                {
                    rs = Program.cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    MessageBox.Show("Error a obtener datos del usuario");
                    return;

                }

                while (!rs.EOF)
                {
                    string stock_actual = rs.Fields[0].Value.ToString();
                    //PARA QUE SE CARGEN LOS DATOS EN EL LABEL
                    lblCantidadActual.Text = "" + stock_actual + "";
                    rs.MoveNext();
                }

                //PASO RESTULTADO A INT PARA HACER CONTROLES DE STOCK
                int actual;
                int.TryParse(lblCantidadActual.Text, out actual);

                if (actual < minimo)
                {
                    lblAvisoStock.Show();
                    lblAvisoStock.ForeColor = Color.Red;
                    lblAvisoStock.Text = "STOCK POR DEBAJO DEL MÍNIMO";
                }
                else
                {
                    lblAvisoStock.Hide();
                }

                //HAGO UN CONTEO DE TODOS LOS ESTADOS EN PRODUCCIÓN DE UN MENÚ SELECCIONADO - Id_Estado_m = 3 EN PRODUCCION
                sql = "SELECT COUNT(c_pasa_por.Id_Estado_m) from menu, stock, c_pasa_por, caja where menu.Id_Menu = stock.Id_Menu and c_pasa_por.Id_Caja = caja.Id_Caja and menu.Id_Menu = caja.Id_Menu and menu.Id_Menu =" + Id_Menu + " and c_pasa_por.Id_Estado_m=3";
                try
                {
                    rs = Program.cn.Execute(sql, out cantFilas);

                    if (rs.RecordCount == 0)
                    {
                        MessageBox.Show("No hay datos");
                    }
                }
                catch
                {
                    MessageBox.Show("Error a obtener datos de conteo datos en producción");
                    return;

                }

                while (!rs.EOF)
                {
                    string produccion = rs.Fields[0].Value.ToString();
                    //PARA QUE SE CARGEN LOS DATOS EN EL LABEL
                    lblProduccionActual.Text = "" + produccion + "";
                    rs.MoveNext();
                }

                //HAGO UN CONTEO DE TODOS LOS ESTADOS PRODUCIDOS  - Id_Estado = 4 PRODUCIDO
                sql = "SELECT COUNT(c_pasa_por.Id_Estado_m) from menu,stock,c_pasa_por,caja where menu.Id_Menu = stock.Id_Menu and c_pasa_por.Id_Caja = caja.Id_Caja and menu.Id_Menu = caja.Id_Menu and menu.Id_Menu=" + Id_Menu + " and c_pasa_por.Id_Estado_m=4";
                try
                {
                    rs = Program.cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    MessageBox.Show("Error a obtener datos de conteo datos producidos");
                    return;

                }
                while (!rs.EOF)
                {
                    string producido = rs.Fields[0].Value.ToString();
                    //PARA QUE SE CARGEN LOS DATOS EN EL LABEL
                    lblCantidadProducida.Text = "" + producido + "";
                    rs.MoveNext();
                }


            }
        }

        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidadActual_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadProducida_Click(object sender, EventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnModParametros_Click(object sender, EventArgs e)
        {
            Program.frmParametros.ShowDialog();
        }
    }
}
