using InnoSys;
using InnoSys.Administración;
using InnoSys.Administrador;
using InnoSys.Gerente;
using InnoSys.Transporte;
using System.Drawing;

namespace Grafico
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        //DECLARO LA BASE DE DATOS ADODB (Proyecto, agregar referencia de proyecto  Microsoft ActiveX Data Objects x.x Library)
        public static ADODB.Connection cn = new ADODB.Connection();
        public static ADODB.Recordset rs = new ADODB.Recordset(); //Recordset publico no es necesario
        //*__________________________________________________________________________________*
        public static void doyPermisos(string user)
        {
            string sql = null;
            

            if (cn.State == 0)
            {
                frmLogin.Text = "login";
            }
            else
            {
                frmLogin.Text = "Logout";
                sql = "select user from usuarios where usuario='" + user + "';";
            }
            try
            {
                rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, -1);
            }
            catch
            {
                MessageBox.Show("Error al obtener el rol del usuario");
                rs = null;
                return;
            }
            if (rs.RecordCount == 0)
            {
                MessageBox.Show("El usuario no tiene rol definido. Comuníquese con el administrador.");
            }
            else
            {
                MessageBox.Show("WELCUM");
            }
            rs.Close();
            rs = null;
        }
       

        //Declaro formularios de uso en varios roles
        public static Login frmLogin;
        public static Estados frmEstados = new Estados();
        public static Menu frmMenu = new Menu();
        public static Stock frmStock = new Stock();
        public static Vehículos frmVehículos = new Vehículos();
        public static VerZonas frmVerZonas = new VerZonas();
        public static Pedidos frmPedidos = new Pedidos();
        public static Clientes frmClientes = new Clientes();
        public static Sucursales frmSucursales = new Sucursales();


        //Formularios base
        public static Recepcion frmRecepcion = new Recepcion();
        public static Informatico frmInformatico = new Informatico();
        public static Administracion frmAdministracion = new Administracion();
        public static Cocina frmCocina = new Cocina();
        public static Gerente frmGerente = new Gerente();
        public static Transporte frmTransporte = new Transporte();


        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(frmLogin = new Login());
        }
    }
}