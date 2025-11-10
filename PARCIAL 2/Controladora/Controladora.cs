using Entidades;
using Microsoft.IdentityModel.Tokens;
using Modelo;
using System.Text.RegularExpressions;

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
    }
}
