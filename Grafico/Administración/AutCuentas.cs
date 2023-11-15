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
    public partial class AutCuentas : Form
    {
        public AutCuentas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void AutCuentas_Load(object sender, EventArgs e)
        {

        }

        private void lstAutAltasBajas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void rboEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rboEmpresa.Checked)
            {
                string sql;
                object filasAfectadas;
                ADODB.Recordset rs = new ADODB.Recordset();
                lstAutBajas.Items.Clear();

                try
                {

                    if (Program.cn.State != 0)
                    {


                        sql = "SELECT RUT,Nombre_fant,empresa.Id_Cliente FROM empresa INNER JOIN baja ON empresa.Id_Cliente = baja.Id_Cliente"; //Defino la sentencia SQL para empresas
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
                                string RUT = rs.Fields[0].Value.ToString();
                                string empresa = rs.Fields[1].Value.ToString();
                                string Id_Cliente = rs.Fields[2].Value.ToString();
                                //Creamos un string para juntar los datos nombre "cadena"
                                string cadena = Id_Cliente + " " + RUT + " " + empresa;
                                //  lstClientes.Items.Add("CI              NOMBRE            APELLIDOS                  DIRECCION");
                                lstAutBajas.Items.Add(cadena);
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
        }

        private void rboPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (rboPersona.Checked == true)
            {
                string sql;
                object filasAfectadas;
                ADODB.Recordset rs = new ADODB.Recordset();
                lstAutBajas.Items.Clear();

                try
                {

                    if (Program.cn.State != 0)
                    {
                        sql = "SELECT CI,Primer_nombre,Primer_apellido,persona.Id_Cliente FROM persona INNER JOIN baja ON persona.Id_Cliente = baja.Id_Cliente"; //Defino la sentencia SQL para personas
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
                                string CI = rs.Fields[0].Value.ToString();
                                string nombre = rs.Fields[1].Value.ToString();
                                string apellido = rs.Fields[2].Value.ToString();
                                string Id_Cliente = rs.Fields[3].Value.ToString();
                                //Creamos un string para juntar los datos nombre "cadena"
                                string cadena = Id_Cliente + " " + CI + " " + nombre + " " + apellido;
                                //  lstClientes.Items.Add("CI              NOMBRE            APELLIDOS                  DIRECCION");
                                lstAutBajas.Items.Add(cadena);

                                rs.MoveNext(); //nos movemos al siguiente registro
                            }

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }//IF
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            string sql;
            object cantFilas;
            ADODB.Recordset rs = new ADODB.Recordset();

            if (rboEmpresa.Checked)
            {
                string rutEmpresa = lstAutBajas.Text.ToString();
                //MessageBox.Show(rutEmpresa);


                string[] palabras = rutEmpresa.Split(' '); // Dividir el texto en palabras usando un espacio en blanco como separador

                if (palabras.Length > 0)
                {
                    string Id_Cliente = palabras[0]; //Traigo valor ID
                    string RUT = palabras[1]; //Traigo valor RUT
                    MessageBox.Show(Id_Cliente);
                    MessageBox.Show(RUT);

                    sql = "DELETE FROM empresa where Id_Cliente=" + Id_Cliente;

                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del la empresa");
                        return;

                    }

                    sql = "DELETE FROM baja where Id_Cliente=" + Id_Cliente;
                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos de la tabla baja");
                        return;

                    }
                    //Como la tabla cliente tiene la Id_Cliente como CLAVE PRIMARIA, SE DEBE BORRAR DESPUÉS DE HABER ELIMINADO SUS RELACIONES
                    //14/11/23 Tiene mas de esta relación, no se pueden eliminar, dejo como comentario

                  /*  sql = "DELETE FROM cliente where Id_Cliente=" + Id_Cliente;
                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario");
                        return;

                    }*/
                    MessageBox.Show("BAJA EFECTUADA CORRECTAMENTE");



                }
            }
            if (rboPersona.Checked)
            {
                string datosPersona = lstAutBajas.Text.ToString();
                MessageBox.Show(datosPersona);


                string[] palabras = datosPersona.Split(' '); // Dividir el texto en palabras usando un espacio en blanco como separador

                if (palabras.Length > 0)
                {
                    string Id_Cliente = palabras[0]; //Traigo valor ID
                    string cedula = palabras[1]; //Traigo valor CI


                    sql = "DELETE FROM persona where Id_Cliente=" + Id_Cliente;

                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario de la tabla persona");
                        return;

                    }

                    sql = "DELETE FROM baja where Id_Cliente=" + Id_Cliente;
                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario de la tabla baja");
                        return;

                    }
                    //Como la tabla cliente tiene la Id_Cliente como CLAVE PRIMARIA, SE DEBE BORRAR DESPUÉS DE HABER ELIMINADO SUS RELACIONES
                    //14/11/23 Tiene mas de esta relación, no se pueden eliminar, dejo como comentario
                   /* sql = "DELETE FROM cliente where Id_Cliente=" + Id_Cliente;
                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario de la tabla cliente");
                        return;

                    }*/
                    MessageBox.Show("BAJA EFECTUADA CORRECTAMENTE");


                }



            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            string sql;
            object cantFilas;
            ADODB.Recordset rs = new ADODB.Recordset();

            if (rboEmpresa.Checked)
            {
                string rutEmpresa = lstAutBajas.Text.ToString();
                MessageBox.Show(rutEmpresa);


                string[] palabras = rutEmpresa.Split(' '); // Dividir el texto en palabras usando un espacio en blanco como separador

                if (palabras.Length > 0)
                {
                    string Id_Cliente = palabras[0]; //Traigo valor ID
                    string RUT = palabras[1]; //Traigo el valor de RUT
                    MessageBox.Show(Id_Cliente);
                    MessageBox.Show(RUT);
                    

                    sql = "DELETE FROM baja where Id_Cliente=" + Id_Cliente;
                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario");
                        return;

                    }
                    MessageBox.Show("Solicitud rechazada");
                    lstAutBajas.Update();



                }
            }
            if (rboPersona.Checked)
            {
                string datosPersona = lstAutBajas.Text.ToString(); //TOMO VALORES QUE SELECCIONO
                MessageBox.Show(datosPersona); //Para ver los valores seleccionados


                string[] palabras = datosPersona.Split(' '); // Dividio las palabras con un espacio

                if (palabras.Length > 0)
                {
                    string Id_Cliente = palabras[0]; //Traigo valor ID
                    string cedula = palabras[1]; //Traigo valor CI


                    

                    sql = "DELETE FROM baja where Id_Cliente=" + Id_Cliente;
                    try
                    {
                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario de la tabla baja");
                        return;

                    }
                    MessageBox.Show("Solicitud rechazada correctamente");
                    lstAutBajas.Update();


                }



            }
        }
    }
}

