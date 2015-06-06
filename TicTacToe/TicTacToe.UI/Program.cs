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
            GamePlay game = new GamePlay();
            //game.GetUserInfo();
            game.DisplayGameBoard();
            while (!gameOver)
            {
                string userInput = game.RequestPlayerMove();
                game.UpdateGameBoard(userInput);
                gameOver=game.WonOrTie();
            }



            Console.ReadLine();


        }

    }
}
