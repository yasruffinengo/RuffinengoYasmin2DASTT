using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Repositorio
    {
        private Context context;

        public Repositorio()
        {
            context = new Context();
        }

        //CLIENTES
        public void AgregarCliente(Cliente cliente)
        {
            try
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Repositorio.AgregarCliente(): " + ex.Message);
            }
        }
        public void ModificarCliente (Cliente cliente)
        {
            try
            {
                context.Clientes.Update(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error al modificar cliente: " + ex.Message);
            }
        }
        public void EliminarCliente(Cliente cliente)
        {
            try
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error al eliminar cliente: " + ex.Message);
            }
        }
        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            try
            {
                return context.Clientes.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar clientes: " + ex.Message);
            }
        }
        //cliente por id
        public Cliente ObtenerClientePorId(int id)
        {
            return context.Clientes.FirstOrDefault(c => c.ClienteId == id);
        }



        //CuentasCorrientes
        public void AgregarCC(CuentaCorriente cuenta)
        {
            try
            {
                context.Cuentas.Add(cuenta);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Repositorio.AgregarCC(): " + ex.Message);
            }
        }
        public void ModificarCC(CuentaCorriente cuenta)
        {
            try
            {
                context.Cuentas.Update(cuenta);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error en Repositorio.ModificarCC(): " + ex.Message);
            }
        }
        public void EliminarCC(CuentaCorriente cuenta)
        {
            try
            {
                context.Cuentas.Remove(cuenta);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error en Repositorio.EliminarCC(): " + ex.Message);
            }
        }
        public IReadOnlyCollection<CuentaCorriente> ListarCC()
        {
            try
            {
                return context.Cuentas.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw new Exception("error en Repositorio.ListarCC()" + ex.Message);
            }
        }
        //devuelve cuenta por Id
        public CuentaCorriente ObtenerCuentaPorId(int id)
        {
            try
            {
                return context.Cuentas.FirstOrDefault(c => c.CuentaCorrienteId == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Repositorio.ObtenerCuentaPorId(): " + ex.Message);
            }
        }

        //cuentas por cliente
        public List<CuentaCorriente> ObtenerCuentasPorCliente(int idCliente)
        {
            return context.Cuentas.Where(cc => cc.ClienteId == idCliente).ToList();
        }



        //Movimientos
        public void AgregarMovimiento(Movimiento mo)
        {
            try
            {
                context.Movimientos.Add(mo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Repositorio.AgregarMovimiento(): " + ex.Message);
            }
        }

        public void ModificarMovimiento(Movimiento mo)
        {
            try
            {
                context.Movimientos.Update(mo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error en Repositorio.ModificarMovimento(): " + ex.Message);
            }
        }

        public void EliminarMovimiento(Movimiento mo)
        {
            try
            {
                context.Movimientos.Remove(mo);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error en Repositorio.EliminarMovimiento(): " + ex.Message);
            }
        }
        
        public IReadOnlyCollection<Movimiento> ListarMovimientos(int ccId)
        {
            try
            {
                return context.Movimientos
                    .Where(m => m.CuentaCorrienteId == ccId).ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw new Exception("error en Repositorio.ListarMovimientos()" + ex.Message);
            }
        }

    }
}
