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
        //vamos a hacer partida nomas porque es una composicion
        //los jugadores se cargan en el front 
        public Repositorio()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Partida> Listar()
        {
            return context.Partidas.ToList().AsReadOnly();
        }
        public void Agregar(Partida partida)
        {
            context.Partidas.Add(partida);
            context.SaveChanges();
        }
        public void Modificar(Partida partida)
        {
            context.Partidas.Update(partida);
            context.SaveChanges();
        }

        public void Eliminar(Partida partida)
        {
            context.Partidas.Remove(partida);
            context.SaveChanges();
        }
    }
}
