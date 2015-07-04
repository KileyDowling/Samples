using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Models;

namespace TicTacToe.UI.Workflow
{
    public class PlayerMoves
    {
        private int _playersTurn = 1;

        public UserInfo GetPlayersTurn(UserInfo userOne, UserInfo userTwo)
        {
            if (_playersTurn == 1)
            {
                _playersTurn = 2;
                return userOne;
            }
            else
            {
                _playersTurn = 1;
                return userTwo;
            }
        }

        public string RequestPlayerMove(UserInfo userInfo)
        {
            string userInput = "";
            int validNum = -1;

            while (validNum < 0 || validNum > 10)
            {
                Console.WriteLine("{0}, please enter the space you would like to select", userInfo.UserName);
                userInput = Console.ReadLine();
                bool isAValidNum = int.TryParse(userInput, out validNum);
                if (isAValidNum)
                    validNum = int.Parse(userInput);
            }

            return userInput;
        }

    }
}
