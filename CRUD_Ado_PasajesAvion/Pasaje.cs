﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Ado_PasajesAvion
{
    public class Pasaje
    {
        public int IdPasaje {  get; set; }
        public string NumeroAsiento { get; set; }
        public DateTime FechaVuelo { get; set; }
        public Avion Avion { get; set; }
        public Pasajero Pasajero { get; set; }
    }
}
