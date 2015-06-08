using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.UI.Workflow
{
    public class GetUserInfo
    {
        public static string RequestUser(int playersTurn)
        {
            string userName = "";

            Console.Write("Please enter the name for player {0}: ", playersTurn);
            userName = Console.ReadLine();
            return userName;
        }

    }

}
