using System;

namespace EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;
            try
            {
                string line;
                int contador = 0;
                string path = @"C:\Users\Pablo\source\repos\Pildoras.Video23.Excepciones2\Video26.ExcepcionesV.Bloque finally\hola.txt";
                archivo = new System.IO.StreamReader(path);

                while((line = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    contador++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
            finally
            {
                if( archivo != null) archivo.Close();

                Console.WriteLine("Conexión con el fichero cerrada 2");
            }
        }
    }
}
//hola
//hola2