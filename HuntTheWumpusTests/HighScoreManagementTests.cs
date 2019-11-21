using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus.Tests
{
    [TestClass()]
    public class HighScoreManagementTests
    {
        [TestMethod()]
        public void Test_Constructor()
        {
            HighScoreManagement testList = new HighScoreManagement();
        }

        [TestMethod()]
        public void Test_newTopTen()
        {
            HighScoreManagement testList = new HighScoreManagement();
            Cave testcave = new Cave("testCave");
            Player testPlayer = new Player("Bob", 100, testcave);
            testList.newTopTen(testPlayer);
            testList.toString();
        }

        [TestMethod()]
        public void toStringTest()
        {
            HighScoreManagement testList = new HighScoreManagement();
            testList.toString();
        }
    }
}