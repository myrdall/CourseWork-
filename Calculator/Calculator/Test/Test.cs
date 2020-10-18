using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void FactorialTest()
        {
            //arrage

            int x = 3;

            int expected = 6;

            //act

            CalcFinction factorial = new CalcFinction();

            double actual = factorial.Factorial(x);

            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}
