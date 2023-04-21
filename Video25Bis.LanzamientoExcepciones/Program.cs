using System;
namespace LanzamientoExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intuduce numero de mes");

            int NumeroMes = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(NombreDelMes(NumeroMes));
            }
            catch(Exception e)
            {
                Console.WriteLine("Mensaje de la exepción: " + e.Message );
            }
            Console.WriteLine("Aquí continuaría el programa");
        }

        public static string NombreDelMes (int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "mayo";
                default:
                    // return "Mes Erróneo";
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}