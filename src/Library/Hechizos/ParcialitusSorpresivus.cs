using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Hechizos
{
    internal class ParcialitusSorpresivus
    {
        private string nombre;
        private int vida;
        private int danio;

 

        public ParcialitusSorpresivus(int id, string nombre, int vida, int danio)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Danio = danio;
        }

        public int Id { get; }
        public string Nombre { get; }

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

    }
}
