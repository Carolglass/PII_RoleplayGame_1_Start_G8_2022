using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Items
{
    public class LibroHechizos
    {
        private string nombre;

        private static List<int> charactersId = new List<int>();

        private static List<int> hechizosId = new List<int>();

        public String Nombre { get; private set; }


        public LibroHechizos(string nombre, int valorAtaque)
        {
            Nombre = this.nombre;//hola

        }
        public static void CharactersId(int identificador)
        {
            charactersId.Add(identificador);
        }
        public static void HechizosId(int identificadorHechizo)
        {
            hechizosId.Add(identificadorHechizo);
        }
    }
}
