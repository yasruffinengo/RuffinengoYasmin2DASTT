using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Movimiento
    {
        public int MovimientoId { get; set; }

        public DateTime Fecha {  get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public TipoMovimiento Tipo {  get; set; }   
        public enum TipoMovimiento
        {
            //Creditos (ingresos)
            Pago,
            Abono,
            //Debitos (egresos)
            Cargo,
            Compra,
            Consumo
        }

        //asocio a cuenta corrinte
        public CuentaCorriente CuentaCorriente { get; set; }
        public int CuentaCorrienteId { get; set; }
    }
}
