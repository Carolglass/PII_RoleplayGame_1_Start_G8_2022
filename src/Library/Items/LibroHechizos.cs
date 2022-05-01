using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII_RoleplayGame_1_Start_G8_2022
{
    public class LibroHechizos
    {
        private string nombre;
        List<int> daños = new List<int>();
        List<int> curacion = new List<int>();

        public String Nombre { get; private set; }

        public LibroHechizos(string nombre)
        {
            Nombre = this.nombre;//hola
        }
        public void AñadirHechizosVida(int curacion)
        {
            this.curacion.Add(curacion);
        }
        public void AñadirHechizosDaño(int daño)
        {
            this.daños.Add(daño);
        }

        public List<int> Daños
        {
            get { return this.daños; }
        }
    }
}
