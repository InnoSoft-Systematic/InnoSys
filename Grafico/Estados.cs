using Google.Protobuf.WellKnownTypes;
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
    public partial class Estados : Form
    {
        public Estados()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.frmEstados.Hide();
        }

        private void Estados_Load(object sender, EventArgs e)
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


                    sql = "SELECT p_pasa_por.Id_Pedido,estados_pedido.estado,fecha_solicitud FROM p_pasa_por INNER JOIN estados_pedido ON p_pasa_por.Id_Estado_p = estados_pedido.Id_Estado_p";

                    try
                    {

                        rs = Program.cn.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de pedidos");
                        return;

                    }
                    if (rs.RecordCount == 0)
                    {
                        MessageBox.Show("No se encontraron datos");
                    }
                    else
                    {
                        //Creamos tabla
                        DataTable dataTabla = new DataTable();
                        //Creamos columnas
                        dataTabla.Columns.Add("ID", typeof(int));
                        dataTabla.Columns.Add("Estado", typeof(string));
                        dataTabla.Columns.Add("Fecha Solicitud", typeof(DateTime));

                        //dataTabla.Columns.Add("Fecha Entrega", typeof(DateTime));


                        while (!rs.EOF)
                        {
                            int id = Convert.ToInt32(rs.Fields[0].Value);
                            string estado = rs.Fields[1].Value.ToString();
                            DateTime fechasol = rs.Fields[2].Value;

                            dataTabla.Rows.Add(id, estado, fechasol);
                            //Relacionamos los datos

                            //Agregamos a la tabla
                            rs.MoveNext(); //Nos movemos al siguiente registro
                        }
                        dgEstados.DataSource = dataTabla;

                    }
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (rs != null && rs.State == 1)
                    rs.Close();
            }
        }

        private void dgEstados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
