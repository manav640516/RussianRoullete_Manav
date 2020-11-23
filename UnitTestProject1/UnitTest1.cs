using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoullete_Manav;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        AllFunctionClass functionClass = new AllFunctionClass();

        [TestMethod]
        public void ShootAwayTest()
        {

            functionClass.shootAwayChancesManav = 2;

            int Expected = 2;
            int Actual = functionClass.shootAwayChancesManav;

            Assert.AreEqual(Expected, Actual);

        }

        [TestMethod]
        public void SpinTest()
        {

            try
            {
                functionClass.Spin();

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
}
