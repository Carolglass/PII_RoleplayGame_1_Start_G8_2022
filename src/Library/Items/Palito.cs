using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII_RoleplayGame_1_Start_G8_2022
{
    public class Palito
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

        public Palito(string nombre, int valorAtaque)
        {
            this.Nombre = nombre  ;
            this.ValorAtaque = valorAtaque;
        }
        public static void CharactersId(int identificador)
        {
            charactersId.Add(identificador);
        }
    }
}
