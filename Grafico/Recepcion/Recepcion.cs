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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static ControlClientes frmControlClientes = new ControlClientes();
        public static IngresoPedido frmIngresoPedido = new IngresoPedido();
        public static PUIngresoCorrecto PopIngresoPedido = new PUIngresoCorrecto();

        private void button1_Click(object sender, EventArgs e)
        {
            // Program.Recepcion.Hide();

            frmControlClientes.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIngresoPedido.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Llamo a formulario Menu desde Program, porque está instanciada ahí y es pública
            Program.frmMenu.Show();
        }

        private void btmEstado_Click(object sender, EventArgs e)
        {
            //Llamo a formulario Estados desde Program, porque está instanciada ahí y es pública
            Program.frmEstados.Show();
        }
    }
}