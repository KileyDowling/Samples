using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

           
            GamePlay playGame = new GamePlay();
            playGame.SetupGame(player1.UserTurn);


            Console.WriteLine("Player one: {0}", player1.UserName);
            Console.WriteLine("Player two: {0}", player2.UserName);

            player1.UserGameBoard.PrintGameBoard();
            player2.UserGameBoard.PrintGameBoard();


            Console.ReadLine();



        }
    }
}
