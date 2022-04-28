using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    using System;

    public class Elfo
    {


        
        private string nombre;
        private int vida;
        private int danio;

        public Elfo(string nombre, int vida, int danio)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Danio = danio;
        }
            
        public string Nombre { get; }

        public int Vida { get; private set; }

        public int Danio { get; }

        public void RecibirDanio(int dañoRecibido)
        {
            this.vida = this.vida - dañoRecibido;
        }


        public bool Vido()
        {
            return this.vida> 0;
        }
        /*
        public void Attack(Character enemy)
        {
            enemy.Life = enemy.Life - this.Damage;
        }

        public bool Healthy()
        {
            return this.Life > 0;
        }
        */
    }
}
