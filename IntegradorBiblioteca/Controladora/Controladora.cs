using Entidades;
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

        public List<Socio> ListarSocios()
        {
            try
            {
                return repositorio.ListarSocios().ToList();
            }
            catch(Exception ex)
            {
                throw new Exception("error al listar socios " + ex.Message);
            }

        }
        public string AgregarSocio(Socio socio)
        {
            //DNI 8 digitos
            //email formato valido de correo
            //telefono 10 digitos formato XXXX-XXXXXX
            // Validaciones por expresiones regulares
            try
            {
                if (!Regex.IsMatch(socio.Dni, @"^\d{8}$"))
                    return "Error: El DNI debe tener exactamente 8 dígitos.";

                if (!Regex.IsMatch(socio.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    return "Error: El formato del correo electrónico no es válido.";

                if (!Regex.IsMatch(socio.Telefono, @"^\d{4}-\d{6}$"))
                    return "Error: El teléfono debe tener el formato XXXX-XXXXXX.";

                // Si todas las validaciones pasan, se agrega al repositorio
                repositorio.AgregarSocio(socio);
                return "socio agregado correctamente";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al agregar socio: " + detalle;
            }


        }
    }
}
