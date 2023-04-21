using System;


///try.. intenta
///catch...captura
///
namespace UsoDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int minumero;
            int intentos = 0;
            Console.WriteLine("Introduce un número entre 0 y 100");

            do
            {
                intentos++;
                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }
                catch (Exception e)// en c# se puede no poner nada como parametro, pero no es una practica recomendada 
                {
                    Console.WriteLine("No has introducido un valor numerico válido. Se toma comu número introducido el cero");
                    Console.WriteLine(e.Message);

                    minumero = 0;
                }
                
                if (minumero > aleatorio) Console.WriteLine("El número es más bajo");
                if (minumero < aleatorio) Console.WriteLine("el número es más alto");
            } while (aleatorio != minumero);
            Console.WriteLine($"correcto! Has necesitado {intentos} intentos");
            Console.WriteLine("continuará...");
        }
    }
}