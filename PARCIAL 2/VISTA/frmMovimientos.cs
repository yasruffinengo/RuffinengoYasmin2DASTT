using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Movimiento;
using VISTA.Utilidades;

namespace VISTA
{
    public partial class frmMovimientos : Form
    {
        //id de cc
        private int Id;

        public frmMovimientos(int _id)
        {
            InitializeComponent();
            //le doy el valor recibido al atrib Id privado del form
            Id = _id;
        }

        //carga los movimientos de la cuetna a la grilla
        private void CargarMovimientos()
        {
            var lista = Controladora.Controladora.Instancia.ListarMovimientos(Id);
            dgvMovimientos.DataSource = lista;

            dgvMovimientos.Columns["CuentaCorriente"].Visible = false;
            dgvMovimientos.Columns["CuentaCorrienteId"].Visible = false;
        }


        private void frmMovimientos_Load(object sender, EventArgs e)
        {
            UtilidadesUI.EsteticaGrilla(dgvMovimientos);
            UtilidadesUI.ColorearMovimientos(dgvMovimientos);
            lblCC.Text = "Cuenta Corriente: " + Id;

            // Cargar Combo Tipo
            cbTipo.DataSource = Enum.GetValues(typeof(TipoMovimiento));

            // Dejar Subtipo deshabilitado hasta elegir tipo
            cbSubtipo.Enabled = false;

            CargarMovimientos();

        }
        

        
        
        //diccionario para diferenciar subtipos por tipo
        private Dictionary<TipoMovimiento, List<SubtipoMovimiento>> _subtiposPorTipo = new Dictionary<TipoMovimiento, List<SubtipoMovimiento>>()
        {
        {
            TipoMovimiento.Credito, new List<SubtipoMovimiento>
            {
                SubtipoMovimiento.Pago,
                SubtipoMovimiento.Abono
            }
        },
        {
            TipoMovimiento.Debito, new List<SubtipoMovimiento>
            {
                SubtipoMovimiento.Cargo,
                SubtipoMovimiento.Compra,
                SubtipoMovimiento.Consumo
            }
        }
        };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //valida saldo suficiente para registrar debito
        private bool ValidarSaldoSuficiente(decimal monto, TipoMovimiento tipo)
        {
            try
            {
                // Solo valida si es un débito
                if (tipo == TipoMovimiento.Debito)
                {
                    // Traer la cuenta corriente actual desde la controladora

                    //??
                    var cuenta = Controladora.Controladora.Instancia.ObtenerCuentaPorId(Id);

                    if (cuenta == null)
                    {
                        MessageBox.Show("No se encontró la cuenta corriente.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Si el saldo actual es menor al monto que se intenta debitar
                    if (cuenta.Saldo < monto)
                    {
                        MessageBox.Show("Saldo insuficiente para realizar esta operación.",
                            "Fondos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                // Si es un crédito o hay suficiente saldo, la validación pasa
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar saldo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aparecen los subtipos en base al tipo seleccionado.
            if (cbTipo.SelectedItem == null)
                return;

            var tipoSeleccionado = (TipoMovimiento)cbTipo.SelectedItem;

            cbSubtipo.DataSource = _subtiposPorTipo[tipoSeleccionado];
            cbSubtipo.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // esto podria mandarlo arafue
            if (dtpFecha.Value.Date != DateTime.Today)
            {
                var respuesta = MessageBox.Show(
                    "Usted está registrando un movimiento con fecha distinta a la fecha actual.\n\n¿Desea continuar?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                    return; 
            }

            var nuevoMovimiento = new Movimiento
            {
                Fecha = dtpFecha.Value,
                Descripcion = txtDescripcion.Text,
                Monto = decimal.Parse(txtMonto.Text),
                Tipo = (TipoMovimiento)cbTipo.SelectedItem,
                Subtipo = (SubtipoMovimiento)cbSubtipo.SelectedItem, 
                CuentaCorrienteId = Id
            };

            // Validar monto
            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Debe ingresar un monto válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nuevoMovimiento.Monto = monto;

            
            if (!ValidarSaldoSuficiente(monto, nuevoMovimiento.Tipo))
            {
                //el otro metodo ya muestra el warning
                return;
            }
            // Llamar al método de la controladora
            string mensaje = Controladora.Controladora.Instancia.AgregarMovimiento(nuevoMovimiento);

            // Mostrar el resultado
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Si fue exitoso, refrescar
            if (mensaje.Contains("correctamente"))
            {
                CargarMovimientos();
                txtDescripcion.Clear();
                txtMonto.Clear();
            }

        }
    }
}
