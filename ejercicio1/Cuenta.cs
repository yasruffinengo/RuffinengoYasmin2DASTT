using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public abstract class Cuenta
    {
        private Cliente titular;
        private int codigo;
        private float saldo;

        public Cliente Titular { get { return titular; } set { titular = value; } } 
        public int Codigo { get { return codigo; } set { codigo = value; } }    
        public float Saldo { get { return saldo; } set { saldo = value; } }

        //metodo depositar, lo declaro e implemento aca,ya que es para ambos tipos de cuentas lo mismo  ? 
        public void depositarDinero(float monto)
        {
            if (monto <= 0)
                throw new Exception("El monto a depositar debe ser mayor a cero.");

            saldo += monto;
        }
        public abstract void retirarDinero(float monto);


    }
}
