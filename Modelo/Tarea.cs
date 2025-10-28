using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("Tarea")]
    public class Tarea
    {
        public int TareaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public int ProyectoId { get; set; } 
        public Proyecto Proyecto { get; set; }
    }
}
