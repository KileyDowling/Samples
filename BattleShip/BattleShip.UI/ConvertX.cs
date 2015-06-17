using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using BattleShip.BLL.Requests;
using BattleShip.UI.Models;
using BattleShip.UI.Workflow;

namespace BattleShip.UI
{
    class ConvertX
    {
        public static Coordinate AcceptUserCoordinate(PlayerInfo playerInfo, GameBoard gameBoard)
        {
            string coordinateRequested = Console.ReadLine();
            ConvertX convertX = new ConvertX();
            Coordinate aCoordinate = convertX.Conversion(gameBoard.BoardDictionary, coordinateRequested);

            return aCoordinate;
            

        }

        public Coordinate Conversion(Dictionary<string, Coordinate> userDictionary, string userInput)
        {
            string upperCaseFirst = userInput.Substring(0, 1).ToUpper();
            userInput = upperCaseFirst + userInput.Remove(0, 1);
            Coordinate coordinate = userDictionary[userInput];
           
            return coordinate;
        }

    }
}
