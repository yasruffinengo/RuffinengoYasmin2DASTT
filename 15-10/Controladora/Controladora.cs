using Entidades;
using Modelo;
using System.Diagnostics.Metrics;


namespace Controladora
{

    public class Controladora
    {

        private Repositorio repositorio = new Repositorio();
        //vamos a aplicar el patron singleton
        //de diseñpo creacional, osea, que c/clase tenga una unica instancia
        //verifica si el obj de ese tipo ya esta creado
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
        public IReadOnlyCollection<Partida> Listar()
        {
            return repositorio.Listar();
        }


        //validaciones: 
        //-que se eliijan dos jugadores distintos
        //-
        public string Agregar(Partida partida)
        {
            //valido fecha
            var fechaMayor = DateTime.Now > partida.Fecha;
            if (fechaMayor)
            {
                repositorio.Agregar(partida);
                return "Partida registrada";
            }
            return "La fecha ya caduco";
        }

        //para asignar un jugador en una partida
        public string AsignarJugador(Partida partida, Jugador jugador)
        {
            var existeJugador = partida.Jugadores.FirstOrDefault(x => x == jugador);
            //conteo cantidad de jugadores en la partida
            var maximoJugadores = partida.Jugadores.Count();

            if (existeJugador == null && maximoJugadores < 2 )
            {
                partida.Jugadores.Add(jugador);
                return "Jugador asociado";
            }
            return "No se pudo asociar al jugador";
        }
    }
}
