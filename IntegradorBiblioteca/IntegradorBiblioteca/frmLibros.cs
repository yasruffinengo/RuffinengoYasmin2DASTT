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
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
            Refrescar();
        }

        private void Refrescar()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = Controladora.Controladora.Instancia.ListarLibros();
        }
        private void LimpiarCampos()
        {
            txtAutor.Clear();
            txtEstado.Clear();
            txtISBN.Clear();
            txtTitulo.Clear();
            txtISBN.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Libro libro = new Libro();
            libro.Autor = txtAutor.Text;
            libro.ISBN = txtISBN.Text;
            libro.Estado = Libro.estadoLibro.Disponible;
            libro.Titulo = txtTitulo.Text;
            //este saque
            //Controladora.Controladora.Instancia.AgregarSocio(socio);


            // Llamar a la controladora y recibir el resultado
            string mensaje = Controladora.Controladora.Instancia.AgregarLibro(libro);

            // Mostrar el resultado
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Si se agregó correctamente, limpiar los campos
            if (mensaje == "Libro agregado correctamente.")
                LimpiarCampos();
            Refrescar();

        }

        private void frmLibros_Load(object sender, EventArgs e)
        {

        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
