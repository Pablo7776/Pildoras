using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video32.ModularizaciónYextras
{
    class Punto
    {
        public Punto(int x, int y) 
        {
            Console.WriteLine($"Cordenada x: {x}, Coordenada y: {y}");
        }
        public Punto()
        {
            Console.WriteLine("Este es el constructor por defecto");
        }
    }
}
