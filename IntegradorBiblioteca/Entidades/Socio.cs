using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Socio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /*
        private int socioId;
        private string dni;
        private string nombreCompleto;
        private string email;
        private string telefono;
        */
        public int SocioId { get; set; }
        public string Dni { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }    
        public string Telefono { get; set; }


    }
}
