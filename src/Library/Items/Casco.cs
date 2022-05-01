using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII_RoleplayGame_1_Start_G8_2022
{
    internal class Casco
    {
        private string nombre;
        private int valorDefensa;
        private static List<int> charactersId = new List<int>();
        public String Nombre { get; private set; }
        public int ValorDefensa { get; private set; }

        public Casco(string nombre, int valorAtaque)
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
