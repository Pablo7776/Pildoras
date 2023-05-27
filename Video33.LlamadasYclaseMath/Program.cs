using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video33.LlamadasYclaseMath;
//hola

namespace Video33.LlamadasYclaseMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(152, 80);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los dos puntos es de: {distancia} ");
        }
    }
}