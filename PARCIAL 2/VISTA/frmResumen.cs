using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Movimiento;

namespace VISTA
{
    public partial class frmResumen : Form
    {
        private int Id;
        public frmResumen(int _id)
        {
            InitializeComponent();
            Id = _id;
        }

        private void frmResumen_Load(object sender, EventArgs e)
        {
            lbl1.Text = Id.ToString();
            CargarResumen();
        }
        private void CargarResumen()
        {
            try
            {
                // Obtener los movimientos de la cuenta
                var movimientos = Controladora.Controladora.Instancia.ListarMovimientos(Id).ToList();

                // Mostrar en la grilla
                dgvMovimientosResumen.DataSource = movimientos;
                dgvMovimientosResumen.ReadOnly = true;
                dgvMovimientosResumen.AllowUserToAddRows = false;
                dgvMovimientosResumen.RowHeadersVisible = false;

                dgvMovimientosResumen.Columns["CuentaCorriente"].Visible = false;
                dgvMovimientosResumen.Columns["CuentaCorrienteId"].Visible = false;

                // Calcular totales
                decimal totalCreditos = movimientos
                    .Where(m => m.Tipo == TipoMovimiento.Credito)
                    .Sum(m => m.Monto);

                decimal totalDebitos = movimientos
                    .Where(m => m.Tipo == TipoMovimiento.Debito)
                    .Sum(m => m.Monto);

                decimal saldoActual = totalCreditos - totalDebitos;

                // Mostrar en los labels
                lbl2.Text = totalCreditos.ToString("C2");
                lbl3.Text = totalDebitos.ToString("C2");
                lbl4.Text = saldoActual.ToString("C2");

                // Colorear saldo según signo
                lbl4.ForeColor = saldoActual >= 0 ? Color.Green : Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el resumen: " + ex.Message);
            }
        }


    }
}
