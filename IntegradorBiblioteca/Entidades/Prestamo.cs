using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        private int prestamoId;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private Libro libro;
        private int libroId;
        private Socio socio;
        private int socioId;

        public int PrestamoId { get { return prestamoId; } set { prestamoId = value; } }
        public DateTime FechaPrestamo { get { return fechaPrestamo; } set { fechaPrestamo = value; } }  
        public DateTime FechaDevolucion { get { return fechaDevolucion; } set { fechaDevolucion = value; } }
        public Libro Libro { get { return libro; } set {    libro = value; } }  
        public int LibroId { get {return libroId; } set {libroId = value; } }
        public Socio Socio { get { return socio; } set {    socio = value; } }  
        public int SocioId { get {  return socioId; } set { socioId = value; } }    
    }
}
