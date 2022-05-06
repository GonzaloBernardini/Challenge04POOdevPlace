using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre, luego edad y por ultimo DNI");
            string nombr = Console.ReadLine();
            int ed = Convert.ToInt32(Console.ReadLine());
            string dniPer = Console.ReadLine();
            Persona nuevaPer = new Persona();
            nuevaPer.nombre = nombr;
            nuevaPer.edad = ed;
            nuevaPer.DNI = dniPer;
            nuevaPer.getDatos();
            nuevaPer.esMayorEdad();
        }
        class Persona
        {
            public string nombre { get; set; }

            public int edad { get; set; }

            private string dni;
            public string DNI
            {
                get { return dni; } set
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
