using System;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            AlbumFotos n = new AlbumFotos();

            Console.WriteLine($"Mostrando paginas de la clase Album: {n.getNumeroPaginas()}");

            AlbumFotos pepe = new AlbumFotos(8);

            Console.WriteLine($"Asignando valor 8 en constructor especifico:  {pepe.getNumeroPaginas()}");

            SuperAlbumFotos super = new SuperAlbumFotos();

            Console.WriteLine($"Mostrando con constructor de SuperAlbum : {super.getNumeroPaginas()}");

            AlbumTest alt = new AlbumTest();

            Console.WriteLine($"Mostrando constructor defecto de AlbumTest {alt.numPaginas_}");

            AlbumTest l = new AlbumTest(80);

            Console.WriteLine($"Mostrando constructor especifico de AlbumTest {l.numPaginas_}");

            AlbumTest t = new AlbumTest();

            Console.WriteLine($"Usando el metodo new de album test: {t.getNumeroPaginas()}");
        }
        class AlbumFotos
        {
            private int numPaginas { get; set; }

            public int numPaginas_ { get; set; }
            public AlbumFotos()
            {
                numPaginas = 16;
                
            }
            //Sobrecarga de constructor
            public AlbumFotos(int h)
            {
                numPaginas = h;
            }
            //Metodo getter para acceder a la propiedad privada
            public int  getNumeroPaginas()
            {
                return numPaginas;
            }
        }
        class SuperAlbumFotos : AlbumFotos
        {
            //ctor especifico
            public SuperAlbumFotos()
            {
                numPaginas_ = 64;
            }
        }
        class AlbumTest : AlbumFotos
        {
            //ctor especifico
            public AlbumTest(int a)
            {
                numPaginas_ = a;
            }
            //ctor setea 24
            public AlbumTest()
            {
                numPaginas_ = 24;
            }

            //Metodo mostrar valor  numero paginas
            new public int getNumeroPaginas()
            {
                return numPaginas_;
            }
            
        }
    }
}
