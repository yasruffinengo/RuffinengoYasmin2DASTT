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
        public SubtipoMovimiento Subtipo { get; set; }
        public enum TipoMovimiento
        {
            Debito,
            Credito
        }

        public enum SubtipoMovimiento
        {
            //Creditos (ingresos)
            Pago,
            Abono,
            //Debitos (egresos)
            Cargo,
            Compra,
            Consumo
        }


        //asocio (fk) cuenta corrinte
        public CuentaCorriente CuentaCorriente { get; set; }
        public int CuentaCorrienteId { get; set; }
    }
}
