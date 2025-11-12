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
using VISTA.Utilidades;

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

            // Calcular y mostrar el saldo total
            CalcularSaldoTotal();
        }


        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            UtilidadesUI.EsteticaGrilla(dgvCuentasCliente);
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
        private CuentaCorriente ObtenerCuentaGrid()
        {
            if (dgvCuentasCliente.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una cuenta corriente.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return (CuentaCorriente)dgvCuentasCliente.CurrentRow.DataBoundItem;
        }


        //btn registrar movimiento 
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                var cuenta = ObtenerCuentaGrid();
                if (cuenta == null) return;


                // Mensaje de confirmación
                var confirmacion = MessageBox.Show(
                    $"Va a registrar un movimiento para la cuenta ID = {cuenta.CuentaCorrienteId}\n\n¿Desea continuar?",
                    "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.No)
                    return;

                // Abrimos formulario de movimientos
                frmMovimientos frm = new frmMovimientos(cuenta.CuentaCorrienteId);
                frm.ShowDialog();

                // Luego refrescamos la grilla (para actualizar saldo si cambió)
                CargarCuentas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al seleccionar cuenta " + ex.Message);
            }
        }

        //boton eliminar
        private void button1_Click(object sender, EventArgs e)
        {
            //metodo reutilizable
            var cuenta = ObtenerCuentaGrid();
            if (cuenta == null) return;

            var confirmar = MessageBox.Show(
                $"¿Está seguro de eliminar la Cuenta Corriente Nº {cuenta.CuentaCorrienteId}?\n" +
                "Esta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmar != DialogResult.Yes)
                return;

            // Llamo a controladora
            string resultado = Controladora.Controladora.Instancia.EliminarCC(cuenta.CuentaCorrienteId);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refrescar grilla
            CargarCuentas();

        }

        private void CalcularSaldoTotal()
        {
            decimal saldoTotal = 0;

            // Si la grilla está vacía, mostramos 0
            if (dgvCuentasCliente.DataSource is List<CuentaCorriente> cuentas && cuentas.Any())
            {
                saldoTotal = cuentas.Sum(c => c.Saldo);
            }

            lblSaldoTotal.Text = $"Saldo Total: {saldoTotal:C}";
        }

        private void lblSaldoTotal_Click(object sender, EventArgs e)
        {

        }
        //boton resumen cuetna
        private void button2_Click(object sender, EventArgs e)
        {

            var cuenta = ObtenerCuentaGrid();
            if (cuenta == null) return;
            frmResumen frm = new frmResumen(cuenta.CuentaCorrienteId);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cuenta = ObtenerCuentaGrid();
            if (cuenta == null) return;
            frmMovimientos frm = new frmMovimientos(cuenta.CuentaCorrienteId);
            frm.ShowDialog();
        }
    }
}
