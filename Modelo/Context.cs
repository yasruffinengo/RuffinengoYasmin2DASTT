using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //DbContext clase que conecta con la bdd 
    //MUY IMPORTANTE que esta clase herede DbContext
    public class Context : DbContext
    {
        private string conexion = "Data Source=YASMIN-PC\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;";

        public DbSet<Proyecto> proyectos {  get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(conexion);
    }
}
