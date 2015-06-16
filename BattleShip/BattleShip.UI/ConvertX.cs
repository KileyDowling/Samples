using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using BattleShip.BLL.Requests;

namespace BattleShip.UI
{
    class ConvertX
    {

        public Coordinate Conversion(Dictionary<string, Coordinate> userDictionary, string userInput)
        {
            
            Coordinate coordinate = userDictionary[userInput.ToUpper()];
           
            return coordinate;
        }

    }
}
