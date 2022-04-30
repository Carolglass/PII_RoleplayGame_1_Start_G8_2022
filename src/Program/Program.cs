using System;
using Library;
using Library.Items;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago Tony = new Mago(0,"Tony", 100, 10);
            Hacha hacha = new Hacha("Hacha" , 5);
            Hacha.CharactersId(0);

            Elfo Ernesto = new Elfo(1, "Tony", 100, 10);
            Pico pico = new Pico("Pico", 3);
            Hacha.CharactersId(0);
            Pico.CharactersId(1);

            Tony.Danio = Tony.Danio + hacha.ValorAtaque; //El Mago toni carga su Hacha para attac


        }
    }
}
