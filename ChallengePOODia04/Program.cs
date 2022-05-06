using System;

namespace ChallengePOODia04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1 -  Crea un programa en C# que solicite tres nombres de personas al usuario y los almacene
             * en un array de objetos de tipo Persona. Para ello primero crea una clase Persona que tenga
             * una propiedad Nombre de tipo string y sobrescriba el método ToString().
               Finalice el programa leyendo las personas y ejecutando en pantalla el método ToString().
             */

            int cantidad = 3;
            Persona[] personas = new Persona[cantidad];
            for (int i = 0; i < personas.Length; i++)
            {
                personas[i] = new Persona() { nombre = Console.ReadLine() };
            }
            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine(personas[i].ToString());
            }
        }
        class Persona
        {
            public string nombre { get; set; }
            public override string ToString()
            {
                return "Hola mi nombre es "+ nombre;
            }
        }
    }
}
