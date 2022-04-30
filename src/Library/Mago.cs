using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    using System;

    public class Mago
    {
        public Mago(int id, string nombre, int vida, int danio)
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

        public bool Healthy()
        {
            return this.Vida > 0;

        }
        public void AumentarVida(int VidaAumentada)
        {
            this.vida += VidaAumentada;
        }
      //  if (Id==1)
       //     {
        //      Mago.AumentarVida(Vida)
         //   }
	}

	}
	{

	}
    }
}
