using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint2.Task2.V9.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3, y = 12;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, res);
        }
    }
}
