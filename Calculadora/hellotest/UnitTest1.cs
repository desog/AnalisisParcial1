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
    }
}
