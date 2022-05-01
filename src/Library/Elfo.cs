using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII_RoleplayGame_1_Start_G8_2022
{
    using System;

    public class Elfo
    {

        private string nombre;
        private int vida;
        private int danio;

        public static int vidaTotal;

        public Elfo(int id, string nombre, int vida, int danio)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Vida = vida;
            vidaTotal = vida;
            this.Danio = danio;
        }

        public int Id { get; }

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

        //Legolas recibe daño del sistema meritocratico y burocratico actual
        public void RecibirDanio(int dañoRecibido)
        {
            this.vida = this.vida - dañoRecibido;
        }

        //legolas se percibe como una planta y quiere cambiarse el nombre
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

        //curamos a Legolas del daño que le hizo ella :c
        public void Curar()
        {
            this.vida = vidaTotal;
        }

        public bool Vivo()
        {
            return this.Vida > 0;
        }

    }
}