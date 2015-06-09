using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    class ConvertX
    {
        private string[] arr = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};

        public int Conversion(string XCoordinate)
        {
            int result = -1;
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == XCoordinate)
                {
                    result = i + 1;
                }
            }
            return result;
        }



    }
}
