using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Vehiculo
    {
        //Propiedades Caracteristicas
        private string Marca;
        private string Modelo;
        private int AñoCreacion; 


        //Definir un metodo que permita mostar por pantalla todos los datos de las propiedades de identidad
        public void Mostrar()
        {
            Console.WriteLine("Marca: (0); Modelo: (1); Año de creacion: (2)", Marca, Modelo, AñoCreacion);
        }

        public string getMarca()
        {
            return Marca;
        }
        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }


        public string getModelo()
        {
            return Modelo;
        }
        public void setModelo (string Modelo)
        {
            this.Modelo = Modelo;
        }


        public int getAñoCreacion()
        {
            return AñoCreacion;
        }
        public void setAñoCreacion(int AñoCreacion)
        {
            this.AñoCreacion = AñoCreacion;
        }


        public abstract void CalculoCobrar();

    }
}