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
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
            
            
        }

        public static string sucursal { get; set; }

        public static int Id_Z { get; set; }

        public static string suc { get; set; }

        public static string id { get; set; }

        public static string zona { get; set; }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            lstSucursales.Items.Clear();
            cboZona.Items.Clear();

            string zona = "";
            string Id_Zona = "";
            int Id_Z = 0;
            string suc = "";
            string id = "";

            try
            {

                if (Program.cn.State != 0)
                {


                    sql = "SELECT Id_Sucursal,nombre from sucursal";
                    try
                    {

                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de sucursal");
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
                            id = rs.Fields[0].Value.ToString();
                            suc = rs.Fields[1].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            lstSucursales.Items.Add(id + " " + suc);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }

                    }


                    sql = "SELECT Id_Zona,nombre from zona";
                    try
                    {
                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de zona");
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
                            Id_Zona = rs.Fields[0].Value.ToString();
                            zona = rs.Fields[1].Value.ToString();
                            cboZona.Items.Add(Id_Zona + " " + zona);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }

                    }
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            //Si algo está seleccionado en el combobox
            if (cboZona.SelectedIndex != -1)
            {
                string zonaseleccionada = cboZona.SelectedIndex.ToString(); //De seguro hay otra forma mas facil de hacerlo...

                if (zonaseleccionada == "0")
                {
                    Id_Z = 1;
                }
                if (zonaseleccionada == "1")
                {
                    Id_Z = 2;
                }
                if (zonaseleccionada == "2")
                {
                    Id_Z = 3;
                }
                if (zonaseleccionada == "3")
                {
                    Id_Z = 4;
                }
                if (zonaseleccionada == "4")
                {
                    Id_Z = 5;
                }
                if (zonaseleccionada == "5")
                {
                    Id_Z = 6;
                }
                if (zonaseleccionada == "6")
                {
                    Id_Z = 7;
                }

                lstSucursales.Items.Clear();

                try
                {

                    sql = "select nombre from sucursal where Id_Zona=" + Id_Z;

                    try
                    {

                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de sucursal");
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
                            sucursal = rs.Fields[0].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            lstSucursales.Items.Add(sucursal);
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }

                    }
                }
                catch (Exception ex)
                {

                    {
                        MessageBox.Show("Error en consulta usuario: " + ex.Message);
                    }
                }
                finally
                {
                    rs.Close();
                }
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Sucursales_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sucursalselecc = lstSucursales.Text.ToString();
            string[] palabras = sucursalselecc.Split(' '); // Dividir el texto en palabras usando un espacio en blanco como separador
            string nombre = "";
            string nombre2 = "";
            string junto = "";

            if (palabras.Length > 0)
            {
                id = palabras[0]; //Traigo valor id
                nombre = palabras[1];
                nombre2 = palabras[2];
                junto = (nombre + " " + nombre2);
            }
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            sql = "select Id_Sucursal from sucursal where Id_Sucursal=" + id;

            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);

                if (!rs.EOF)
                {
                    sucursal = rs.Fields[0].Value.ToString();
                    MessageBox.Show("Sucursal cambiada a " + junto);
                }
                else
                {
                    MessageBox.Show("Sin datos");
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

        private void lstSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
