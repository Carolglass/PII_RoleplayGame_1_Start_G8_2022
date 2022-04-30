using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Items
{
    internal class Piedra
    {
        private string nombre;
        private int valorAtaque;
        private static List<int> charactersId = new List<int>();

        public String Nombre { get; private set; }
        public int ValorAtaque
        {
            get
            {
                return this.valorAtaque;
            }
            set
            {
                this.valorAtaque = value;
            }
        }

        public Piedra(string nombre, int valorAtaque)
        {
            this.Nombre = nombre;
            this.ValorAtaque = valorAtaque;
        }
        public static void CharactersId(int identificador)
        {
            charactersId.Add(identificador);

        }
    }
}