﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GutsuAV.Sprint6.Task6.V6.Lib;
using System.IO;
namespace Tyuiu.GutsuAV.Sprint6.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutFileTask5V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
