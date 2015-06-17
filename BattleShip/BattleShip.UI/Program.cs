using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.UI.Models;
using BattleShip.UI.Workflow;

namespace BattleShip.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerInfo player1 = new PlayerInfo();
            PlayerInfo player2 = new PlayerInfo();


            StartMenu menu = new StartMenu();

            //assign turns
            player1.UserTurn = 1;
            player2.UserTurn = 2;

          //assign userName
            player1.UserName = menu.Execute(player1.UserTurn);
            player2.UserName = menu.Execute(player2.UserTurn);

            //create gameboard
            GameBoard gameBoard = new GameBoard();

        //allow users to place ships -- player1
            gameBoard.PrintGameBoard();
            ShipSetUp setUpShips = new ShipSetUp();
            setUpShips.AllowUserToPlace5Ships(gameBoard,player1);

            //allow users to place ships -- player2
            gameBoard.PrintGameBoard();
            setUpShips.AllowUserToPlace5Ships(gameBoard,player2); 
        
 
            GamePlay playGame = new GamePlay();
            playGame.PlayTheGame(player1, player2, gameBoard);
            Console.ReadLine();



        }

    
    }
}
