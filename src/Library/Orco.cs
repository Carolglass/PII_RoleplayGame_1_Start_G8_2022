using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII_RoleplayGame_1_Start_G8_2022
{
    public class Orco
    {
        private string nombre;
        private int vida;
        private int danio;

        public Orco(int id, string nombre, int vida, int danio)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Vida = vida;
            this.Danio = danio;
        }

        public int Id { get; }

        public string Nombre { get; }

        public int Vida { get; set; }

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


        public int RecibirDanio(int daniorecibido)
        {
            this.Vida -= daniorecibido;
            return this.Vida;
        }

        public bool Vivo()
        {
            return this.Vida > 0;
        }
    }
}
