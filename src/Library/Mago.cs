using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII_RoleplayGame_1_Start_G8_2022
{
    using System;

    public class Mago
    {
        private string nombre;
        private int vida;
        private int danio;

        public static int vidaTotal;


        public Mago(int id, string nombre, int vida, int danio)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Vida = vida;
            vidaTotal = vida;
            this.Danio = danio;
        }
        public int Id { get; }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Vida
        {
            get
            {
                return this.vida;
            }
            set
            {
                this.vida = value;
            }
        }

        public int Danio
        {
            get
            {
                return this.danio;
            }
            set
            {
                this.danio = value;
            }
        }

        public bool Vivo()
        {
            this.vida = vidaTotal;
        }

    }
}
