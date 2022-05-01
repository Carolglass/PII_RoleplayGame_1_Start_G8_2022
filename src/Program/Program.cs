using System;
using System.Threading;
using Library;

namespace PII_RoleplayGame_1_Start_G8_2022
{
    class Program
    {
        static int sleepTime = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------------------LAS CRIATURAS SE PRESENTAN A LA ARENA--------------------\n");
            Thread.Sleep(sleepTime);

            Mago Tony = new Mago(0, "Tony", 100, 10);
            Console.WriteLine("El Mago " + Tony.Nombre + " se presenta para luchar en la arena.");
            Thread.Sleep(sleepTime);


            Elfo Ernesto = new Elfo(1, "Ernesto", 150, 12);
            Console.WriteLine("El Elfo " + Ernesto.Nombre + " se presenta para luchar en la arena.\n");
            Thread.Sleep(sleepTime);

            Console.WriteLine("--------------------------HERRERIA--------------------------\n");
            Thread.Sleep(sleepTime);
            Console.WriteLine("---------------------Herramienta 1--------------------------");
            Console.WriteLine("Forjando hacha...");
            Thread.Sleep(sleepTime);
            Hacha hacha = new Hacha("Hacha" , 5);
            Console.WriteLine("Hacha forjado.\n");
            Thread.Sleep(sleepTime);

            Console.WriteLine("---------------------Herramienta 2--------------------------");
            Thread.Sleep(sleepTime);
            Console.WriteLine("Forjando pico...");
            Thread.Sleep(sleepTime);
            Pico pico = new Pico("Pico", 3);
            Console.WriteLine("Pico forjado.\n");
            Thread.Sleep(sleepTime);

            Console.WriteLine("--------------------------CALIZ--------------------------\n");
            Thread.Sleep(sleepTime);
            Console.WriteLine("---------------------Hechizo 1--------------------------");
            Console.WriteLine("Mezclando ingredientes...");
            Thread.Sleep(sleepTime);
            ParcialitusSorpresivus Hechizo1 = new ParcialitusSorpresivus(3,"Hechizo1",20);
            Console.WriteLine("hehcizo realizado\n");
            Thread.Sleep(sleepTime);

            Console.WriteLine("--------------------------Creacion libro--------------------------\n");
            Thread.Sleep(sleepTime);
            Console.WriteLine("---------------------Hechizo 1--------------------------");
            Console.WriteLine("Realizando conjuros...boooooom!!!");
            Thread.Sleep(sleepTime);
            LibroHechizos book = new LibroHechizos("Spartacus");
            Console.WriteLine("hehcizo realizado\n");
            Thread.Sleep(sleepTime);


            //---------------------------------------------------------
            book.AñadirHechizosDaño(Hechizo1.Danio);

            Console.WriteLine("------------------CORRAN A BUSCAR ARMAS!!!------------------\n");
            Thread.Sleep(sleepTime);
            Console.WriteLine("El mago  " + Tony.Nombre + " corre con todas sus fuerzas y logra agarra un hacha para defenderse de la otras criaturas.");
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
            Console.WriteLine("El elfo " + Ernesto.Nombre + " se deliza por abajo de Tony y mialgrosamente consigue un pico para defenderse.");
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);

            Console.WriteLine("El daño de el Elfo " + Ernesto.Nombre + " ha aumentado a " + Ernesto.Danio);
            Console.WriteLine("Ahora " + Ernesto.Nombre + " tiene la posibilidad de vencer a " + Tony.Nombre + "\n" );
            Thread.Sleep(sleepTime);
            Thread.Sleep(sleepTime);

            Console.WriteLine("------------------INICIO PRIEMRA BATALLA DE LA ARENA------------------");
            Thread.Sleep(sleepTime);
            Console.WriteLine("Ambas criaturas corren para verse de frende y ohhh no! El Elfo " + Ernesto.Nombre + " realiza el primer ataque pero falla.");
            Console.WriteLine("La contraofensiva comienza");
            Ernesto.RecibirDanio(Tony.Danio);
            Thread.Sleep(sleepTime);
            Console.WriteLine("La vida de " + Ernesto.Nombre + " se redujo a " + Ernesto.Vida + "!");
            Console.WriteLine("El Mago " + Tony.Nombre + " logró darle un golpe certero!");
            Thread.Sleep(sleepTime);

            Console.WriteLine("Los espectadores se sienten conmovidos por Esrnesto");
            Console.WriteLine("y le regalan una botella de curación!");
            Ernesto.Curar();
            Console.WriteLine("Ernesto se curó al " + Ernesto.Vida + "! ");


            //Prepara ataque
            Tony.Danio = Tony.Danio + book.Daños[0];
            Ernesto.RecibirDanio(Tony.Danio);
            Thread.Sleep(sleepTime);


            Console.WriteLine("La vida de " + Ernesto.Nombre + " se redujo a " + Ernesto.Vida + "!");
        }
    }
}
