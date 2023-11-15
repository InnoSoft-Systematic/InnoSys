using ADODB;
using Grafico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InnoSys
{
    public partial class Clientes : Form
    {

        protected int _CI;
        protected string _nombre;
        //protected ADODB.Connection _conexion;



        public Clientes()
        {
            InitializeComponent();
            // _conexion = new ADODB.Connection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();//Se oculta ventana
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void rboEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rboEmpresa.Checked)
            {
                string sql;
                object filasAfectadas;
                ADODB.Recordset rs = new ADODB.Recordset();

                try
                {

                    if (Program.cn.State != 0)
                    {


                        sql = "SELECT RUT,Nombre_fant,Tel,Direccion,Mail FROM empresa INNER JOIN cliente ON empresa.Id_Cliente = cliente.Id_Cliente"; //Defino la sentencia SQL para empresas
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
                            //Creamos tabla
                            DataTable dataTable = new DataTable();
                            //Creamos columnas
                            dataTable.Columns.Add("RUT", typeof(int));
                            dataTable.Columns.Add("Empresa", typeof(string));
                            dataTable.Columns.Add("Teléfono", typeof(int));
                            dataTable.Columns.Add("Dirección", typeof(string));
                            dataTable.Columns.Add("Correo", typeof(string));



                            while (!rs.EOF)
                            {
                                int RUT = Convert.ToInt32(rs.Fields[0].Value);
                                string empresa = rs.Fields[1].Value.ToString();
                                int tel = Convert.ToInt32(rs.Fields[2].Value);
                                string dir = rs.Fields[3].Value.ToString();
                                string correo = rs.Fields[4].Value.ToString();




                                //Relacionamos los datos
                                dataTable.Rows.Add(RUT, empresa, tel, dir, correo);

                                rs.MoveNext(); //Nos movemos al siguiente registro
                            }
                            //Agregamos a la tabla

                            dgClientes.DataSource = dataTable;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }//TRY


        }

        private void rboPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (rboPersona.Checked)
            {
                string sql;
                object filasAfectadas;
                ADODB.Recordset rs = new ADODB.Recordset();


                try
                {

                    if (Program.cn.State != 0)
                    {


                        sql = "SELECT CI,Primer_nombre,Primer_apellido,Tel,Direccion,Mail FROM persona INNER JOIN cliente ON persona.Id_Cliente = cliente.Id_Cliente"; //Defino la sentencia SQL para personas
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
                            //Creamos tabla
                            DataTable dataTable = new DataTable();
                            //Creamos columnas
                            dataTable.Columns.Add("CI", typeof(int));
                            dataTable.Columns.Add("Nombre", typeof(string));
                            dataTable.Columns.Add("Apellido", typeof(string));
                            dataTable.Columns.Add("Teléfono", typeof(int));
                            dataTable.Columns.Add("Dirección", typeof(string));
                            dataTable.Columns.Add("Correo", typeof(string));



                            while (!rs.EOF)
                            {
                                int CI = Convert.ToInt32(rs.Fields[0].Value);
                                string nombre = rs.Fields[1].Value.ToString();
                                string apellido = rs.Fields[2].Value.ToString();
                                int tel = Convert.ToInt32(rs.Fields[3].Value);
                                string dir = rs.Fields[4].Value.ToString();
                                string correo = rs.Fields[5].Value.ToString();

                                //Relacionamos los datos
                                dataTable.Rows.Add(CI, nombre, apellido, tel, dir, correo);

                                rs.MoveNext(); //Nos movemos al siguiente registro
                            }
                            //Agregamos a la tabla

                            dgClientes.DataSource = dataTable;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }//TRY
        }
    }
}

