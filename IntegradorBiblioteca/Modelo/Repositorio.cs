using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

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
            catch(Exception ex)
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
    }

}
