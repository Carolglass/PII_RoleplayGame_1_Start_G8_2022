using System;
using System.Threading;
using Library;
using Library.Items;

namespace Program
{
    class Program
    {
        static int sleepTime = 1000;
        static void Main(string[] args)
        {
            Console.WriteLine("------------------INICIO DE LA BATTALLA------------------");
            Thread.Sleep(sleepTime);

            Mago Tony = new Mago(0, "Tony", 100, 10);
            Console.WriteLine("El mago " + Tony.Nombre + "  entra al juego.");
            Thread.Sleep(sleepTime);


            Elfo Ernesto = new Elfo(1, "Ernesto", 100, 12);
            Console.WriteLine("El Elfo " + Ernesto.Nombre + "  entra al juego.");
            Thread.Sleep(sleepTime);

            Console.WriteLine("------------------HERRERIA------------------");
            Console.WriteLine("Forjando hacha...");
            Thread.Sleep(sleepTime);
            Hacha hacha = new Hacha("Hacha" , 5);
            Console.WriteLine("Hacha forjado.");
            Thread.Sleep(sleepTime);

            Console.WriteLine("Forjando pico...");
            Thread.Sleep(sleepTime);
            Pico pico = new Pico("Pico", 3);
            Console.WriteLine("Pico forjado.");
            Thread.Sleep(sleepTime);

            Console.WriteLine("------------------CORRAN A BUSCAR ARMAS!!!------------------");
            Console.WriteLine("El mago " + Tony.Nombre + " agarra el hacha.");
            Hacha.CharactersId(0);
            Thread.Sleep(sleepTime);
            Tony.Danio = Tony.Danio + hacha.ValorAtaque; //El Mago Toni carga su Hacha para el ataque
            Console.WriteLine("El daño de el Mago ha aumentado a " + Tony.Danio);
            Thread.Sleep(sleepTime);

            Ernesto.Danio = Ernesto.Danio + pico.ValorAtaque; //El Elfo Ernesto carga su pico para el ataque
            Pico.CharactersId(1);
            Console.WriteLine("El elfo " + Ernesto.Nombre + " agarra el pico.");
            Thread.Sleep(sleepTime);

            Console.WriteLine("El daño de el Elfo ha aumentado a " + Ernesto.Danio);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Inicio de la promera batalla");
            Thread.Sleep(sleepTime);
            
            Ernesto.RecibirDanio(Tony.Danio); //Ernesto es atacado por el mago tony
            Console.WriteLine("La vida de " + Tony.Nombre + " se redujo a " + Tony.Vida);
            Thread.Sleep(sleepTime);



        }
    }
}
