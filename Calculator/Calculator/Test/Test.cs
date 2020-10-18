using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void FactorialTest_x3_expected_6()
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

        [TestMethod]
        public void SumTest_forINT_x10_y10_expected_20()
        {
            //arrage

            int x = 10;
            int y = 10;

            int expected = 20;

            //act

            CalcFinction intSumm = new CalcFinction();

            double actual = intSumm.Summ(x,y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumTest_forDouble_x2dot5_y2dot5_expected_5()
        {
            //arrage

            double x = 2.5;
            double y = 2.5;

            int expected = 5;

            //act

            CalcFinction intSumm = new CalcFinction();

            double actual = intSumm.Summ(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubTest_forINT_x20_y10_expected_10()
        {
            //arrage

            int x = 20;
            int y = 10;

            int expected = 10;

            //act

            CalcFinction intSub = new CalcFinction();

            double actual = intSub.Sub(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }
/*
        [TestMethod]
       *//* public void SubTest_forDouble_x10dot5_y2dot5_expected_8()
        {
            //arrage

            double x = 10.5;
            double y = 2.5;

            int expected = 8;

            //act

            CalcFinction intSub = new CalcFinction();

            double actual = intSub.Sub(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }*/

    }
}
