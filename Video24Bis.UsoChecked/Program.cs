using System;


namespace UsoDoWhile
{
    class Program
    {
        //static void Main(string[] args) // el programa no se desborda, sinó que genera una respuesta erronea, esto permite continuar con el programa
        //{
        //    int numero = int.MaxValue;

        //    int resultado = numero + 1;

        //    Console.WriteLine(resultado);
        //}

        static void Main(string[] args) 
        {
            checked // esto hace que no pase por alto el programa y por lo tanto caiga el programa
            {

                int numero = int.MaxValue;

                int resultado = numero + 1;

                Console.WriteLine(resultado);
            }
        }
    }
}

/// en "Propiedades" ir a "compilacion" - "avanzadas" - "Comprobar el desbordamiento y subdesbordamiento aritmetico""
/// esto hace que el IDE haga el checked sin necesidad de ponerlo, y que el programa tire la excepción