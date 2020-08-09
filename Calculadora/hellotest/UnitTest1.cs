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



    }
}
