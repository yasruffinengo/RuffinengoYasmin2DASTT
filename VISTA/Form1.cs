using Controladora;

namespace VISTA
{
    public partial class Form1 : Form
    {

        //creo una atrib privado de tipo ControladoraProyecto "controladora"
        private ControladoraProyecto controladora;

        public Form1()
        {
            InitializeComponent();
            controladora = new ControladoraProyecto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            var grilla = controladora.Listar();
            dgvProyecto.DataSource = grilla.ToList();
        }
    }
}
