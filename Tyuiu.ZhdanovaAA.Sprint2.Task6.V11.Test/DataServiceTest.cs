using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("24.03.2022", ds.FindDateOfNextDay(2022, 3, 23));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1, 13, 0);
            });
        }
    }
}
