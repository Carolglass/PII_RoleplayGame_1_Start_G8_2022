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

        public int vidaTotal;
        public Elfo(string nombre, int vida, int danio)
        {
            this.DefinirNombre = nombre;
            this.Vida = vida;
            this.Danio = danio;
        }

        public int Vida
        {
            get
            {
                return this.vida;
            }
            set
            {
                vidaTotal = this.vida;
            }
        }

        public int Danio { get; }

        //Legolas recibe daño del sistema meritocratico y burocratico actual
        public void RecibirDanio(int dañoRecibido)
        {
            this.vida = this.vida - dañoRecibido;
        }

        //legolas se percibe como una planta y quiere cambiarse el nombre
        public string DefinirNombre()
        {
            set
            {
                this.nombre = value;
            }
           
        }

        //curamos a Legolas del daño que le hizo ella :c
        public void Curar()
        {
            this.vida = this.vidaTotal;
        }
    }
}