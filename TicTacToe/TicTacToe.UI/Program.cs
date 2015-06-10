using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using  GameLogic;
using GameLogic.Models;
using TicTacToe.UI.Workflow;

namespace TicTacToe.UI
{
	class Program
	{
		private static void Main(string[] args)
		{
			bool gameOver = false;
			int playersTurn = 1;
			
			GamePlay game = new GamePlay();
			PlayerMoves playerMoves = new PlayerMoves();
		    UserInfo userInfo = new UserInfo
		    {
		        UserOne = GetUserInfo.RequestUser(1),
                UserTwo = GetUserInfo.RequestUser(2)
		    };

		    string playerOneMarker = playerMoves.GetPlayersMarker(playersTurn);
		    string playerTwoMarker = playerMoves.GetPlayersMarker(game.NextPlayersTurn(playersTurn));


			DisplayBoard.DisplayGameBoard();
			
            while (!gameOver)
            {
                bool validChoice = false;
                string playersUserName = "";

                playersUserName= playerMoves.GetPlayersUserName(playersTurn, userInfo.UserOne, userInfo.UserTwo);
             
				string userInput = playerMoves.RequestPlayerMove(playersTurn, playersUserName);

				validChoice = DisplayBoard.UpdateGameBoard(userInput, playersTurn);
				gameOver = game.KeepPlaying(playersTurn, playerOneMarker,playerTwoMarker);

                if (!gameOver && validChoice)
                    playersTurn = game.NextPlayersTurn(playersTurn);
                else
                {
                    string notify = "";
                    notify = NotifyWinOrTie.Notify(game.WonOrTie(playersTurn, playerOneMarker, playerTwoMarker),
                        playersUserName);
                    Console.WriteLine(notify);
                }

            }

			Console.ReadLine();
		}

		/****** Tic-Tac-Toe *****

Create a Tic-Tac-Toe game that the user can play in the console.
The game should be turn based so that two players can compete against one another.

Requirements
	- The user will launch the game and be prompted to enter the name of player one.
	- The user will then be prompted to enter the name of player two.
	- The game board will then be displayed to the players and look something like the following:
	
		  |     |
		  |     |
	   1  |  2  |  3
	-------------------
		  |     |
	   4  |  5  |  6	 
		  |     |  
	-------------------	 
		  |     |
		7 |  8  |  9
		  |     |
		  
	
	- Player 1 will be prompted by name to select a location to place their mark.
	- The board will be re-drawn and show the location they selected marked with an X  (O for player 2).
	- At the end of each turn you will need to check for a winner or tie.
	- If a winner is found, display a victory message.
	- If a tie is found, indicate that to the user.
	
*This should be built with a Console project to serve as our UI, a Class Library to serve as the game logic,
and a Class Library to serve as our unit tests for the game logic. */

    }
}
