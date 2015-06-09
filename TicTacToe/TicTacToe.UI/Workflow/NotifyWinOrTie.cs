using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic;

namespace TicTacToe.UI
{
    public static class NotifyWinOrTie
    {
        public static string Notify(int winOrTie, string userName)
        {
            string wonAcross = "Congrats " + userName + "! You won across!";
            string wonUpAndDown = "Congrats " + userName + "! You won up and down!";
            string wonDiagonal = "Congrats " + userName + "! You won diagnonally!";
            string itIsATie = "It's a tie!";
            string result = "";

            switch (winOrTie)
            {
                case 1:
                    result = wonAcross;
                    break;
                case 2:
                    result = wonUpAndDown;
                    break;
                case 3:
                    result = wonDiagonal;
                    break;
                case 4:
                    result = itIsATie;
                    break;
                default:
                    result = "IDK WHAT IS HAPPENING";
                    break;
            }

            return result;

        }

    }
}
