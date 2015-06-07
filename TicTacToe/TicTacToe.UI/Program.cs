using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GameLogic;

namespace TicTacToe.UI
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool gameOver = false;
            bool validChoice = false;
            int playersTurn=1;
            GamePlay game = new GamePlay();
            string playersUsername = "";
            string playerOne = game.GetUserInfo(playersTurn);
            string playerTwo = game.GetUserInfo(game.NextPlayersTurn(playersTurn));
            game.DisplayGameBoard();
            while (!gameOver)
            {
                if (playersTurn == 1)
                    playersUsername = playerOne;
                else
                    playersUsername = playerTwo;
                string userInput = game.RequestPlayerMove(playersTurn,playersUsername);
               validChoice = game.UpdateGameBoard(userInput,playersTurn);
                gameOver=game.WonOrTie(playersTurn,playersUsername);
                if (!gameOver && validChoice)
                    playersTurn = game.NextPlayersTurn(playersTurn);
            }

            Console.ReadLine();
        }
    }
}
