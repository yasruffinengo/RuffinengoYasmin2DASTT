using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {
        public int PartidaId { get; set; }
        public DateTime Fecha { get; set; }
        public List<Jugador> Jugadores { get; set;}

    }
}
