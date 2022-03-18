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
    public class Step2Tests
    {
        [TestMethod()]
        public void RunTest_加算()
        {
            Step2 Step2 = new Step2();
            var input1 = "8";
            var input2 = "2";
            var ope = "+";

            var actual = Step2.Run(input1, input2, ope);
            Assert.AreEqual(10, actual);
        }

        [TestMethod()]
        public void RunTest_減算()
        {
            Step2 Step2 = new Step2();
            var input1 = "8";
            var input2 = "2";
            var ope = "-";

            var actual = Step2.Run(input1, input2, ope);
            Assert.AreEqual(6, actual);
        }

        [TestMethod()]
        public void RunTest_乗算()
        {
            Step2 Step2 = new Step2();
            var input1 = "8";
            var input2 = "2";
            var ope = "*";

            var actual = Step2.Run(input1, input2, ope);
            Assert.AreEqual(16, actual);
        }

        [TestMethod()]
        public void RunTest_除算()
        {
            Step2 Step2 = new Step2();
            var input1 = "8";
            var input2 = "2";
            var ope = "/";

            var actual = Step2.Run(input1, input2, ope);
            Assert.AreEqual(4, actual);
        }

        [TestMethod()]
        public void RunTest_累乗()
        {
            Step2 Step2 = new Step2();
            var input1 = "8";
            var input2 = "2";
            var ope = "^";

            var actual = Step2.Run(input1, input2, ope);
            Assert.AreEqual(64, actual);
        }

        [TestMethod()]
        public void RunTest_剰余()
        {
            Step2 Step2 = new Step2();
            var input1 = "8";
            var input2 = "2";
            var ope = "%";

            var actual = Step2.Run(input1, input2, ope);
            Assert.AreEqual(0, actual);
        }

    }
}