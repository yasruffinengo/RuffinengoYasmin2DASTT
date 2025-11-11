using Entidades;
using Microsoft.IdentityModel.Tokens;
using Modelo;
using System.Text.RegularExpressions;
using static Entidades.Movimiento;

namespace Controladora
{
    public class Controladora
    {
        private Repositorio repositorio = new Repositorio();
        //patron singleton
        //c/clase tiene una unica instancia
        //verifica si el obj ya esta creado
        //si esta creado usa ese, sino crea uno
        private static Controladora instancia;

        //propiedad de solo lectura.
        //se llama siempre a esta
        public static Controladora Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    return instancia = new Controladora();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }


        //CLIENTES
        public List<Cliente> ListarClientes()
        {
            try
            {
                return repositorio.ListarClientes().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar clientes " + ex.Message);
            }

        }
        public Cliente ObtenerClientePorId(int id)
        {
            try
            {
                return repositorio.ObtenerClientePorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("error al obtener cliente " + ex.Message);
            }
        }

        public string AgregarCliente(Cliente cliente)
        {
            try
            {
                repositorio.AgregarCliente(cliente);
                return "Cliente agregado correctamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar cliente " + ex.Message);
            }
        }
        public string ModificarCliente(Cliente cliente)
        {
            try
            {

                repositorio.ModificarCliente(cliente);
                return "Cliente modificado correctamente.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar cliente " + ex.Message);
            }
        }
        public string EliminarCliente(int clienteId)
        {
            try
            {
                // Buscar socio antes de eliminar
                var cliente = repositorio.ListarClientes().FirstOrDefault(c => c.ClienteId == clienteId);

                if (cliente == null)
                    return "Error: El cliente no existe o ya fue eliminado.";

                // Si existe, eliminar
                repositorio.EliminarCliente(cliente);
                return "Cliente eliminado correctamente.";
            }
            catch (Exception ex)
            {
                throw new Exception ("Error al eliminar cliente" + ex.Message);
            }
        }


        //CUENTAS
        public List<CuentaCorriente> ListarCuentasPorCliente(int id)
        {
            try
            {
                return repositorio.ObtenerCuentasPorCliente(id);
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar cuentas del cliente " + ex.Message);
            }
        }
        public string AgregarCC(int clienteId)
        {
            try
            {
                CuentaCorriente cuenta = new CuentaCorriente();
                cuenta.ClienteId = clienteId;
                cuenta.Saldo = 0;
                cuenta.Movimientos = new List<Movimiento>();

                repositorio.AgregarCC(cuenta);
                return "cuenta corriente creada correctamente.";
            }
            catch (Exception ex)
            {
                return "error al crear cuenta: " + ex.Message;
            }
        }

        //Modificar? cc
        //Eliminar CC

        //MOVIMIENTOS

        public IReadOnlyCollection<Movimiento> ListarMovimientos(int ccId)
        {
            try
            {
                return repositorio.ListarMovimientos(ccId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los movimientos: " + ex.Message);
            }
        }
        public string AgregarMovimiento(Movimiento mo)
        {
            try
            {
                // Validaciones
                if (mo.Monto <= 0)
                    return "El monto debe ser mayor que cero.";

                if (string.IsNullOrWhiteSpace(mo.Descripcion))
                    return "Debe ingresar una descripción.";

                // Obtener la cuenta para actualizar el saldo
                //tiene que devolver una cuenta
                var cuenta = repositorio.ObtenerCuentaPorId(mo.CuentaCorrienteId);

                if (cuenta == null)
                    return "No se encontró la cuenta corriente.";

                // Ajustar saldo según tipo
                if (mo.Tipo == TipoMovimiento.Credito)
                    cuenta.Saldo += mo.Monto;
                else
                    cuenta.Saldo -= mo.Monto;

                // Guardar Movimiento
                repositorio.AgregarMovimiento(mo);

                // Guardar actualización de saldo
                repositorio.ModificarCC(cuenta);

                return "Movimiento registrado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al registrar movimiento: " + ex.Message;
            }
        }
    }
}
