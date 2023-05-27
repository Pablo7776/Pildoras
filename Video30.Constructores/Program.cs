using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video30.Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); // crear objeto/instancia de tipo Coche. Dar un estado inicial a nuestro coche

            Coche coche2 = new Coche();

            Console.WriteLine(coche2.getInfoCoche());
            Console.WriteLine(coche1.getInfoCoche());

            Coche coche3 = new Coche(450.25, 1200.35);

            Console.WriteLine(coche3.getInfoCoche());
        }
    }
    class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }

        public Coche(double largoCoche, double anchoCoche) // esto es una sobrecarga
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;

        }

        public String getInfoCoche()
            {
            return "Información del coche:/n " + "Ruedas:" + ruedas + "LArgo: " + largo + " " + ancho;
            }
            
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }
}
