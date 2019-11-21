using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HuntTheWumpus;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus.Tests
{
    [TestClass()]
    public class MapTests
    {
        //Fields to establish testing structure.
        private static String placeholder = "placeholder";
        private static Cave constant = new Cave(placeholder);

        //Method to test the constructor.
        [TestMethod()]
        public void creationTest()
        {
            Map testOne = new Map(0, 0, constant);
        }
        //Method to test the 'randomize player' method. 
        [TestMethod()]
        public void randomizeTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.randomizePlayer();
        }
        //Method to test the 'move bat' method. 
        [TestMethod()]
        public void moveBatTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.moveBat();
        }
        //Method to test the 'move wumpus' method. 
        [TestMethod()]
        public void moveWumpusTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.moveBat();
        }
        //Method to test the 'string to int' method.
        [TestMethod()]
        public void stringDIntoIntDTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.StringDtoIntD("N");
        }
        //Method to test the 'valid room' method. 
        [TestMethod()]
        public void validRoomTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.validRoom("N");
        }
        //Method to test the 'get player index' method. 
        [TestMethod()]
        public void getPlayerIndexTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.getPlayerIndex();
        }
        //Method to test the 'close by' method. 
        [TestMethod()]
        public void closeByTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.closeBy("N");
        }
        //Method to test the 'shoot' method // @Toma.
        [TestMethod()]
        public void shootTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.shoot("N");
        }
        //Method to test the 'move player' method. 
        [TestMethod()]
        public void movePlayerTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.movePlayer("N");
        }
        //Method to test the 'get player position' method.
        [TestMethod()]
        public void getPlayerPosTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.getPlayerPos();
        }
        //Method to test the 'get wumpus position' method. 
        [TestMethod()]
        public void getWumpusPosTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.getWumpusPos();
        }
        //Method to test the 'get bat position(s)' method. 
        [TestMethod()]
        public void getBatPosTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.getBatPos();
        }
        //Method to test the 'get pit position(s)' method. 
        [TestMethod()]
        public void getDitchPosTest()
        {
            Map testOne = new Map(0, 0, constant);
            testOne.getDitchPos();
        }
    }
}