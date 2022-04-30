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
        private int valorAtaque;
        private static List<int> charactersId = new List<int>();
        public String Nombre { get; private set; }
        public int ValorDefensa { get; private set; }
        public Escudo(string nombre, int valorAtaque)
        {
            Nombre = this.nombre;
            ValorDefensa = this.ValorDefensa;
        }
        public static void CharactersId(int identificador)
        {
            charactersId.Add(identificador);
        }
    }
}
