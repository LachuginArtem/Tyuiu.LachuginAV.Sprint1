using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint1.Task3.V2.Lib;

namespace Tyuiu.LachuginAV.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 1.5012;
            int amountNotebook = 2;
            double pricePencil = 2.3051;
            int amountPencil = 4;
             var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(12.223, res);
        }
    }
}
