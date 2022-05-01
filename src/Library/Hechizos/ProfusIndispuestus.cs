using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Hechizos
{
    public class ProfusIndispuestus
    {
        private string nombre;
        private int vida;
        public ProfusIndispuestus(int id, string nombre, int vida, int danio)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Vida = vida;
        }

        public int Id { get; }
        public string Nombre { get; }

        public int Vida { get; private set; }

   
        

    }
}
