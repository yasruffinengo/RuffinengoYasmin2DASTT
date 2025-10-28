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
            Socio socio = new Socio();
            socio.Dni = txtDni.Text;
            socio.NombreCompleto = txtNombre.Text;
            socio.Email= txtEmail.Text;
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
            Refrescar();

        }
    
    }
}
