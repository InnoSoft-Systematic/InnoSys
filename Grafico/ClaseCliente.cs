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
        protected List<string> _telefonos;
        protected ADODB.Connection _conexion;

        public ClaseCliente()
        {
            _CI = 0;
            _nombre = "";
            _telefonos = new List<string>();
            // _conexion = new ADODB.Connection();
        }

        public ClaseCliente(int CI, string nombre, List<string> telefonos, ADODB.Connection cn)
        {
            _CI = CI;
            _nombre = nombre;
            _telefonos = telefonos;
            // _conexion = cn;
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

        public List<string> telefonos
        {
            get { return _telefonos; }
            set { _telefonos = value; }
        }

     /*   public ADODB.Connection conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }*/


        public int guardar(bool alta)
        {
            int retorno = 0;
            object cantFilas;
            string sql;
            if (Program.cn.State == 0)
            {
                retorno = 1; //conexión cerrada.
            }
            else
            {
                if (alta)
                {
                    sql = "insert into clientes(ci,nombre)";
                    sql = sql + "values(" + _CI + ",'" + _nombre + "')";
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
