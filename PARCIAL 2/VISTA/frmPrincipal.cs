using Entidades;

namespace VISTA
{
    public partial class frmPrincipal : Form
    {
        //para editar
        private Cliente clienteEnEdicion;
        public frmPrincipal()
        {
            InitializeComponent();
            Refrescar();
        }

        //llena la grilla actualizada
        private void Refrescar()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Controladora.Controladora.Instancia.ListarClientes();
        }
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            //txtDni.Focus();
        }
        private void LlenarCampos(Cliente cliente)
        {
            txtDni.Text = cliente.Dni.ToString();
            txtNombre.Text = cliente.Nombre.ToString();
            txtApellido.Text = cliente.Apellido.ToString();
            txtTelefono.Text = cliente.Telefono.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.RowHeadersVisible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (clienteEnEdicion == null)
            {
                Cliente cliente = new Cliente();
                cliente.Dni = txtDni.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Telefono = txtTelefono.Text;

                // Llamar a la controladora y recibir el resultado
                string mensaje = Controladora.Controladora.Instancia.AgregarCliente(cliente);

                // Mostrar el resultado
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Si se agregó correctamente, limpiar los campos
                if (mensaje == "Cliente agregado correctamente.")
                    LimpiarCampos();
            }
            else
            {
                clienteEnEdicion.Dni = txtDni.Text;
                clienteEnEdicion.Nombre = txtNombre.Text;
                clienteEnEdicion.Apellido = txtApellido.Text;
                clienteEnEdicion.Telefono = txtTelefono.Text;

                string mensaje = Controladora.Controladora.Instancia.ModificarCliente(clienteEnEdicion);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clienteEnEdicion = null; // salís del modo edición
                LimpiarCampos();
            }
            Refrescar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnAgregar.Text = "Guardar";
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para editar.");
                return;
            }

            clienteEnEdicion = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            LlenarCampos(clienteEnEdicion);
            Controladora.Controladora.Instancia.ModificarCliente(clienteEnEdicion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.");
                return;
            }

            // Obtener cliente de la fila seleccionada
            Cliente clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            // Confirmación 
            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que desea eliminar cliente con dni " + clienteSeleccionado.Dni + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
                return;

            string mensaje = Controladora.Controladora.Instancia.EliminarCliente(clienteSeleccionado.ClienteId);

            MessageBox.Show(mensaje);

            Refrescar();
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para gestionar sus cuentas.");
                return;
            }
            //obtengo cliente
            Cliente clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            
            frmCuentas frm = new frmCuentas(clienteSeleccionado.ClienteId);
            frm.ShowDialog();
        }
    }
}
