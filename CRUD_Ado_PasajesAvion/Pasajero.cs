﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Ado_PasajesAvion
{
    public class Pasajero
    {
        public int IdPasajero { get; set; }
        public string Pasaporte { get; set; }
        public string NombreApellido { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
