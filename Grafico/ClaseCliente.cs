using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using Grafico;


namespace InnoSys
{
    class ClaseCliente
    {
        protected int _CI;
        protected int _RUT;
        protected string _nombre;
        protected string _apellido1;
        protected string _apellido2;
        protected string _mail;
        protected string _direccion;
        protected string _empresa;
        protected int _telefonos;
        protected int _zona;
        protected ADODB.Connection _conexion;

        public ClaseCliente()
        {
            _CI = 0;
            _RUT = 0;
            _nombre = "";
            _apellido1 = "";
            _apellido2 = "";
            _mail = "";
            _direccion = "";
            _empresa = "";
            _telefonos = 0;
            _zona = 0;
            _conexion = new ADODB.Connection();
        }

        public ClaseCliente(int CI, int RUT, string nombre, string apellido1, string apellido2, string mail, string direccion, string empresa, int telefonos, int zona, ADODB.Connection cn)
        {
            _CI = CI;
            _RUT = RUT;
            _nombre = nombre;
            _apellido1 = apellido1;
            _apellido2 = apellido2;
            _mail = mail;
            _direccion = direccion;
            _empresa = empresa;
            _telefonos = telefonos;
            _conexion = cn;
            _zona=zona;
        }

        public int CI
        {
            get { return _CI; }
            set { _CI = value; }
        }

