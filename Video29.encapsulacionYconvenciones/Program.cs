using System;
using System.Security.Claims;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.cambiaValorEuro(-1.45);

            Console.WriteLine(obj.convierte(50));



        }
    }
    /// <summary>
    /// Esta clase es para hacer un circulo.
    /// </summary>
    class Circulo
    {
        private const double pi = 3.1416; // propiedad de la clase circulo. Campo de clase
        //la constante es privada con y sin el private 
        public double CalculArea(int radio) // método de clase. qué pueden hacer los objetos de tipo círculo?
        {
            return pi * radio * radio;
        }
    }


    class ConversorEuroDolar
    {
        private double euro = 1.253;
        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void cambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;

            else
                euro = nuevoValor;
        }
    }
}