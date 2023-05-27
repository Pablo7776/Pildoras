 using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // creación de objeto de tipo círculo. VAriable/objeto de tipo círculo

            miCirculo = new Circulo(); // Iniciación de variable/objeto de tipo Circulo. Instanciar una clase. Instanciación. Ejemplarización. Creación de ejemplar de clase

            Console.WriteLine(miCirculo.calculArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.calculArea(9));



        }
    }
    /// <summary>
    /// Esta clase es para hacer un circulo.
    /// </summary>
    class Circulo
    {
        const double pi = 3.1416; // propiedad de la clase circulo. Campo de clase

        public double calculArea(int radio) // método de clase. qué pueden hacer los objetos de tipo círculo?
        {
            return pi * radio * radio;
        }
    }
}