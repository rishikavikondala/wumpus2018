using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HuntTheWumpus.Tests
{
    [TestClass()]
    public class TriviaTests
    {
        [TestMethod()]
        public void Test_Constructor()
        {
            Trivia testTrivia = new Trivia();
        }

        [TestMethod()]
        public void askQuestion()
        {
            Trivia testTrivia2 = new Trivia();
            testTrivia2.askQuestion();
        }

        [TestMethod()]
        public void giveHint()
        {
            Trivia testTrivia3 = new Trivia();
            testTrivia3.giveHint();
        }

        [TestMethod()]
        public void checkAnswer()
        {
            Trivia testTrivia4 = new Trivia();
            testTrivia4.askQuestion();
            testTrivia4.checkAnswer("d");
        }
    }
}
