using Microsoft.VisualStudio.TestTools.UnitTesting;
using HuntTheWumpus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus.Tests
{
    [TestClass()]
    public class CaveTests
    {
        [TestMethod()]
        public void CaveTest()
        {
            Cave testCave1 = new Cave("Test");
        }

        [TestMethod()]
        public void CaveTest1()
        {
            String path = @"C:\Users\pumpk\source\repos\HuntTheWumpus\HuntTheWumpus\bin\Debug\jamesCave1.txt";
            Cave testCave2 = new Cave(path, "Test");
        }

        [TestMethod()]
        public void availablePathsTest()
        {
            Cave testCave3 = new Cave("Test");
            testCave3.availablePaths(3);
        }

        [TestMethod()]
        public void getNameTest()
        {
            Cave testCave4 = new Cave("Test");
            testCave4.getName();
        }

        [TestMethod()]
        public void getCaveSystemTest()
        {
            Cave testCave5 = new Cave("Test");
            testCave5.getCaveSystem();
        }
    }
}