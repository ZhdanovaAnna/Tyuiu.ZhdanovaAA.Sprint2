using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint2.Task3.V2.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 4;
            var res = ds.Calculate(x);
            Assert.AreEqual(-44.654, res);
        }
    }
}
