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
            //Se testea el método vida para el Orco una vez que fue atacado
                        
            Elfo Juan = new Elfo(0, "Juan", 8, 3);
            Orco Matias = new Orco(1, "Matias", 6, 3);
            int expectedDanio = 3;
            
            Matias.RecibirDanio(Juan.Danio);
            Assert.AreEqual(expectedDanio, Matias.Vida);
            

        }

        [Test]
        public void TestOrcoVsElfo()
        {
            //Se testea el método vida para Elfo una vez que fue atacado

            Orco Juan = new Orco(0, "Juan", 8, 3);
            Elfo Matias = new Elfo(1, "Matias", 6, 3);
            int expectedDanio = 3;
            Matias.RecibirDanio(Juan.Danio);
            Assert.AreEqual(expectedDanio, Matias.Vida);

        }

        [Test]
        public void TestMagoVsEnano()
        {
            //Se testea el método vida para Mago una vez que fue atacado

            Mago Juan = new Mago(0, "Juan", 8, 3);
            Enano Matias = new Enano(1, "Matias", 6, 3);
            int expectedDanio = 3;
            Matias.RecibirDanio(Juan.Danio);
            Assert.AreEqual(expectedDanio, Matias.Vida);

        }

        [Test]
        public void TestEnanoVsMago()
        {
            //Se testea el método vida para Enano una vez que fue atacado

            Enano Juan = new Enano(0, "Juan", 8, 3);
            Mago Matias = new Mago(1, "Matias", 6, 3);
            int expectedDanio = 3;
            Matias.RecibirDanio(Juan.Danio);
            Assert.AreEqual(expectedDanio, Matias.Vida);

        }


        [Test]
        public void TestOrcoCurado()
        {
            //Se testea el método Curar para el Orco luego de ser atacado

            Elfo Juan = new Elfo(0, "Juan", 8, 3);
            Orco Matias = new Orco(1, "Matias", 6, 3);
            int expected = 6;
            Matias.RecibirDanio(Juan.Danio);
            Matias.Curar();
            Assert.AreEqual(expected, Matias.Vida);

        }

        [Test]
        public void TestEnanoCurado()
        {
            //Se testea el método Curar para el Enano luego de ser atacado

            Elfo Juan = new Elfo(0, "Juan", 8, 3);
            Enano Matias = new Enano(1, "Matias", 6, 3);
            int expected = 6;
            Matias.RecibirDanio(Juan.Danio);
            Matias.Curar();
            Assert.AreEqual(expected, Matias.Vida);

        }

        [Test]
        public void TestMagoCurado()
        {
            //Se testea el método Curar para el Mago luego de ser atacado

            Elfo Juan = new Elfo(0, "Juan", 8, 3);
            Mago Matias = new Mago(1, "Matias", 6, 3);
            int expected = 6;
            Matias.RecibirDanio(Juan.Danio);
            Matias.Curar();
            Assert.AreEqual(expected, Matias.Vida);

        }

        [Test]
        public void TestElfoCurado()
        {
            //Se testea el método Curar para el Elfo luego de ser atacado

            Mago Juan = new Mago(0, "Juan", 8, 3);
            Elfo Matias = new Elfo(1, "Matias", 6, 3);
            int expected = 6;
            Matias.RecibirDanio(Juan.Danio);
            Matias.Curar();
            Assert.AreEqual(expected, Matias.Vida);

        }


        

         [Test]
        public void TestMagoHacha()
        {
            //Se testea el nuevo Danio luego de cargar el Hacha

            Mago Juan = new Mago(0, "Juan", 8, 3);
            Hacha hacha = new Hacha("Hacha", 5);
            int expected = 8;
            Juan.Danio = Juan.Danio + hacha.ValorAtaque; //El Mago Juan carga su Hacha para el ataque
            Assert.AreEqual(expected, Juan.Danio);
        }






    }
}