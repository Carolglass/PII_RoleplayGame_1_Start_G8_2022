using System;
using System.Threading;
using Library;

namespace PII_RoleplayGame_1_Start_G8_2022
{
    class Program
    {
        static int sleepTime = 1600;
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------------------LOS COMBATIENTES SE PRESENTAN A LA ARENA--------------------\n");
            Thread.Sleep(sleepTime);

            Mago Tony = new Mago(0, "Tony", 100, 10);
            Console.WriteLine("El Mago " + Tony.Nombre + " se presenta para luchar en la arena.");
            Thread.Sleep(sleepTime);


            Elfo Ernesto = new Elfo(1, "Ernesto", 150, 12);
            Console.WriteLine("El Elfo " + Ernesto.Nombre + " se presenta para luchar en la arena.\n");
            Thread.Sleep(sleepTime);

            Console.WriteLine("--------------------------HERRERIA--------------------------\n");
            Thread.Sleep(sleepTime);
            Console.WriteLine("---------------------PRIMER OBJETO--------------------------");
            Console.WriteLine("Forjando hacha...");
            Thread.Sleep(sleepTime);
            Hacha hacha = new Hacha("Hacha", 5);
            Console.WriteLine("Hacha fue Forjada con exito.\n");
            Thread.Sleep(sleepTime);

            Console.WriteLine("---------------------SEGUNDO OBJETO--------------------------");
            Thread.Sleep(sleepTime);
            Console.WriteLine("Forjando pico...");
            Thread.Sleep(sleepTime);
            Pico pico = new Pico("Pico", 3);
            Console.WriteLine("Pico forjado con exito.\n");
            Thread.Sleep(sleepTime);

            Console.WriteLine("--------------------------TEXTOS ANTIGUOS--------------------------\n");
            Thread.Sleep(sleepTime);
            Console.WriteLine("---------------------Hechizo 1--------------------------");
            Console.WriteLine("Mezclando ingredientes... y lagrimas de universitarios frustrados");
            Thread.Sleep(sleepTime);
            ParcialitusSorpresivus Hechizo1 = new ParcialitusSorpresivus(3, "ParcialitusSorpresivus", 20);
            Console.WriteLine("El hechizo " + Hechizo1.Nombre + " creado correctamente.\n");
            Thread.Sleep(sleepTime);

            Console.WriteLine("--------------------------Creacion libro--------------------------\n");
            Thread.Sleep(sleepTime);
            Console.WriteLine("---------------------APRENDIENDO HECHIZO--------------------------");
            Console.WriteLine("Realizando conjuros...boooooom!!!");
            Thread.Sleep(sleepTime);
            LibroHechizos book = new LibroHechizos("Bitacora");
            Console.WriteLine("Hechizo_aprendido\n");
            Thread.Sleep(sleepTime);


            //---------------------------------------------------------
            book.AñadirHechizosDaño(Hechizo1.Danio);

            Console.WriteLine("------------------CORRAN A BUSCAR ARMAS!!!------------------\n");
            Thread.Sleep(sleepTime);
            Console.WriteLine("El mago  " + Tony.Nombre + " corre con todas sus fuerzas y logra agarra un hacha para defenderse del elfo.");
            Hacha.CharactersId(0);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Tony.Danio = Tony.Danio + hacha.ValorAtaque; //El Mago Toni carga su Hacha para el ataque
            Console.WriteLine("El daño de " + Tony.Nombre + " ha aumentado a la asombrosa cifra de " + Tony.Danio + "!");
            Console.WriteLine("Pero...sera suficiente para acabar con el Elfo todo poderoso " + Ernesto.Nombre + " ? \n");
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);

