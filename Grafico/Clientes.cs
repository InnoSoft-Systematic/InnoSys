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
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
           
            try
            {

                if (Program.cn.State != 0)
                {

                    sql = "SELECT CI, `Primer_nombre`, `Primer_apellido`, `Segundo_apellido`, `Direccion` FROM persona;"; //Defino la sentencia SQL
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
                        MessageBox.Show("No se encontró usuario");
                    }
                    else
                    {
                        lstClientes.Items.Clear();
                        while (!rs.EOF)
                        {
                            string ci = rs.Fields[0].Value.ToString();
                            string nombre = rs.Fields[1].Value.ToString();
                            string papellido = rs.Fields[2].Value.ToString();
                            string sapellido = rs.Fields[3].Value.ToString();
                            string direccion = rs.Fields[4].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            string cadena = ci+"  "+nombre+"     "+papellido+"     "+sapellido+"     "+direccion;
                          //  lstClientes.Items.Add("CI              NOMBRE            APELLIDOS                  DIRECCION");
                            lstClientes.Items.Add(cadena);
                            
                            rs.MoveNext(); //nos movemos al siguiente registro
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
