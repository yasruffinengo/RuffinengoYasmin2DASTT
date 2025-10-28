using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Modelo
{
    public class Context : DbContext
    {
        private string conexion = "Data Source=YASMIN-PC\\SQLEXPRESS;Initial Catalog=IntegradorBiblioteca;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;";

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Socio> Socios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(conexion);
    }
}
