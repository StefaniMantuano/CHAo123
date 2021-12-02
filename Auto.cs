using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Auto : Vehiculo
    {
        //Caracteristicas

       public string Tipo { get; set; }
        public double PrecioVehiculo { get; set; }

        public double ValordePago;

        public override void CalculoCobrar()
        {
            if(Tipo.Equals("Sedan"))
            {
                ValordePago = PrecioVehiculo; 
            }
            else
            {
                ValordePago = PrecioVehiculo - (PrecioVehiculo * 0.1);
            }

            Console.WriteLine("Tipo de auto: (0); Total a pagar: $(1)", Tipo, ValordePago);
        }
    }
}