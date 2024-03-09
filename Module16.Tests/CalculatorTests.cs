using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Module16.Tests
{
    class CalculatorTests
    {
        [Test]
        public void MiltiplicationMustReturnValueNotNull()
        {
            var calculator = new Calculator();
            Assert.AreEqual(8, calculator.Miltiplication(2, 4));

        }
        [Test]
        public void AdditionalMustReturnValueNotNull()
        {
            var calculator = new Calculator();
            Assert.AreEqual(6, calculator.Additional(2, 4));

        }

        [Test]
        public void SubstractionMustReturnRightValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(100, 10) == 90);

        }
        
        [Test]
        public void DivisionMustReturnRightValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(100, 10) == 10);

        }

    }
}
