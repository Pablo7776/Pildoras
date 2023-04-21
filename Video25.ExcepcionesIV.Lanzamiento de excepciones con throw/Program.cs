using System;


namespace UsoDoWhile
{
    class Program
    {

        static void Main(string[] args)
        {
            
            {

                int numero = int.MaxValue;

                int resultado = checked ( numero + 1); // otra manera de poner el checket

                Console.WriteLine(resultado);


                //int numero = int.MaxValue;

                //int resultado = unchecked(numero + 1); // quita el checket automatico (si es que está configurado en VS )

                //Console.WriteLine(resultado);
            }
        }
    }
}

