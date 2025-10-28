namespace VISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void RellenarGrilla()
        {
            dgvPartidas.DataSource = null;
            //lo que sigue es propio de singleton
            dgvPartidas.DataSource = Controladora.Controladora.Instancia.Listar();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
