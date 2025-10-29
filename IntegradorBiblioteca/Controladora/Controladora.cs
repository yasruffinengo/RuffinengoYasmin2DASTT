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



        //
        //SOCIOS
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
        private string ValidarSocio(Socio socio)
        {
            if (!Regex.IsMatch(socio.Dni, @"^\d{8}$"))
                return "Error: El DNI debe tener exactamente 8 dígitos.";

            if (!Regex.IsMatch(socio.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Error: El formato del correo electrónico no es válido.";

            if (!Regex.IsMatch(socio.Telefono, @"^\d{4}-\d{6}$"))
                return "Error: El teléfono debe tener el formato XXXX-XXXXXX.";

            return "OK"; 
        }

        public string AgregarSocio(Socio socio)
        {
            try
            {
                string validacion = ValidarSocio(socio);
                if (validacion != "OK")
                    return validacion;

                repositorio.AgregarSocio(socio);
                return "Socio agregado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al agregar socio: " + detalle;
            }
        }
        public string ModificarSocio(Socio socio)
        {
            try
            {
                string validacion = ValidarSocio(socio);
                if (validacion != "OK")
                    return validacion;

                repositorio.ModificarSocio(socio);
                return "Socio modificado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al modificar socio: " + detalle;
            }
        }
        public string EliminarSocio(int socioId)
        {
            try
            {
                // Buscar socio antes de eliminar
                var socio = repositorio.ListarSocios().FirstOrDefault(s => s.SocioId == socioId);

                if (socio == null)
                    return "Error: El socio no existe o ya fue eliminado.";

                // Si existe, eliminar
                repositorio.EliminarSocio(socio);
                return "Socio eliminado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al eliminar socio: " + detalle;
            }
        }


        //
        //LIBROS
        public List<Libro> ListarLibros()
        {
            try
            {
                return repositorio.ListarLibro().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar libros " + ex.Message);
            }

        }
        private bool ValidarISBN(string isbn)
        {
            // Formato clásico ISBN-13 con guiones
            return Regex.IsMatch(isbn, @"^\d{3}-\d-\d{4}-\d{4}-\d$");
        }
        public string AgregarLibro(Libro libro)
        {
            string isbn = libro.ISBN;
            try
            {
                bool isbnValidado = ValidarISBN(isbn);
                if (!isbnValidado)
                {
                    return "Error: El ISBN debe tener el formato XXX-X-XXXX-XXXX-X.";
                }

                repositorio.AgregarLibro(libro);
                return "libro agregado correctamente";
            }
            catch (Exception ex)
            {
                string detalle = ex.Message;
                return "Error al agregar socio: " + detalle;
            }
        }

        //falta modificar y eliminar


        //
        //PRESTAMOS
        public string AgregarPrestamo(int socioId, int libroId)
        {
            try
            {
                //buscar socio
                var socio = repositorio.ListarSocios().FirstOrDefault(s => s.SocioId == socioId);
                if (socio == null)
                    return "error: el socio no esta registrado.";

                //buscar libro
                var libro = repositorio.ListarLibro().FirstOrDefault(l => l.LibroId == libroId);
                if (libro == null)
                    return "error; libro no registrado.";
                //verificar disponibilidad del libro
                if (libro.Estado == Libro.estadoLibro.Prestado)
                    return "error: libro prestado";
                //creo prestamo
                Prestamo prestamo = new Prestamo(); 
                prestamo.SocioId = socioId;
                prestamo.LibroId = libroId;
                prestamo.FechaPrestamo = DateTime.Now;
                prestamo.FechaDevolucion = null;

                //cambio el estado del libro
                libro.Estado = Libro.estadoLibro.Prestado;
                repositorio.ModificarLibro(libro);
                //guardar prestamo
                repositorio.AgregarPrestamo(prestamo);
                return "prestamo registrado correctamente";

            }
            catch(Exception ex)
            {
                return "error al registrar prestamo: " + ex.Message;
            }
        }
        public List<Prestamo> ListarPrestamos()
        {
            try
            {
                return repositorio.ListarPrestamos().ToList();
            }
            catch(Exception ex)
            {
                throw new Exception("error al listar prestamos " + ex.Message);
            }
        }
    }
}
