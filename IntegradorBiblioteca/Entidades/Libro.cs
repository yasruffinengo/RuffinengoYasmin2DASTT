namespace Entidades
{
    public class Libro
    {

        
        public enum estadoLibro
        {
            Disponible,
            Prestado
        }

        public int LibroId { get; set; } 
        public string ISBN { get; set; }
        public string Titulo { get; set;} 
        public string Autor { get; set; }
        public estadoLibro Estado { get; set;}    
    }
}
