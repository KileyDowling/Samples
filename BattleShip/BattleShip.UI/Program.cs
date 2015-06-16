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

            player1.UserTurn = 1;
            player2.UserTurn = 2;

            //assign userName
            player1.UserName = menu.Execute(player1.UserTurn);
            player2.UserName = menu.Execute(player2.UserTurn);



            //places ship
            int counter = 0;
            while (counter < 5)
            {
                ShipSetUp setUpYourShip = new ShipSetUp();
                PlaceShipRequest shipRequest = new PlaceShipRequest();
                shipRequest = setUpYourShip.SetUpShip(player1.GameBoard.BoardDictionary);
                player1.MyBoard.PlaceShip(shipRequest);
                counter++;
            }



            Console.ReadLine();



        }
    }
}
