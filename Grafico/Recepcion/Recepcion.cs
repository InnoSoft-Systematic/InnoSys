using InnoSys;

namespace Grafico
{
    public partial class Recepcion : Form
    {//tatatat
        public Recepcion()
        {
            InitializeComponent();
            //Indico que va a ser padre de otras ventanas, que sea un contenedor MdiContainer
            // IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Disposed(object sender, EventArgs e)
        {
            Program.frmLogin.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static IngresoPedido frmIngresoPedido = new IngresoPedido();
        public static Cliente frmAltaBajaCliente = new Cliente();

        private void button1_Click(object sender, EventArgs e)
        {
            frmAltaBajaCliente.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIngresoPedido.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Llamo a formulario Menu desde Program, porque está instanciada ahí y es pública
            Program.frmMenu.ShowDialog();
        }

        private void btmEstado_Click(object sender, EventArgs e)
        {
            //Llamo a formulario Estados desde Program, porque está instanciada ahí y es pública
            Program.frmEstados.ShowDialog();
        }
    }
}