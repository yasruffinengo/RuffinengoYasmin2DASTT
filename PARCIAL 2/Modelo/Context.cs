using System.Data.Common;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        private string conexion = "Data Source=YASMIN-PC\\SQLEXPRESS;Initial Catalog=PARCIAL;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;";

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<CuentaCorriente> Cuentas { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(conexion);

    }
}
