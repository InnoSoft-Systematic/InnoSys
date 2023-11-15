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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.frmMenu.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();
            lstMenu.Items.Clear();


            try
            {

                if (Program.cn.State != 0)
                {


                    sql = "SELECT nombre,tipo_menu from menu where not nombre ='Personalizado'";
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
                            string menu = rs.Fields[0].Value.ToString();
                            string tipo = rs.Fields[1].Value.ToString();
                            //Creamos un string para juntar los datos nombre "cadena"
                            lstMenu.Items.Add(menu + " " + tipo);
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
    }

}
