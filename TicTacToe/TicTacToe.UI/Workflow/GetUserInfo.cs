using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Models;

namespace TicTacToe.UI.Workflow
{
    public class GetUserInfo
    {
        private int _userTurn = 1;

        public UserInfo SetUpPlayer()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.UserTurn = _userTurn;

            userInfo.UserName = SetUserName(userInfo.UserTurn);
            userInfo.UserMarker = SetUserMarker(userInfo.UserTurn);

            nextTurn();
            return userInfo;
        }

        public void nextTurn()
        {
            if (_userTurn == 1)
                _userTurn = 2;
        }

        public string SetUserMarker(int userTurn)
        {
            string userMarker;
            if (userTurn == 1)
                userMarker = "X";
            else
                userMarker = "O";

            return userMarker;
        }

        public string SetUserName(int playersTurn)
        {
            string userName = "";

            do
            {
                Console.Write("Player {0}, please enter a username: ", playersTurn);
                userName = Console.ReadLine();
                if (!string.IsNullOrEmpty(userName))
                {
                    return userName;
                }
            } while (true);

        }
    }

}
