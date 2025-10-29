using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegradorBiblioteca
{
    public partial class frmSocios : Form
    {
        //sirve para el btnGuardar
        private Socio socioEnEdicion;

        //metodo refrescar util solo para este formulario
        private void Refrescar()
        {
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = Controladora.Controladora.Instancia.ListarSocios();
        }
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDni.Focus();
        }
        public frmSocios()
        {
            InitializeComponent();
            Refrescar();
        }

        private void frmSocios_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(socioEnEdicion == null)
            {
                Socio socio = new Socio();
                socio.Dni = txtDni.Text;
                socio.NombreCompleto = txtNombre.Text;
                socio.Email = txtEmail.Text;
                socio.Telefono = txtTelefono.Text;
                //este saque
                //Controladora.Controladora.Instancia.AgregarSocio(socio);


                // Llamar a la controladora y recibir el resultado
                string mensaje = Controladora.Controladora.Instancia.AgregarSocio(socio);

                // Mostrar el resultado
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Si se agregó correctamente, limpiar los campos
                if (mensaje == "Socio agregado correctamente.")
                    LimpiarCampos();
            }
            else
            {
                socioEnEdicion.Dni = txtDni.Text;
                socioEnEdicion.NombreCompleto = txtNombre.Text;
                socioEnEdicion.Email = txtEmail.Text;
                socioEnEdicion.Telefono = txtTelefono.Text;

                string mensaje = Controladora.Controladora.Instancia.ModificarSocio(socioEnEdicion);
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                socioEnEdicion = null; // salís del modo edición
                LimpiarCampos();
            }
            Refrescar();

        }

        private void dgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un socio para eliminar.");
                return;
            }

            // Obtener socio de la fila seleccionada
            Socio socioSeleccionado = (Socio)dgvSocios.CurrentRow.DataBoundItem;

            // Confirmación (opcional)
            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que desea eliminar este socio?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
                return;



            string mensaje = Controladora.Controladora.Instancia.EliminarSocio(socioSeleccionado.SocioId);

            MessageBox.Show(mensaje);

            Refrescar();
        }

        private void LlenarCampos(Socio socio)
        {
            txtDni.Text = socio.Dni.ToString();
            txtNombre.Text = socio.NombreCompleto.ToString();
            txtEmail.Text = socio.Email.ToString(); 
            txtTelefono.Text = socio.Telefono.ToString();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un socio para editar.");
                return;
            }

            socioEnEdicion = (Socio)dgvSocios.CurrentRow.DataBoundItem;
            LlenarCampos(socioEnEdicion);
        }
    }
}
