using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PII_RoleplayGame_1_Start_G8_2022;
using Library;



namespace PII_RoleplayGame_1_Start_G8_2022
{
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void TestElfoVsOrco()
        {
            //Se testea el método de recibir daño de la clase Orco
            //Se testea el método vida para el Orco, comprobando que está vivo una vez que recibió un ataque

            bool expectedVida = true;
            Elfo Juan = new Elfo(0, "Juan", 8, 3);
            Orco Matias = new Orco(1, "Matias", 6, 3);
            int expectedDanio = 3;
            Matias.RecibirDanio(Juan.Danio);
            Assert.AreEqual(expectedDanio, Matias.Danio);
            Assert.AreEqual(expectedVida, Matias.Vida);

        }




        [Test]
        public void TestVidaOrco()
        {
            //Se testea el método de recibir daño de la clase Orco
            //Se testea el método vida para el Orco, comprobando que está vivo una vez que recibió un ataque

            bool expectedVida = true;
            Elfo Juan = new Elfo(0, "Juan", 10, 5);
            Orco Matias = new Orco(1, "Matias", 10, 5);
            int expectedDanio = 0;
            Assert.AreEqual(expectedDanio, Matias.Danio);
            Assert.AreEqual(expectedVida, Matias.Vida);

        }














    }
}