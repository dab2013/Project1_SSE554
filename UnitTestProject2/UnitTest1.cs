using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Project1_SSE554;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEndless()
        {
            GameType game = new GameType();
            int num = game.setGameType("Endless-RPS");
            Assert.IsTrue(num == 0);
        }

        [TestMethod]
        public void TestFirstToTwo()
        {
            GameType game = new GameType();
            int num = game.setGameType("FirstToTwo-RPS");
            Assert.IsTrue(num == 1);
        }

        [TestMethod]
        public void TestGuessTheNumber()
        {
            GameType game = new GameType();
            int num = game.setGameType("GuessTheNumber");
            Assert.IsTrue(num == 2);
        }

        [TestMethod]
        public void TestRange()
        {
            GameType game = new GameType();
            string range = "1-10";
            int[] numberRange = game.numberRangeChosen(range);
            Assert.IsTrue(numberRange[0] == 1 && numberRange[1] == 10);
        }
    }
}
