using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint2.Task5.V9.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("24 Марта", ds.FindDateOfNextDay(3, 23));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1, 13);
            });
        }
    }
}
