using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Items
{
    internal class Casco
    { 
        private string nombre;
        private int valorDefensa;
        private static List<int> charactersId = new List<int>();

        public String Nombre{ get; private set; }
        public int valorDefensa { get; private set; } 

        public Casco(string nombre, int valorDefensa)
        {
            Nombre = this.nombre;
            valorDefensa = this.valorDefensa;
        }
            public static void CharactersId(int identificador)
        {
            charactersId.Add(identificador);
        }
    }
}
