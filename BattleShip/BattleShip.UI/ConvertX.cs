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
            
            Coordinate coordinate = userDictionary[userInput];
           
            return coordinate;
        }

        //Dictionary<string,int> convertToInt = new Dictionary<string, int>();

        
        //private string[] arr = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};

        //public int Conversion(string xCoordinate)
        //{
        //    //take in palyer letter (ex. "A"), convert to int
        //    int result = 0;

        //    CreateDictionary();
        //    result = convertToInt[xCoordinate];
            

        //    return result;
        //}

        //    //Creat Dictionary to assign letter[key] to number value.
        //public void CreateDictionary()
        //{
        //    for (int i = 1; i < 11; i++)
        //    {
        //            convertToInt.Add(arr[i - 1], i);
        //    }
        //}
    }
}
