using InnoSys;
using InnoSys.Administración;
using InnoSys.Administrador;
using InnoSys.Gerente;
using InnoSys.Transporte;

namespace Grafico
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        //Declaro formularios de uso en varios roles
        public static Login frmLogin;
        public static Estados frmEstados = new Estados();
        public static Menu frmMenu = new Menu();
        public static Stock frmStock = new Stock();
        public static Vehículos frmVehículos = new Vehículos();
        public static VerZonas frmVerZonas = new VerZonas();

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