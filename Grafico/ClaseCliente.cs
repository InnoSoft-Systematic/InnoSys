using System;
using System.Collections.Generic;
using System.Linq;
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
        protected List<string> _telefonos;
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
            _telefonos = new List<string>();
             _conexion = new ADODB.Connection();
        }

        public ClaseCliente(int CI, int RUT, string nombre, string apellido1, string apellido2, string mail, string direccion, string empresa, List<string> telefonos, ADODB.Connection cn)
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
        public List<string> telefonos
        {
            get { return _telefonos; }
            set { _telefonos = value; }
        }

        public ADODB.Connection conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
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
                    _telefonos.Clear();
                    while (!rs.EOF) //mientras no llegue al fin 
                    {
                        _telefonos.Add(Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext(); //nos movemos al siguiente registro
                    }
                }
                rs.Close();
                rs = null; // destruyo el objeto.
            }//if
            return (retorno);
        }//buscar

        public byte guardar(bool alta)
        {
            byte retorno = 0;
            object cantFilas;
            string sql;
            if (_conexion.State == 0)
            {
                retorno = 1; //conexión cerrada.
            }
            else
            {
                if (alta)
                {
                    sql = "insert into clientes(Mail,Tel,Id_Zona);";
                    sql = sql + " values('" +_mail + "', '" + _telefonos + "', '"  ;
                    sql = "insert into persona (`CI`,`Primer_nombre`,`Primer_apellido`,`Segundo_apellido`,`Direcion`) ";
                    sql = sql + " values('" + _CI + "', '" + _nombre + "', '" + _apellido1 + "', '" + _apellido2 + "', '" + _direccion + "')";
                }
                else
                {
                   
                    sql = "update clientes";
                   //sql = sql + "set nombre='" + _nombre + "'";
                    //sql = sql + "where ci=" + _CI;
                }
                try
                {
                    _conexion.Execute(sql, out cantFilas, -1);
                }
                catch
                {
                    return 2; //error al ejecutar sentencia SQL.
                }
                if (!alta)
                {
                   // sql = "delete from cliente_telefonos where cliente=" + _CI;
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

    }//class ClaseCliente
}//namespace
