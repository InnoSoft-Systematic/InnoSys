using ADODB;
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

namespace InnoSys.Gerente
{
    public partial class Parametros : Form
    {
        public Parametros()
        {
            InitializeComponent();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sql;
            object filasAfectadas;
            ADODB.Recordset rs = new ADODB.Recordset();

            sql = "update stock set stock_minimo=" + txtMin.Text + ", stock_maximo=" + txtMax.Text;

            try
            {
                rs = Program.cn.Execute(sql, out filasAfectadas);
                MessageBox.Show("Parámetros actualizados");
            }
            catch
            {
                MessageBox.Show("Error sentencia");
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
