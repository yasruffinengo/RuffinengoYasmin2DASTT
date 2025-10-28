namespace Entidades
{
    public class Jugador
    {
        public int JugadorId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //CONEXION ENTRE TABLAS:
        public Partida Partida { get; set; }
        public int PartidaId { get; set; }

    }
}
