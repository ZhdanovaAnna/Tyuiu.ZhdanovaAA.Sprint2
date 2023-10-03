using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint2.Task4.V9.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2, y = 5;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(15.4, res);
        }
    }
}
