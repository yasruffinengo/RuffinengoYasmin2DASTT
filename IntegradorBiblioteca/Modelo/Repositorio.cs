using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;


namespace Modelo
{
    public class Repositorio
    {
        private Context context;

        public Repositorio()
        {
            context = new Context();
        }

        public void AgregarSocio(Socio socio)
        {
            try
            {
                context.Socios.Add(socio);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                //throw new Exception("error al agregar socio: " + ex.Message);
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarSocio(): " + detalle);
            }
        }
        public void ModificarSocio(Socio socio)
        {
            try
            {
                context.Socios.Update(socio);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error al modificar socio: " + ex.Message);
            }
        }
        public void EliminarSocio(Socio socio)
        {
            try
            {
                context.Socios.Remove(socio);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error al eliminar socio: " + ex.Message);
            }
        }
        public IReadOnlyCollection<Socio> ListarSocios()
        {
            try
            {
                return context.Socios.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar socios: " + ex.Message);
            }
        }


        /// LIBRRROOOOSSS
        public void AgregarLibro(Libro libro)
        {
            try
            {
                context.Libros.Add(libro);
                context.SaveChanges();
            }
            
            catch (Exception ex)
            {
                //throw new Exception("error al agregar socio: " + ex.Message);
                string detalle = ex.Message;
                throw new Exception("Error en Repositorio.AgregarLibro(): " + detalle);
            }
        }
        public void ModificarLibro(Libro libro)
        {
            try
            {
                context.Libros.Update(libro);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error al modificar libro: " + ex.Message);
            }
        }
        public void EliminarLibro(Libro libro)
        {
            try
            {
                context.Libros.Remove(libro);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("error al eliminar libro: " + ex.Message);
            }
        }
        public IReadOnlyCollection<Libro> ListarLibro()
        {
            try
            {
                return context.Libros.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar libros: " + ex.Message);
            }
        }



        /// PRESTAMOSSSS
        public IReadOnlyCollection<Prestamo> ListarPrestamos()
        {
            try
            {
                return context.Prestamos.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar prestamos: " + ex.Message);
            }
        }
        public void AgregarPrestamo(Prestamo prestamo)
        {
            try
            {
                context.Prestamos.Add(prestamo);
                context.SaveChanges();
            }

            catch (Exception ex)
            {

                throw new Exception("Error en Repositorio.AgregarPrestamo(): " + ex.Message);
            }
        }

    }

}
