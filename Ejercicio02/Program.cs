using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre");
            string nombr = Console.ReadLine();
            Console.WriteLine("Ingrese edad");
            int ed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su DNI sin puntos.");
            string dniPer = Console.ReadLine();
            Persona nuevaPer = new Persona();
            nuevaPer.nombre = nombr;
            nuevaPer.edad = ed;
            nuevaPer.DNI = dniPer;
            nuevaPer.getDatos();
            nuevaPer.esMayorEdad();
            Console.WriteLine("Desea crearse una cuenta? Ingrese 1 para crear : Ingrese 2 para salir");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            if (valor1 == 1)
            {
                Cuenta n = new Cuenta();
                Console.WriteLine("Ha creado su cuenta\nIngrese 1 para depositar dinero o 2 para retirar dinero");
                int valor2 = Convert.ToInt32(Console.ReadLine());
                if (valor2 ==1)
                {
                    Console.WriteLine("Ingrese el valor a depositar");
                    decimal valorIngresado = Convert.ToDecimal(Console.ReadLine());
                    n.IngresarDinero(valorIngresado);
                    n.MostrarDatosCuenta();
                }
                else if(valor2 == 2)
                {
                    decimal valorRetiro = Convert.ToDecimal(Console.ReadLine());
                    n.RetirarDinero(valorRetiro);
                }
            }
            else
            {
                Console.WriteLine("Gracias por utilizar nuestros servicios");
            }
            Console.ReadKey();
        }
        public class Persona
        {
            public string nombre { get; set; }

            public int edad { get; set; }

            private string dni;
            public string DNI
            {
                
                get { return dni; }
                //Metodo setter
                set
                {
                    if (value.Length < 8)
                    {
                        Console.WriteLine("debe ser mayor a 8 digitos");
                    }
                    else
                    {
                        dni = value;
                    } } }
             

            //ctor por defecto
            public Persona()
            {
                
            }
            public void getDatos()
            {
                Console.WriteLine($"Mi nombre es: {nombre} \n Mi edad es: {edad} \n Mi DNI es : {DNI} ");
            }

            public bool esMayorEdad()
            {
                
                if (edad>18)
                {
                    Console.WriteLine("Soy mayor de edad");
                    return true;
                }
                else
                {
                    Console.WriteLine("No soy mayor de edad :c");
                    return false;
                }
                
            }

        }
    }
}
