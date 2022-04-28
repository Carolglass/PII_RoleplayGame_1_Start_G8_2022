using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    using System;

    public class Enano
    {
       
        private string nombre;
        private int vida;
        private int danio;


        public Enano (string nombre, int vida, int danio)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Danio = danio;
            
        }

        public string Nombre { get; }

        public int Vida { get; private set; }

        public int Danio { get; }



        public void RecibirDanio(int daniorecibido)
        {
            this.vida-=daniorecibido;
        }

        public bool Vivo()
        {
            return this.vida > 0;
        }
    }
}