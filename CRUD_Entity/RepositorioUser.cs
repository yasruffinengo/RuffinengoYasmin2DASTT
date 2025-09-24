using CRUD_Entity.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Entity
{
    //inspirado de RepositorioMaterias = RepositorioUser
    //DB UniversidadContext = CursoMvcCore
    public class RepositorioUser
    {
        private CursoMvcCoreContext cursoMvcCoreContext;
        public RepositorioUser() 
        {
            cursoMvcCoreContext = new CursoMvcCoreContext();
        }
        public List<User> Listar()
        {
            return cursoMvcCoreContext.Users.ToList();
        }
        public string Agregar(User user)
        {
            try
            {
                cursoMvcCoreContext.Add(user);
                cursoMvcCoreContext.SaveChanges();
                return "Usuario agregado";
            }
            catch(Exception ex)
            {
                throw new Exception("Error del sistema:" + ex);
            }
        }
        public string Modificar(User user)
        {
            cursoMvcCoreContext.Users.Update(user);
            cursoMvcCoreContext.SaveChanges();
            return "Usuario modificado";
        }

        public string Eliminar(User user)
        {
            cursoMvcCoreContext.Users.Remove(user);
            cursoMvcCoreContext.SaveChanges();
            return "Materia eliminada";
        }
        
    }
}
