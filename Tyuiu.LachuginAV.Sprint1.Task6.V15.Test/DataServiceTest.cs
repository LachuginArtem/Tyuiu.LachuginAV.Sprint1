using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint1.Task6.V15.Lib;

namespace Tyuiu.LachuginAV.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public static void ValidString()
        {
            DataService ds = new DataService();
        string value = "ewfwe ef wer wccew";
        bool res = ds.CheckLettersCount(value);
        bool wait = true;
        Assert.AreEqual(res, wait);
        }
    }
}
