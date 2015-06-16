using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Ships;
using BattleShip.UI.Models;

namespace BattleShip.UI.Workflow
{
    public class ShipSetUp
    {

        public PlaceShipRequest SetUpShip(Dictionary<string, Coordinate> userDictionary)
        {
            
                string coordinateRequested = "";
                string shipDirectionRequest = "";
                int shipDirAsNum = 0;

                //get X & Y
                Console.WriteLine("Please enter your X & Y coordinate(Ex: A1)");
                coordinateRequested = Console.ReadLine();

                //get ship direction
                Console.WriteLine("Please enter your ship direction (up=0,down=1,left=2,right=3)");
                shipDirectionRequest = Console.ReadLine();
                shipDirAsNum = int.Parse(shipDirectionRequest);
                ShipDirection shipDirection = SetShipDirection(shipDirAsNum);

                //get coordinate
                ConvertX convertX = new ConvertX();
                ;
                Coordinate aCoordinate = convertX.Conversion(userDictionary, coordinateRequested);


                //get ship type
                Console.WriteLine(
                    "Please choose a ship type (Destroyer=0, Sumbmarine=1, Cruiser=2, Battleship=3, Carrier=4)");
                string shipTypeRequest = Console.ReadLine();
                int shiptTypeAsNum = int.Parse(shipTypeRequest);
                ShipType shipType = SetShipType(shiptTypeAsNum);


                //place ship
            PlaceShipRequest placeShips = new PlaceShipRequest
            {
                Coordinate = aCoordinate,
                Direction = shipDirection,
                ShipType = shipType
            };
                
                return placeShips;

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
                    result=ShipDirection.Right;
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


        public int NextTurn(int userTurn)
        {
            int result = 0;

            if (userTurn == 1)
            {
                result = 2;
            }
            else
            {
                result = 1;
            }
            return result;
        }


    }
}
