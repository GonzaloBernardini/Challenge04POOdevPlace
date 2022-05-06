using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre, luego apellido y por ultimo DNI");
            string nombr = Console.ReadLine();
            int ed = Convert.ToInt32(Console.ReadLine());
            string dniPer = Console.ReadLine();
            Persona nuevaPer = new Persona();
            nuevaPer.nombre = nombr;
            nuevaPer.edad = ed;
            nuevaPer.DNI = dniPer;
            nuevaPer.getDatos();

        }
        class Persona
        {
            public string nombre { get; set; }

            public int edad { get; set; }

            public string DNI
            {
                //valido la entrada de datos en el set
                set
                {
                    int maxLenght = 8;
                    if (value.Length != maxLenght)
                    {
                        Console.WriteLine("El dni tiene que tener 8 digitos");

                    }
                    else
                    {
                        DNI = value;
                    }
                }
                get { return DNI; }
            }
                

            //ctor por defecto
            public Persona()
            {

            }
            public void getDatos()
            {
                Console.WriteLine($"Mi nombre es: {nombre} \n Mi edad es: {edad} \n Mi DNI es : {DNI} ");
            }


        }
    }
}
