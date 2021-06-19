using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame.Services;
using BowlingGame.Helper;

namespace BowlingTest
{
    [TestClass]
    public class BowlingTest
    {
        private Bowling bowlingGame;
        [TestInitialize]
        public void Initialize()
        {
            bowlingGame = new Bowling(new BowlingScore());
        }

        [TestMethod]
        public void TestPerfectBowlingScore()
        {
            for (int frame = 0; frame < 12; frame++)
            {
                bowlingGame.ExecuteBowlingFrame(10);
            }
            Assert.AreEqual(300, bowlingGame.GetFrameScore());
        }

        [TestMethod]
        public void TestSingleFrameScore()
        {
            bowlingGame.ExecuteBowlingFrame(5);
            bowlingGame.ExecuteBowlingFrame(4);
            Assert.AreEqual(9, bowlingGame.GetFrameScore());
        }

        [TestMethod]
        public void TestTwoFrameScore()
        {
            bowlingGame.ExecuteBowlingFrame(5);
            bowlingGame.ExecuteBowlingFrame(4);
            bowlingGame.ExecuteBowlingFrame(7);
            bowlingGame.ExecuteBowlingFrame(2);
            Assert.AreEqual(18, bowlingGame.GetFrameScore());
        }


        [TestMethod]
        public void TestSpareFrameScore()
        {
            bowlingGame.ExecuteBowlingFrame(3);
            bowlingGame.ExecuteBowlingFrame(7);
            bowlingGame.ExecuteBowlingFrame(3);
            BowlingHelper.currentFrameCount = 1;
            Assert.AreEqual(13, bowlingGame.GetFrameScore());
        }

        [TestMethod]
        public void TestScoreAfterSpare()
        {
            bowlingGame.ExecuteBowlingFrame(3);
            bowlingGame.ExecuteBowlingFrame(7);
            bowlingGame.ExecuteBowlingFrame(3);
            bowlingGame.ExecuteBowlingFrame(2);
            Assert.AreEqual(18, bowlingGame.GetFrameScore());
        }

        [TestMethod]
        public void TestStrikeFrameScore()
        {
            bowlingGame.ExecuteBowlingFrame(10);
            bowlingGame.ExecuteBowlingFrame(3);
            bowlingGame.ExecuteBowlingFrame(6);
            Assert.AreEqual(28, bowlingGame.GetFrameScore());
        }
    }
}

