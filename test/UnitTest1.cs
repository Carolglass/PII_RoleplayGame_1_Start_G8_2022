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
        public void TestMagoVsEnano()
        {
            //Se testea el método de recibir daño de la clase enano
            //Se testea el método vida para el mago, comprobando que está vivo
         
            bool expectedHealth = true;
            Mago Juan = new Mago(0, "Juan", 4, 3);
            Enano Matias = new Enano(1, "Matias", 6, 2);
            Assert.AreEqual(expectedHealth, Juan.Vivo());
            int expectedDanio = 3;
            Assert.AreEqual(expectedDanio, Matias.RecibirDanio(Juan.Danio));
        }

        [Test]
        public void TestElfoVsOrco()
        {
            //Se testea el método de recibir daño de la clase Orco
            //Se testea el método vida para el Elfo, comprobando que está vivo

            bool expectedHealth = true;
            Elfo Juan = new Elfo(0, "Juan", 8, 3);
            Orco Matias = new Orco(1, "Matias", 6, 2);
            Assert.AreEqual(expectedHealth, Juan.Vivo());
            int expectedDanio = 3;
            Assert.AreEqual(expectedDanio, Matias.RecibirDanio(Juan.Danio));
        }


        [Test]
        public void TestMuerte()
        //Este test sirve para verificar que cuando el valor de vida del orco es menor que 0 es porque murió y 
        //que el hacer daño del enano funciona
        {
            bool expectedHealth = false;
            Elfo Kevin = new Elfo(0, "Kevin", 6, 7);
            Orco German = new Orco(1, "German", 6, 2);
            German.RecibirDanio(Kevin.Danio);
            Assert.AreEqual(expectedHealth, German.Vivo());
           
        }

   







    }
}