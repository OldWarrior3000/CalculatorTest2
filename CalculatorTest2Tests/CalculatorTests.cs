using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTest2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest2.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Add(1,2);
            Assert.AreEqual(3, result); 
        }

        [TestMethod()]
        [Owner("OldWarrior")]
        [TestCategory("Standard")]
        [Priority(1)]
        public void SubstractTest()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Substract(1, 2);    
            Assert.AreEqual(3, result);     //FAIL

        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionWithWrongParametersTest()
        {
            Calculator calculator = new Calculator();
            calculator.Divide(1,0);
        }

        [TestMethod()]
        public void DivisionTest()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Divide(9, 3);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddAllTest()
        {
            Calculator calculator = new Calculator();
            var Result = calculator.AddAll(1,2,3);
            Assert.AreEqual(6, Result);
        }
    }
}