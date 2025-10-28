using Modelo;
using System.Timers;

namespace Controladora
{
    public class ControladoraProyecto
    {
        //campo privado que es una instancia del DbContext
        private Context context;


        public ControladoraProyecto()
        {   
            //inicializo asi conecta a la bdd
            context = new Context();
        }

        public string Agregar(Proyecto proyecto)
        {
            try
            {
                //busca si ya hay un proy con ese nombre
                var existeProyecto = context.proyectos.FirstOrDefault(x => x.Nombre == proyecto.Nombre);
                if (existeProyecto == null)
                {
                    context.proyectos.Add(proyecto);
                    context.SaveChanges();
                    return "Proyecto agregado";
                }
                return "El proyecto ya fue agregado";

            }
            catch (Exception ex)
            {
                throw new Exception("error: " + ex.Message);
            }
        }
        public IReadOnlyCollection<Proyecto> Listar()
        {
            return context.proyectos.ToList().AsReadOnly();
        }

    }
}
