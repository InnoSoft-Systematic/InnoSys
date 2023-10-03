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
            _CI = 0;
            _nombre = "";
           // _conexion = new ADODB.Connection();
        }

        public Clientes(int CI, string nombre, ADODB.Connection cn)
        {
            _CI = CI;
            _nombre = nombre;
            //_conexion = cn;
        }
        public int CI
        {
            get { return (_CI); }
            set { _CI = value; }
        }
        public string nombre
        {
            get { return (_nombre); }
            set { _nombre = value; }
        }
      //  public ADODB.Connection conexion
        //{
           // get { return (_conexion); }
           // set { _conexion = value; }
       // }

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

                    sql = "SELECT nombre FROM roles;"; //Defino la sentencia SQL
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
                            string user = rs.Fields[0].Value.ToString();
                            lstClientes.Items.Add(user);
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
    }
}
