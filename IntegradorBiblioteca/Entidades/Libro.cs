namespace Entidades
{
    public class Libro
    {
        private int libroId;
        private string isbn;
        private string titulo;
        private string autor;
        private estadoLibro estado;
        
        public enum estadoLibro
        {
            Disponible,
            Prestado
        }

        public int LibroId { get { return libroId; } set { libroId = value; } } 
        public string ISBN { get { return isbn; } set { isbn = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } } 
        public string Autor { get { return autor; } set { autor = value; } }
        public estadoLibro Estado { get { return estado; } set { estado = value; } }    
    }
}
