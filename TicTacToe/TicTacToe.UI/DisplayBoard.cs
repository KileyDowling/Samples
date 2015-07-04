using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Models;

namespace TicTacToe.UI
{
    public class DisplayBoard
    {

        public static bool UpdateGameBoard(string userSelection, UserInfo currentPlayer)
        {

            bool foundChoice = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (GameBoard.gameBoard[i, j] == userSelection)
                    {
                        GameBoard.gameBoard[i, j] = currentPlayer.UserMarker;
                        foundChoice = true;
                    }
                }
            }
            Console.Clear();
            DisplayGameBoard();
            if (!foundChoice)
                InValidChoice();


            return foundChoice;


        }

        public static void DisplayGameBoard()
        {
            int num = 0;
            Console.WriteLine("\n");
            while (num < 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (GameBoard.gameBoard[num, i] == "3" || GameBoard.gameBoard[num, i] == "6" ||
                        GameBoard.gameBoard[num, i] == "9")
                    {
                        Console.Write("{0}", GameBoard.gameBoard[num, i]);
                    }
                    else
                    {
                        Console.Write("{0}  |  ", GameBoard.gameBoard[num, i]);
                    }

                }
                if (num != 2)
                {
                    Console.WriteLine("\n--------------\n   |     |");
                }
                else
                {
                    Console.WriteLine("\n\n");
                }
                num += 1;
            }

        }

        public static string InValidChoice()
        {
            string result = "Invalid choice.Please try again";
            return result;
        }


    }
}
