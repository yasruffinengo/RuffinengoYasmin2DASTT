using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public string Dni {  get; set; }
        public string Telefono {  get; set; }

    }
}