        public int RUT
        {
            get { return _RUT; }
            set { _RUT = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string apellido1
        {
            get { return _apellido1; }
            set { _apellido1 = value;}
        }

        public string apellido2
        {
            get { return _apellido2; }
            set { _apellido2 = value; }
        }

        public string mail
        {
            get { return _mail;}
            set { _mail = value; }
        }
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string empresa
        {
            get { return _empresa; }
            set { _empresa = value; } 
        }
        public int telefonos
        {
            get { return _telefonos; }
            set { _telefonos = value; }
        }

        public ADODB.Connection conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }

        public int zona
        {
            get { return _zona; }
            set { _zona = value; }
        }

        public int buscar()
        {
            int retorno = 0; //Por defecto asumo que no hubieron errores.
            //object cantFilas;
            ADODB.Recordset rs = new ADODB.Recordset();
            string sql;

            if (_conexion.State == 0)
            {
                retorno = 1; //Conexión CERRADA.
            }
            else
            {
                sql = "select CI from persona where CI=" + _CI;
                try
                {
                   //RECORDSET   
                    rs.Open(sql, _conexion, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, -1);
                }
                catch
                {
                    return (2); //error al ejecutar la consulta.
                }
                if (rs.RecordCount == 0)
                {
                    retorno = 3; //No se encontró registro alguno.
                }
                else
                {

                    
                    sql = "select CI from persona where CI=" + _CI;
                    try
                    {
                        //rs = _conexion.Execute(sql, out cantFilas, -1);
                        rs.Close();
                        rs.Open(sql, _conexion, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, -1);
                    }
                    catch
                    {
                        return (4); //error al ejecutar la consulta de teléfonos.
                    }
                    
                    while (!rs.EOF) //mientras no llegue al fin 
                    {
                        
                       rs.MoveNext(); //nos movemos al siguiente registro
                    }
                }
                rs.Close();
                rs = null; // destruyo el objeto.
            }//if
            return (retorno);
        }//buscar

        public int buscarRUT()
        {
            int retorno = 0; //Por defecto asumo que no hubieron errores.
            //object cantFilas;
            ADODB.Recordset rs = new ADODB.Recordset();
            string sql;

            if (_conexion.State == 0)
            {
                retorno = 1; //Conexión CERRADA.
            }
            else
            {
                sql = "select RUT from empresa where RUT=" + _RUT;
                try
                {
                    //RECORDSET   
                    rs.Open(sql, _conexion, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, -1);
                }
                catch
                {
                    return (2); //error al ejecutar la consulta.
                }
                if (rs.RecordCount == 0)
                {
                    retorno = 3; //No se encontró registro alguno.
                }
                else
                {


                    sql = "select RUT from empresa where RUT=" + _RUT;
                    try
                    {
                        //rs = _conexion.Execute(sql, out cantFilas, -1);
                        rs.Close();
                        rs.Open(sql, _conexion, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, -1);
                    }
                    catch
                    {
                        return (4); //error al ejecutar la consulta de teléfonos.
                    }

                    while (!rs.EOF) //mientras no llegue al fin 
                    {

                        rs.MoveNext(); //nos movemos al siguiente registro
                    }
                }
                rs.Close();
                rs = null; // destruyo el objeto.
            }//if
            return (retorno);
        }//buscarRUT

        public byte guardar(bool alta)
        {
            byte retorno = 0;
            object cantFilas;
            string sql;
            

            
            ADODB.Recordset rs = new ADODB.Recordset();

            if (_conexion.State == 0)
            {
                retorno = 1; //conexión cerrada.
            }
            else
            {
                if (alta)
                {

                    sql = "insert into cliente (Mail,Tel,Id_Zona,Direccion)";
                    sql = sql + " values('" + _mail + "', '" + _telefonos + "', '" + _zona + "', '" + _direccion + "');";

                    try
                    {
                        MessageBox.Show(sql);
                        _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 2; //error al ejecutar sentencia SQL.
                    }

                    //sql = "select LAST_INSERT_ID()"; TOMA EL ULTIMO VALOR ID
                    sql = "select MAX(Id_Cliente) from cliente";
                    
                    

                    try
                    {
                        MessageBox.Show(sql);
                        rs = _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 3; //error al ejecutar sentencia SQL.
                    }


                    sql =  "insert into persona (Id_Cliente,CI,Primer_Nombre,Primer_Apellido,Segundo_Apellido) ";
                    sql = sql + " values(" + rs.Fields[0].Value + " , '" + _CI + "', '" + _nombre + "', '" + _apellido1 + "', '" + _apellido2 + "')";

                    try
                    {
                        MessageBox.Show(sql);
                        _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 4; //error al ejecutar sentencia SQL.
                    }
                }
                else
                {
                   
                    sql = "update cliente";
                   //sql = sql + "set nombre='" + _nombre + "'";
                    //sql = sql + "where ci=" + _CI;
                }
                if (!alta)
                {

                    try
                    {
                        _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 3; //error al ejecutar sentencia SQL.
                    }
                }
                
            }
            return retorno;
        }//guardar        

        public byte guardarRUT(bool alta)
        {
            byte retorno = 0;
            object cantFilas;
            string sql;



            ADODB.Recordset rs = new ADODB.Recordset();

            if (_conexion.State == 0)
            {
                retorno = 1; //conexión cerrada.
            }
            else
            {
                if (alta)
                {


                    sql = "insert into cliente (Mail,Tel,Id_Zona,Direccion)";
                    sql = sql + " values('" + _mail + "', '" + _telefonos + "', '" + _zona + "', '" + _direccion + "');";

                    try
                    {
                        MessageBox.Show(sql);
                        _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 2; //error al ejecutar sentencia SQL.
                    }

                    //sql = "select LAST_INSERT_ID()"; TOMA EL ULTIMO VALOR ID
                    sql = "select MAX(Id_Cliente) from cliente";



                    try
                    {
                        MessageBox.Show(sql);
                        rs = _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 3; //error al ejecutar sentencia SQL.
                    }


                    sql = "insert into empresa (Id_Cliente,RUT,Nombre_fant) ";
                    sql = sql + " values(" + rs.Fields[0].Value + " , '" + _RUT + "', '" + _empresa + "')";

                    try
                    {
                        MessageBox.Show(sql);
                        _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 4; //error al ejecutar sentencia SQL.
                    }
                }
                else
                {

                    sql = "update cliente";
                    
                }
                if (!alta)
                {

                    try
                    {
                        _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 3; //error al ejecutar sentencia SQL.
                    }
                }

            }
            return retorno;
        }//guardarRUT

        public byte baja(bool baja)
        {
            byte retorno = 0;
            object cantFilas;
            string sql;


            ADODB.Recordset rs = new ADODB.Recordset();

            if (_conexion.State == 0)
            {
                retorno = 1; //conexión cerrada.
            }
            else
            {
                if (baja) //Si es baja, es CI
                {

                    sql = "select cliente.Id_Cliente from cliente INNER JOIN persona ON cliente.Id_Cliente = persona.Id_Cliente where CI=" + _CI;

                    try
                    {
                        MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario");
                        return 3;

                    }
                    sql = "insert into baja (Id_Cliente) ";
                    sql = sql + "values(" + rs.Fields[0].Value + ")";

                    try
                    {
                        MessageBox.Show(sql);
                        _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 4; //error al ejecutar sentencia SQL.
                    }

                    if (rs.RecordCount == 0)
                    {
                        MessageBox.Show("No se encontraron datos");
                        return 4;
                    }


                }else
                {
                    sql = "select cliente.Id_Cliente from cliente INNER JOIN empresa ON cliente.Id_Cliente = empresa.Id_Cliente where RUT=" + _RUT;

                    try
                    {
                        MessageBox.Show(sql);
                        rs = Program.cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        MessageBox.Show("Error a obtener datos del usuario");
                        return 3;

                    }
                    sql = "insert into baja (Id_Cliente) ";
                    sql = sql + "values(" + rs.Fields[0].Value + ")";

                    try
                    {
                        MessageBox.Show(sql);
                        _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 4; //error al ejecutar sentencia SQL.
                    }

                    if (rs.RecordCount == 0)
                    {
                        MessageBox.Show("No se encontraron datos");
                        return 4;
                    }
                }
            }
            return retorno;
        }
        

    }//class ClaseCliente
}//namespace
