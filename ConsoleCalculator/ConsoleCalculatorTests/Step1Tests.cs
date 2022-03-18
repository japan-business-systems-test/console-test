using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Tests
{
    [TestClass()]
    public class Step1Tests
    {
        [TestMethod()]
        public void RunTest_加算()
        {
            Step1 step1 = new Step1();
            var input1 = "8";
            var input2 = "2";
            var ope = "+";

            var actual = step1.Run(input1, input2, ope);
            Assert.AreEqual(10, actual);
        }

        [TestMethod()]
        public void RunTest_減算()
        {
            Step1 step1 = new Step1();
            var input1 = "8";
            var input2 = "2";
            var ope = "-";

            var actual = step1.Run(input1, input2, ope);
            Assert.AreEqual(6, actual);
        }

        [TestMethod()]
        public void RunTest_乗算()
        {
            Step1 step1 = new Step1();
            var input1 = "8";
            var input2 = "2";
            var ope = "*";

            var actual = step1.Run(input1, input2, ope);
            Assert.AreEqual(16, actual);
        }

        [TestMethod()]
        public void RunTest_除算()
        {
            Step1 step1 = new Step1();
            var input1 = "8";
            var input2 = "2";
            var ope = "/";

            var actual = step1.Run(input1, input2, ope);
            Assert.AreEqual(4, actual);
        }

        [Ignore]
        [TestMethod()]
        public void RunTest_累乗()
        {
            Step1 Step1 = new Step1();
            var input1 = "8";
            var input2 = "2";
            var ope = "^";

            var actual = Step1.Run(input1, input2, ope);
            Assert.AreEqual(64, actual);
        }

        [Ignore]
        [TestMethod()]
        public void RunTest_剰余()
        {
            Step1 Step1 = new Step1();
            var input1 = "8";
            var input2 = "2";
            var ope = "%";

            var actual = Step1.Run(input1, input2, ope);
            Assert.AreEqual(0, actual);
        }

    }
}