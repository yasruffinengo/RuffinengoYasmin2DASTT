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

namespace VISTA
{
    public partial class frmCuentas : Form
    {
        //dueño de la cc que se muestra
        private int _id;
        private Cliente clienteCuentas;

        public frmCuentas(int id)
        {
            InitializeComponent();
            _id = id;

        }

        private void CargarCliente()
        {
            clienteCuentas = Controladora.Controladora.Instancia.ObtenerClientePorId(_id);

            if (clienteCuentas != null)
            {
                label4.Text = clienteCuentas.Apellido + ", " + clienteCuentas.Nombre;
                label5.Text = clienteCuentas.Dni.ToString();
            }
        }
        private void CargarCuentas()
        {
            var cuentas = Controladora.Controladora.Instancia.ListarCuentasPorCliente(_id);
            dgvCuentasCliente.DataSource = cuentas;
            // Ocultamos columnas que no interesan visualmente
            dgvCuentasCliente.Columns["Cliente"].Visible = false;
            dgvCuentasCliente.Columns["ClienteId"].Visible = false;

            // Si querés, podés cambiar encabezados para que queden lindos:
            dgvCuentasCliente.Columns["CuentaCorrienteId"].HeaderText = "ID Cuenta";
        }


        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            CargarCliente();
            //refresca la grilla
            CargarCuentas();
        }

        private void btnNuevaCC_Click(object sender, EventArgs e)
        {
            string mensaje = Controladora.Controladora.Instancia.AgregarCC(_id);

            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refrescamos la grilla para mostrar la nueva CC
            CargarCuentas();

        }

        //btn registrar movimiento 
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCuentasCliente.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una cuenta corriente.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtengo la cuenta seleccionada
                var cuentaSeleccionada = (CuentaCorriente)dgvCuentasCliente.CurrentRow.DataBoundItem;

                // Mensaje de confirmación
                var confirmacion = MessageBox.Show(
                    $"Va a registrar un movimiento para la cuenta ID = {cuentaSeleccionada.CuentaCorrienteId}\n\n¿Desea continuar?",
                    "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.No)
                    return;

                // Abrimos formulario de movimientos
                frmMovimientos frm = new frmMovimientos(cuentaSeleccionada.CuentaCorrienteId);
                frm.ShowDialog();

                // Luego refrescamos la grilla (para actualizar saldo si cambió)
                CargarCuentas();
            }
            catch (Exception ex)
            {
                throw new Exception ("Error al seleccionar cuenta " + ex.Message);  
            }
        }
    }
}
