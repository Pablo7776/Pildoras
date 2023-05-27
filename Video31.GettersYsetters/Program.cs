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

            coche3.setExtras(true, "cuero");
            Console.WriteLine(coche3.getExtras());
        }
    }


    //*******************************************************************
    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;

            tapiceria = "tela";
        }

        public Coche(double largoCoche, double anchoCoche) // esto es una sobrecarga
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;

        }
    }

    partial class Coche { 
        public String getInfoCoche()
        {
            return "Información del coche:/n " + "Ruedas:" + ruedas + "LArgo: " + largo + " " + ancho;
        }

        public void setExtras(bool paramClimatizador, String paramTapiceria)
        {
            climatizador = paramClimatizador;
            tapiceria = paramTapiceria;
        }

        //public void setExtras(bool climatizador, String tapiceria)
        //{
        //    climatizador = climatizador;
        //    tapiceria = tapiceria;
        //}
        //ESTO GENERA AMBIGUEDAD!!!

        //public void setExtras(bool climatizador, String tapiceria)
        //{
        //    this.climatizador = climatizador;
        //    this.tapiceria = tapiceria;
        //}
        // SE SOLUCIONA USANDO EL "THIS", DIFERENCIANDO A UN CAMPO DE CLASE DE UN PARAMETRO
        // THIS.CLIMATIZADOR HACE REFERENCIA A LA VARIABLE DE CLASE

        public String getExtras()
        {
            return "Extras del coche: " + "Tapiceria " + tapiceria + "Climatizador " + climatizador;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }
}
