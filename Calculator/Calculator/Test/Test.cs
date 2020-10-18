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

            CalcFinction s = new CalcFinction();

            double actual = s.Factorial(x);

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

            CalcFinction s = new CalcFinction();

            double actual = s.Summ(x,y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumTest_forDouble_xmin12dot5_y2dot5_expected_min10dot5()
        {
            //arrage

            double x = -12.5;
            double y = 2;

            double expected = -10.5;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Summ(x, y);

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

            CalcFinction s = new CalcFinction();

            double actual = s.Sub(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubTest_forDouble_x10dot5_y2dot5_expected_8()
        {
            //arrage

            double x = 10.5;
            double y = 2.5;

            double expected = 8;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Sub(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultTest_forInt_x20_y2_expected_40()
        {
            //arrage

            double x = 20;
            double y = 2;

            double expected = 40;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Mult(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultTest_forDoble_x20dot5_y2_expected_41()
        {
            //arrage

            double x = 20.5;
            double y = 2;

            double expected = 41;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Mult(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivTest_forInt_x20_y2_expected_10()
        {
            //arrage

            double x = 20;
            double y = 2;

            double expected = 10;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Div(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivTest_forInt_x20dot5_y2_expected_10dot25()
        {
            //arrage

            double x = 20.5;
            double y = 2;

            double expected = 10.25;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Div(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExpTest_forInt_x20_y2_expected_400()
        {
            //arrage

            double x = 20;
            int y = 2;

            double expected = 400;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Exp(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SqrtTest_forInt_x9_expected_3()
        {
            //arrage

            double x = 9;
        
            double expected = 3;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Sqrt(x);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LogTest_forInt_x3_y2_expected_1dot585()
        {
            //arrage

            double x = 3;
            double y = 2;

            double expected = 1.584962500721156;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Log(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Log10Test_forInt_x2_expected_0dot3()
        {
            //arrage

            double x = 2;
     

            double expected = 0.30102999566398114;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Log10(x);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CosTest_forInt_x2_expected_min0dot42()
        {
            //arrage

            double x = 2;


            double expected = -0.416114683;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Cos(x);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SinTest_forInt_x2_expected_0dot9()
        {
            //arrage

            double x = 2;


            double expected = 0.909297426825682;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Sin(x);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TgTest_forInt_x2_expected_min2dot19()
        {
            //arrage

            double x = 2;


            double expected = -2.18503986326152;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Tg(x);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CtgTest_forInt_x2_expected_min0dot5()
        {
            //arrage

            double x = 2;


            double expected = -0.45765755;

            //act

            CalcFinction s = new CalcFinction();

            double actual = s.Ctg(x);

            //assert

            Assert.AreEqual(expected, actual);
        }


    }
}
