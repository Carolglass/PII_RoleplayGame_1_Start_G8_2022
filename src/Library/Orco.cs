using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
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

        public int Vida { get; private set; }

        public int Danio { get; }


        public void RecibirDanio(int daniorecibido)
        {
            this.vida -= daniorecibido;
        }

        public bool Vivo()
        {
            return this.vida > 0;
        }
}
