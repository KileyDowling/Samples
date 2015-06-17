using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;
using BattleShip.UI.Models;

namespace BattleShip.UI.Workflow
{
    public class ShipSetUp
    {

        public PlaceShipRequest SetUpShip(Dictionary<string, Coordinate> userDictionary, int shipTypeAsNum)
        {

            string coordinateRequested = "";
            string shipDirectionRequest = "";
            int shipDirAsNum = 0;

            //get ship type
            ShipType shipType = SetShipType(shipTypeAsNum);
            Console.WriteLine("You are placing a {0}....", shipType);

            //get X & Y
            Console.Write("\t(1) Please enter your X & Y coordinate(Ex: A1): ");
            coordinateRequested = Console.ReadLine();

            //get ship direction
            while (!int.TryParse(shipDirectionRequest, out shipDirAsNum))
            {
                Console.Write("\t(2) Please enter your ship direction (up=0,down=1,left=2,right=3): ");
                shipDirectionRequest = Console.ReadLine();
            }
            shipDirAsNum = int.Parse(shipDirectionRequest);
            ShipDirection shipDirection = SetShipDirection(shipDirAsNum);


            //get coordinate
            ConvertX convertX = new ConvertX();
            Coordinate aCoordinate = convertX.Conversion(userDictionary, coordinateRequested);

            
           

            //place ship
            PlaceShipRequest placeShips = new PlaceShipRequest
            {
                Coordinate = aCoordinate,
                Direction = shipDirection,
                ShipType = shipType
            };

            return placeShips;

        }

        public void AllowUserToPlace5Ships(GameBoard gameBoard, PlayerInfo playerInfo)
        {
            Console.WriteLine("Hello, {0}! Let's place your ships \n", playerInfo.UserName);
            //places ship
            int counter = 0;
            //iterates through for all 5 placements
            while (counter < 5)
            {
                if (counter == 5)
                    Console.WriteLine("-- Place Your Final Ship! -- ");
                else
                    Console.WriteLine("-- Place Ship #{0} --", counter+1);

                ShipSetUp setUpYourShip = new ShipSetUp(); // acces UI Ship Placement
                PlaceShipRequest shipRequest = new PlaceShipRequest(); // initiates placeship request business logic

                //assigns user entered ship placeemnt biz logic request using the associated board dictionary
                shipRequest = setUpYourShip.SetUpShip(gameBoard.BoardDictionary,counter);

                //assigns ship request to player1's board                
                
                //PlaceShip method on the Board(biz logic) checks if the PlaceShip is valid
                if (playerInfo.MyBoard.PlaceShip(shipRequest) != ShipPlacement.Ok )
                {
                    Console.WriteLine("\n\t\t****ERROR -- INVALID SHIP PLACEMENT****\n");
                    counter--;
                }
                ;
                counter++;
            }

            Console.WriteLine("Thank you for your input {0}! Press enter to clear the console so the other player cannot cheat!", playerInfo.UserName);
            Console.ReadLine();
            Console.Clear();
        }

        public ShipDirection SetShipDirection(int usersChoice)
        {
            ShipDirection result;
            switch (usersChoice)
            {
                case 0:
                    result = ShipDirection.Up;
                    break;

                case 1:
                    result = ShipDirection.Down;
                    break;

                case 2:
                    result = ShipDirection.Left;
                    break;

                default:
                    result = ShipDirection.Right;
                    break;
            }

            return result;
        }


        public ShipType SetShipType(int usersChoice)
        {
            ShipType result;
            switch (usersChoice)
            {
                case 0:
                    result = ShipType.Destroyer;
                    break;

                case 1:
                    result = ShipType.Submarine;
                    break;

                case 2:
                    result = ShipType.Cruiser;
                    break;

                case 3:
                    result = ShipType.Battleship;
                    break;

                default:
                    result = ShipType.Carrier;
                    break;
            }

            return result;
        }


       

    }
}
