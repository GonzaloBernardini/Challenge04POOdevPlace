using System;
using System.Collections.Generic;
using System.Text;
using static Ejercicio02.Program;

namespace Ejercicio02
{
    class Cuenta : Persona
    {
        private Persona Titular { get; set; }

        public decimal Cantidad_;
        private decimal? Cantidad { 
            get 
            {
                return Cantidad_;
            } set
            {
                if (value > 0)
                {
                    Cantidad_ = Convert.ToDecimal(value);
                }
                else
                {
                    Console.WriteLine("Primero debe ingresar dinero");
                }

            } }



        public Cuenta()
        {

        }
        public void MostrarDatosCuenta()
        {
            if (Cantidad_ < 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"El titular de la cuenta es:{Titular}\nEl dinero actual en su cuenta es de : {Cantidad_}");
            }
            Console.WriteLine($"El titular de la cuenta es:{Titular}\nEl dinero actual en su cuenta es de : {Cantidad_}");

        }
        public decimal IngresarDinero(decimal a)
        {
            if (a < 0)
            {
                Console.WriteLine("No puede ingresar cantidades negativas");
            }
              
            Cantidad_ = a;
            return Cantidad_;
        }

        public decimal RetirarDinero(decimal b)
        {
           
            if (b < 0)
            {
                Console.WriteLine("El valor debe ser mayor a 0");
            }
            decimal dineroFinal = Cantidad_ - b;
            return Cantidad_ - dineroFinal;
        }
    }
}
