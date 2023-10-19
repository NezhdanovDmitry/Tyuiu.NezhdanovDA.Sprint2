using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NezhdanovDA.Sprint2.Task0.Lib;
namespace Tyuiu.NezhdanovDA.Sprint2.Task0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValicdCompairOperations()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 16;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, true, true, true, true, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
