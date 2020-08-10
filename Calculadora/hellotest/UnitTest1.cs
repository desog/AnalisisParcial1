using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
namespace hellotest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("ADIOS MUN", Calculadora.Form1.createMessage());
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("HOLA", Calculadora.Form1.PruebaSuma());
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("MUNDO", Calculadora.Form1.PruebaResta());
        }

        [TestMethod]
        public void TestMethodAdd()
        {
            Double a, b;
            a = 12.50;
            b = 12.50;
            Assert.AreEqual(25.0, Calculadora.Form1.Add(a, b));
        }

        [TestMethod]
        public void TestMethodDivision()
        {
            Double a, b;
            a = 12.50;
            b = 12.50;
            Assert.AreEqual(1.0, Calculadora.Form1.Division(a, b));
        }

    }
}
