using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.UI.Workflow
{
    public class PlayerMoves
    {
        public string GetPlayersUserName(int playersTurn, string playerOneUserName, string playerTwoUserName)
        {
            string playersUserName;
            if (playersTurn == 1)
                playersUserName = playerOneUserName;
            else
                playersUserName = playerTwoUserName;

            return playersUserName;
            
        }

        public string RequestPlayerMove(int playersTurn, string playerUsername)
        {
            string userInput = "";
            int validNum = -1;

            while (validNum < 0 || validNum > 10)
            {            
                Console.WriteLine("{0}, please enter the space you would like to select", playerUsername);
                userInput = Console.ReadLine();
                bool isAValidNum = int.TryParse(userInput, out validNum);
                if (isAValidNum)
                    validNum = int.Parse(userInput);
            }

            return userInput;
        }

        public string GetPlayersMarker(int playersTurn)
        {
            string playersMarker = "";
            if (playersTurn == 1)
                playersMarker = "X";
            else
                playersMarker = "O";

            return playersMarker;

        }
    }
}
