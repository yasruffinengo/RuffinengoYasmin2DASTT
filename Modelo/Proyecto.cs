using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //para indicarle el nombre de la tabla
    [Table("Proyecto")]
    public class Proyecto
    {
        public int ProyectoId { get; set; } 
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }
        public List<Tarea> ListaTareas { get; set; } 

    }
}
