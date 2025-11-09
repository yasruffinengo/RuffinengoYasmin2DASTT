using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //metodo para validar ISBN
        private bool ValidarISBN(string isbn)
        {
            // Formato clásico ISBN-13 con guiones
            return Regex.IsMatch(isbn, @"^\d{3}-\d-\d{4}-\d{4}-\d$");
        }
        //guardar libro
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Libro libro = new Libro();
            libro.Autor = txtAutor.Text;
            try
            {
                bool isbnValidado = ValidarISBN(libro.ISBN);
                if (!isbnValidado)
                {
                    //aca como hago??
                    MessageBox.Show("Error: El ISBN debe tener el formato XXX-X-XXXX-XXXX-X.");
                }
                libro.ISBN = txtISBN.Text;
                libro.Estado = Libro.estadoLibro.Disponible;
                libro.Titulo = txtTitulo.Text;
                // Llamar a la controladora y recibir el resultado
                string mensaje = Controladora.Controladora.Instancia.AgregarLibro(libro);

                // Mostrar el resultado
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Si se agregó correctamente, limpiar los campos
                if (mensaje == "Libro agregado correctamente.")
                    LimpiarCampos();
                Refrescar();
            }
            catch (Exception ex)
            {
                throw new Exception("error al guardar libro");
            }


        }

        private void frmLibros_Load(object sender, EventArgs e)
        {

        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
