using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class CajaAhorro : Cuenta
    {
        private float maximoExtraccion;
        
        public float MaximoExtraccion { get { return maximoExtraccion; } set { maximoExtraccion = value; } }

        public override void retirarDinero(float monto)
        {
            //aca me quede, faltan las validaciones para aceptar la extraccion 
            throw new NotImplementedException();
        }
    }
}
