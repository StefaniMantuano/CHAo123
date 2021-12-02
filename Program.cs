using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto
            Auto Hyundai = new Auto();
            Hyundai.setMarca("Hyundai");
            Hyundai.setModelo("Elantra");
            Hyundai.setAñoCreacion(2019);
            Hyundai.Tipo = "Sedan";
            Hyundai.PrecioVehiculo = 12000;


            //Camioneta
            Camioneta Nissan = new Camioneta();
            Nissan.setMarca("Nissan");
            Nissan.setModelo("09");
            Nissan.setAñoCreacion(2007);
            Nissan.TipoCabina = "Cabina simple";


            //Furgoneta
            Furgoneta Chery = new Furgoneta();
            Chery.setMarca("Chevy");
            Chery.setModelo("t8");
            Chery.setAñoCreacion(2020);
            Chery.NumeroAsientos = 8;
            Chery.Preciobase = 15000;
            Chery.PrecioporAsiento = 400;

            
        }
    }
}
