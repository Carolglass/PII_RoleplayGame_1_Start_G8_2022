using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Items
{
    internal class Escudo
    {
        private string nombre;
        private int valorDefensa;
        private static List<int> charactersId = new List<int>();
        public String Nombre { get; private set; }
        public int ValorDefensa { get; private set; }

        public Escudo(string nombre, int valorAtaque)
        {
            this.Nombre = nombre;
            this.ValorDefensa = valorDefensa;
        }
        public static void CharactersId(int identificador)
        {
            charactersId.Add(identificador);
        }
    }
}
