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
        protected string _nombre;
        protected string _apellido1;
        protected string _apellido2;
        protected string _mail;
        protected List<string> _telefonos;
        protected ADODB.Connection _conexion;

        public ClaseCliente()
        {
            _CI = 0;
            _nombre = "";
            _apellido1 = "";
            _apellido2 = "";
            _mail = "";
            _telefonos = new List<string>();
             _conexion = new ADODB.Connection();
        }

        public ClaseCliente(int CI, string nombre, string apellido1, string apellido2, string mail, List<string> telefonos, ADODB.Connection cn)
        {
            _CI = CI;
            _nombre = nombre;
            _apellido1 = apellido1;
            _apellido2 = apellido2;
            _mail = mail;
            _telefonos = telefonos;
            _conexion = cn;
        }

        public int CI
        {
            get { return _CI; }
            set { _CI = value; }
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
            set { _apellido2 = value;}
        }

        public string mail
        {
            get { return _mail;}
            set { _mail = value; }
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
                    sql = "insert into clientes(`Primer Nombre`,`Primer Apellido`,`Segundo Apellido`,`Mail`)";
                    sql = sql + " values('" + _nombre + "', '" + _apellido1 + "', '" + _apellido2 + "', '" + _mail + "')";
                }
                else
                {
                    sql = "update clientes";
                    sql = sql + "set nombre='" + _nombre + "'";
                    sql = sql + "where ci=" + _CI;
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
                    sql = "delete from cliente_telefonos where cliente=" + _CI;
                    try
                    {
                        _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 3; //error al ejecutar sentencia SQL.
                    }
                }
                foreach (string t in _telefonos)
                {
                    sql = "insert into cliente_telefonos(cliente,telefono) values(" + _CI + ",'" + t + "')";
                    try
                    {
                        _conexion.Execute(sql, out cantFilas, -1);
                    }
                    catch
                    {
                        return 4; //error al ejecutar sentencia SQL.
                    }
                }
            }
            return retorno;
        }//guardar        

    }//class ClaseCliente
}//namespace
