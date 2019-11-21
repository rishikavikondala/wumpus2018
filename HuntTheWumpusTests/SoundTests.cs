using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace HuntTheWumpus.Tests
{
    [TestClass()]
    public class SoundTests
    {
        [TestMethod()]
        public void buttonPressedTest()
        {
            Sound test1 = new Sound();
            test1.buttonPressed();

        }

        [TestMethod()]
        public void doorOpenedTest()
        {
            Sound test2 = new Sound();
            test2.doorOpened();

        }

        [TestMethod()]
        public void footstepsTest()
        {
            Sound test3 = new Sound();
            test3.footsteps();

        }

        [TestMethod()]
        public void batsPresentTest()
        {
            Sound test4 = new Sound();
            test4.batsPresent();
        }

        [TestMethod()]
        public void pitPresentTest()
        {
            Sound test5 = new Sound();
            test5.pitPresent();

        }

        [TestMethod()]
        public void wumpusPresentTest()
        {
            Sound test6 = new Sound();
            test6.wumpusPresent();

        }

        [TestMethod()]
        public void gameWinningTest()
        {
            Sound test7 = new Sound();
            test7.gameWinning();

        }

        [TestMethod()]
        public void gameLosingTest()
        {
            Sound test8 = new Sound();
            test8.gameLosing();

        }

        [TestMethod()]
        public void shootArrowTest()
        {
            Sound test9 = new Sound();
            test9.shootArrow();

        }

        [TestMethod()]
        public void correctTest()
        {
            Sound test10 = new Sound();
            test10.correct();

        }

        [TestMethod()]
        public void incorrectTest()
        {
            Sound test11 = new Sound();
            test11.incorrect();

        }
    }
}