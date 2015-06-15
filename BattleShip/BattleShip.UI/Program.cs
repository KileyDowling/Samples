using System;
using System.Collections.Generic;
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

            player1.UserTurn = 1;
            player2.UserTurn = 2;

            //assign userName
            player1.UserName = menu.Execute(player1.UserTurn);
            player2.UserName = menu.Execute(player2.UserTurn); 

            GameBoard player1GameBoard = new GameBoard(player1);


           
            //UI of game board
            ShipSetUp userOnesGamePlay = new ShipSetUp();

            //places ship
            int counter = 0;
            while (counter < 6)
            {
                            player1.MyBoard.PlaceShip(userOnesGamePlay.SetUpShip());
               

            }

            Console.WriteLine("Player one: {0}", player1.UserName);
            //Console.WriteLine("Player two: {0}", player2.UserName);

            //player1.UserGameBoard.PrintGameBoard();
            //player2.UserGameBoard.PrintGameBoard();

           
            
            Console.ReadLine();



        }
    }
}
