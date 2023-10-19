﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NezhdanovDA.Sprint2.Task0.V8.Lib;
namespace Tyuiu.NezhdanovDA.Sprint2.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValicdCompairOperations()
        {
            DataService ds = new DataService();
            int x = 185;
            int y = 251;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
