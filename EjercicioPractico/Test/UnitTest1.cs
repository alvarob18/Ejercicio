using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioPractico;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var alquiler = new Alquiler();
            
            alquiler.opciones(1);
            
            Assert.AreEqual(5, alquiler.CostoTotal);
        }
        [TestMethod]
        public void TestMethod2()
        {

            var alquiler = new Alquiler();

            alquiler.opciones(2);

            Assert.AreEqual(20, alquiler.CostoTotal);
        }
        [TestMethod]
        public void TestMethod3()
        {

            var alquiler = new Alquiler();

            alquiler.opciones(3);

            Assert.AreEqual(60, alquiler.CostoTotal);
        }
        [TestMethod]
        public void TestMethod4()
        {

            var alquiler = new Alquiler();

            alquiler.opciones(4);

            Assert.IsTrue(alquiler.Descuento);
        }
    }
}
