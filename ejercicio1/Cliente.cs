using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Cliente
    {
        private string dni;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private DateTime fechaNacimiento;
        private int edad;

        public string Dni { get { return dni; } set { dni = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Email { get { return email; } set { email = value; } }    
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public int Edad { get { return edad; } set { edad = value; } }


    }
}
