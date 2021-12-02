using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Furgoneta:Vehiculo 
    {
        //Caracteristicas

        public int NumeroAsientos { get; set; }
        public double Preciobase{ get; set; }
        public double PrecioporAsiento;

        public double PrecioTotal;

        public override void CalculoCobrar()
        {
            PrecioTotal = Preciobase + (NumeroAsientos + PrecioporAsiento);
            Console.WriteLine("Precio total Furgoneta: $(0)", PrecioTotal);
        }
     
    }

}