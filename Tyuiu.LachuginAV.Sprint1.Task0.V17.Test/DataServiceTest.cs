using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint1.Task0.V17.Lib;
namespace Tyuiu.LachuginAV.Sprint1.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService(); var res = ds.Calculate();
            Assert.AreEqual(5, res);
        }
    }
}