            Ernesto.Danio = Ernesto.Danio + pico.ValorAtaque; //El Elfo Ernesto carga su pico para el ataque
            Pico.CharactersId(1);
            Console.WriteLine("El elfo " + Ernesto.Nombre + " se deliza por abajo de Tony y milagrosamente consigue un pico para defenderse.");
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Console.WriteLine("El daño de el Elfo " + Ernesto.Nombre + " ha aumentado a " + Ernesto.Danio);
            Console.WriteLine("Ahora " + Ernesto.Nombre + " tiene la posibilidad de vencer a " + Tony.Nombre + "\n");
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Console.WriteLine("------------------INICIO BATALLA DE LA ARENA------------------");
            Thread.Sleep(sleepTime);
            Console.WriteLine("Ambos luchadores estan preparados para  pelear y demostrar su valia corren para verse de frente" );
            Thread.Sleep(sleepTime);
            Console.WriteLine("y ohhh no! El Elfo " + Ernesto.Nombre + " realiza el primer ataque pero falla.");
            Thread.Sleep(sleepTime);
            Console.WriteLine("La contra ofensiva del mago " + Tony.Nombre + " comienza");
            Ernesto.RecibirDanio(Tony.Danio);
            Thread.Sleep(sleepTime);
            Console.WriteLine("La vida de " + Ernesto.Nombre + " se redujo a " + Ernesto.Vida + "!");
            Console.WriteLine("El Mago " + Tony.Nombre + " logró darle un golpe certero!");
            Thread.Sleep(sleepTime);
            Console.WriteLine("Los espectadores se sienten conmovidos por " + Ernesto.Nombre);
            Console.WriteLine("y le regalan una botella de curación!");
            Ernesto.Curar();
            Console.WriteLine(Ernesto.Nombre + " se curó al " + Ernesto.Vida + "!");
            Console.WriteLine(Tony.Nombre + " Al ver que el publico se apiada de " + Ernesto.Nombre + " Tiene que usar su poderoso libro de Hechizos de la Universidad de magias");
            Thread.Sleep(sleepTime);
            Console.WriteLine(Tony.Nombre + " usa el poderoso hechizo de " + Hechizo1.Nombre + " acierta justo en el blanco");
            Thread.Sleep(sleepTime);
            Tony.Danio = Tony.Danio + book.Daños[0];
            Ernesto.RecibirDanio(Tony.Danio);
            Console.WriteLine("La vida de " + Ernesto.Nombre + " se redujo a " + Ernesto.Vida + "!");
            Thread.Sleep(sleepTime);
            Console.WriteLine("En medio de la batalla cuando " + Ernesto.Nombre + " esta por caer a manos de " + Tony.Danio);
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);
            Console.WriteLine("suena la campana que significaba la hora limite para la batalla");
            Thread.Sleep(sleepTime);
            Console.WriteLine("exactamente a las 23:59 era el sonido de la campana webasignatura");
            Thread.Sleep(sleepTime);
            Console.WriteLine("Los dos combatientes juraron juntarse nuevamente y terminar la batalla en la arena de PII_RoleplayGame_2");
            Thread.Sleep(sleepTime);
            Console.WriteLine("███████╗██╗███╗░░██╗░█████╗░██╗░░░░░  ███████╗██████╗░██╗░█████╗░░█████╗░  ░█████╗░░█████╗░███╗░░██╗");
            Console.WriteLine("██╔════╝██║████╗░██║██╔══██╗██║░░░░░  ██╔════╝██╔══██╗██║██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗████╗░██║    ");
            Console.WriteLine("█████╗░░██║██╔██╗██║███████║██║░░░░░  █████╗░░██████╔╝██║██║░░╚═╝██║░░██║  ██║░░╚═╝██║░░██║██╔██╗██║");
            Console.WriteLine("██╔══╝░░██║██║╚████║██╔══██║██║░░░░░  ██╔══╝░░██╔═══╝░██║██║░░██╗██║░░██║  ██║░░██╗██║░░██║██║╚████║");
            Console.WriteLine("██║░░░░░██║██║░╚███║██║░░██║███████╗  ███████╗██║░░░░░██║╚█████╔╝╚█████╔╝  ╚█████╔╝╚█████╔╝██║░╚███║");
            Console.WriteLine("╚═╝░░░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝  ╚══════╝╚═╝░░░░░╚═╝░╚════╝░░╚════╝░  ░╚════╝░░╚════╝░╚═╝░░╚══╝");

            Console.WriteLine("███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░█████╗░  ██████╗░███████╗  ███████╗░█████╗░███╗░░██╗██████╗░░█████╗░");
            Console.WriteLine("████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗  ██╔══██╗██╔════╝  ██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗");
            Console.WriteLine("██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝███████║  ██║░░██║█████╗░░  █████╗░░██║░░██║██╔██╗██║██║░░██║██║░░██║");
            Console.WriteLine("██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██╔══██║  ██║░░██║██╔══╝░░  ██╔══╝░░██║░░██║██║╚████║██║░░██║██║░░██║");
            Console.WriteLine("██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██║░░██║  ██████╔╝███████╗  ██║░░░░░╚█████╔╝██║░╚███║██████╔╝╚█████╔╝");
            Console.WriteLine("╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝  ╚═╝░░░░░░╚════╝░╚═╝░░╚══╝╚═════╝░░╚════╝░");
        }
    }
}
