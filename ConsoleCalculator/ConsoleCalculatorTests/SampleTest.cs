using ConsoleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculatorTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void Calc_加算()
        {
            var input1 = 10;
            var input2 = 5;
            var ope = "+";

            var calculator = new SampleCalculator();
            int result = calculator.Calc(input1, input2, ope);
            var expected = 15;

            Assert.AreEqual(expected, result);
        }
    }
}
