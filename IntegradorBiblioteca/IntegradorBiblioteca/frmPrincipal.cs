namespace IntegradorBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //metodos para los cmb
            CargarLibros();
            CargarSocios();
            Refrescar();
        }
        private void Refrescar()
        {
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = Controladora.Controladora.Instancia.ListarPrestamos();
        }

        //metodos para los cmb
        private void CargarSocios()
        {
            var lista = Controladora.Controladora.Instancia.ListarSocios();

            cmbSocio.DataSource = lista;
            cmbSocio.DisplayMember = "NombreCompleto"; // lo que el usuario ve
            cmbSocio.ValueMember = "SocioId"; // el ID real que necesitas para registrar
            cmbSocio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSocio.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void CargarLibros()
        {

            var lista = Controladora.Controladora.Instancia.ListarLibros();

            cmbLibro.DataSource = lista;
            cmbLibro.DisplayMember = "Titulo";
            cmbLibro.ValueMember = "LibroId";
            cmbLibro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLibro.AutoCompleteSource = AutoCompleteSource.ListItems;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            frmSocios frm = new frmSocios();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLibros frm = new frmLibros();
            frm.ShowDialog();
        }

        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {

            if (cmbSocio.SelectedValue == null || cmbLibro.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un socio y un libro.");
                return;
            }

            int socioId = Convert.ToInt32(cmbSocio.SelectedValue);
            int libroId = Convert.ToInt32(cmbLibro.SelectedValue);

            string mensaje = Controladora.Controladora.Instancia.AgregarPrestamo(socioId, libroId);
            MessageBox.Show(mensaje);

            // Recargar listas por si el libro pasó a Prestado
            CargarLibros();
            Refrescar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
