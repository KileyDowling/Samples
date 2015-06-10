using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;

namespace BattleShip.UI.Workflow
{
    public class GamePlay
    {

        public void SetupGame(int UserTurn)
        {
            //Setup Game logic
            ConvertX convertX = new ConvertX();
            PlaceShipRequest placeShips = new PlaceShipRequest();


            int x = 0;
            int y = 0;
            string userCoordinatesX = "";
            string userCoordinatesY = "";

            Console.WriteLine("Please enter your X (Ex: A)");
            userCoordinatesX = Console.ReadLine();
            x = convertX.Conversion(userCoordinatesX);

            Console.WriteLine("Please enter your Y coordinates (Ex: 1)");
            userCoordinatesY = Console.ReadLine();
            y = int.Parse(userCoordinatesY);

            placeShips.Coordinate.XCoordinate = x;
            placeShips.Coordinate.YCoordinate = y;
            
            //Next users turn setup

            NextTurn(UserTurn);





        }


        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public int NextTurn(int UserTurn)
        {
            int result = 0;

            if (UserTurn == 1)
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
