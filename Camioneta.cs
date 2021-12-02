using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Camioneta : Vehiculo
    {
        //Caracteristicas

        public string TipoCabina { get; set; }

        public double MontoPago;

        public override void CalculoCobrar()
        {
            if (TipoCabina.Equals("Cabina-doble"))
            {
                MontoPago = 20000;
            }
            else
            {
                MontoPago = 15000;
            }

            Console.WriteLine("Tipo de cabina: (0); Total a pagar: $(1)", TipoCabina, MontoPago);
        }
    }
}