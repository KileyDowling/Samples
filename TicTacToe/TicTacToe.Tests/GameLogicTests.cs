using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class GameLogicTests
    {
    /*[TestCase(1,"5")]
        public void RequestPlayerMoveTest(int playersTurn, string expectedResult)
        {
            GamePlay game = new GamePlay();
            string actualResult = game.RequestPlayerMove(playersTurn);
            Assert.AreEqual(expectedResult,actualResult); 
        } */

        [TestCase(1,"X")]
        public void GetPlayersMarkerTest(int playersTurn, string expectedResult)
        {
            GamePlay game = new GamePlay();
            string actualResult = game.GetPlayersMarker(playersTurn);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestCase(1,2)]
        [TestCase(2,1)]
        public void NextPlayersTurn(int lastPlayersTurn, int expectedResult)
        {
            GamePlay game = new GamePlay();
            int actualResult = game.NextPlayersTurn(lastPlayersTurn);
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}
