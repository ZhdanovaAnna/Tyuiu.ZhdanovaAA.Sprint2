using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint2.Task7.V1.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.5, y = -0.5;
            Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));

            x = -0.5; y = 0.5;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
