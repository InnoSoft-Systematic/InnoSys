using InnoSys;

namespace Grafico
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        //Declaro el formulario Login
        public static Login frmLogin;
        public static Recepcion frmRecepcion = new Recepcion();
        public static Estados frmEstados = new Estados();
        public static Menu frmMenu = new Menu();
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