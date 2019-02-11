using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VuelingPoo;

namespace PooVueling.NUnitV.Integration.Tests
{
    [TestFixture]
    public class CalculadoraTests
    {
        private readonly ICalculadora iCalculadora = new Calculadora();

        [TestCase(4, 2, 2)]
        [TestCase(9, 3, 3)]
        [TestCase(7, 1, 7)]
        public void DivisionTest(int num1, int num2, int resultado)
        {

            Assert.AreEqual(iCalculadora.Division(num1, num2),resultado);

        }

        [TestCase(4, 2, 8)]
        [TestCase(9, 3, 27)]
        [TestCase(7, 1, 7)]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.AreEqual(iCalculadora.Multiplicacion(num1, num2), resultado);

        }

        [TestCase(4, 2, 2)]
        [TestCase(9, 3, 6)]
        [TestCase(7, 1, 6)]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.AreEqual(iCalculadora.Resta(num1, num2), resultado);

        }

        [TestCase(4, 2, 6)]
        [TestCase(9, 3, 12)]
        [TestCase(7, 1, 8)]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.AreEqual(iCalculadora.Suma(num1, num2), resultado);

        }
    }
}
