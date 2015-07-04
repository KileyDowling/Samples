//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using GameLogic;
//using NUnit.Framework;

//namespace TicTacToe.Tests
//{
//    [TestFixture]
//    public class GameLogicTests
//    {
//       /* [TestCase(1, "Kiley","5")]
//        public void RequestPlayerMoveTest(int playersTurn, string playerUsername, string expectedResult)
//        {
//            GamePlay game = new GamePlay();
//            string actualResult = game.RequestPlayerMove(playersTurn,playerUsername);
//            Assert.AreEqual(expectedResult,actualResult); 
//        }
       
//        [TestCase(1,"Kiley","Kiley")]
//        public void GetUserInfoTest(int playersTurn, string playerUsername, string expectedResult)
//        {
//            GamePlay game = new GamePlay();
//            string actualResult = game.GetUserInfo(playersTurn);
//            Assert.AreEqual(expectedResult, actualResult); 
//        } */

///*
//        [TestCase(1, "X")]
//      [TestCase(2, "O")]
//        public void GetPlayersMarkerTest(int playersTurn, string expectedResult)
//        {
//            GamePlay game = new GamePlay();
//            string actualResult = game.GetPlayersMarker(playersTurn);
//            Assert.AreEqual(expectedResult,actualResult);
//        } 
//        */
//        [TestCase(1,2)]
//        [TestCase(2,1)]
//        public void NextPlayersTurnTest(int lastPlayersTurn, int expectedResult)
//        {
//            GamePlay game = new GamePlay();
//            int actualResult = game.NextPlayersTurn(lastPlayersTurn);
//            Assert.AreEqual(expectedResult,actualResult);
//        }

//      /*  [TestCase("1", 1, true)]
//        public void UpdateGameBoardTest(string userSelection, int playersTurn, bool expectedResult)
//        {
//            GamePlay game = new GamePlay();
//            bool actualResult = game.UpdateGameBoard(userSelection,playersTurn);
//            Assert.AreEqual(expectedResult, actualResult);
//        } */

//    }
//}
