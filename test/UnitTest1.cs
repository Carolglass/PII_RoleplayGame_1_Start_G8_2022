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
        public void Test1()
        {
            bool expected = true;
            Mago magoPrueba = new Mago(0, "MagoPrueba", 4, 3);
            Assert.AreEqual(expected, magoPrueba.Healthy());
        }


    }
}