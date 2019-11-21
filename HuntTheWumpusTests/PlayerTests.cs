using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        private static String placeholder = "placeholder";
        private static Cave testCave = new Cave("placeholder");
        private static Map testMap = new Map(0, 0, testCave);

        [TestMethod()]
        public void PlayerTest()
        {
            Player test1 = new Player(placeholder, testCave, testMap);


        }

        [TestMethod()]
        public void PlayerTest1()
        {
            Player test2 = new Player(placeholder, 0, testCave);


        }

        [TestMethod()]
        public void MoveTest()
        {
            Player test3 = new Player(placeholder, testCave, testMap);
            test3.Move("N");

        }

        [TestMethod()]
        public void shootArrowTest()
        {
            Player test4 = new Player(placeholder, testCave, testMap);
            test4.shootArrow("N");

        }

        [TestMethod()]
        public void purchaseArrowsTest()
        {
            Player test5 = new Player(placeholder, testCave, testMap);
            test5.purchaseArrows();

        }

        [TestMethod()]
        public void purchaseSecretTest()
        {
            Player test6 = new Player(placeholder, testCave, testMap);
            test6.purchaseSecret();

        }

        public void WumpTriviaTests()
        {
            Player test12 = new Player(placeholder, testCave, testMap);
            test12.WumpTrivia();
        }

        [TestMethod()]
        public void getScoreTest()
        {
            Player test7 = new Player(placeholder, testCave, testMap);
            test7.getScore();

        }

        [TestMethod()]
        public void getTurnsTest()
        {
            Player test8 = new Player(placeholder, testCave, testMap);
            test8.getTurns();

        }

        [TestMethod()]
        public void getGoldTest()
        {
            Player test9 = new Player(placeholder, testCave, testMap);
            test9.getGold();

        }

        [TestMethod()]
        public void getArrowsTest()
        {
            Player test10 = new Player(placeholder, testCave, testMap);
            test10.getArrows();

        }

        [TestMethod()]
        public void toStringTest()
        {
            Player test11 = new Player(placeholder, testCave, testMap);
            test11.toString();

        }
    }
}