using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Models;

namespace GameLogic
{
    public class GamePlay
    {
        public int WonOrTie(UserInfo userInfo)
        {
            bool wonAcross = WonAcross(userInfo);
            bool wonUpAndDown = WonUpAndDown(userInfo);
            bool wonDiagonal = WonDiagonal(userInfo);
            bool itIsATie = IsItATie();
            int result = 0;

            if (wonAcross)
                result = 1;
            else if (wonUpAndDown)
                result = 2;
            else if (wonDiagonal)
                result = 3;
            else if (itIsATie)
                result = 4;
            return result;

        }

        public bool KeepPlaying(UserInfo userInfo)
        {
            bool result = false;

            result = WonAcross(userInfo);
            if (!result)
            {
                result = WonUpAndDown(userInfo);
                if (!result)
                {
                    result = WonDiagonal(userInfo);
                    if (!result)
                    {
                        result = IsItATie();
                    }
                }

            }
            return result;
        }

        public bool WonAcross(UserInfo userInfo)
        {
            bool result = false;
            int num = 0;
            int counter = 0;

            while (counter < 3)
            {
                for (int i = counter; i < counter + 1; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (GameBoard.gameBoard[i, j] == userInfo.UserMarker)
                        {
                            num += 1;
                            if (num > 2)
                            {
                                result = true;
                            }
                        }
                    }

                }
                counter += 1;
                num = 0;
            }

            return result;
        }

        public bool WonUpAndDown(UserInfo userInfo)
        {
            bool result = false;
            int num = 0;
            int counter = 0;

            while (counter < 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = counter; j < counter + 1; j++)
                    {
                        if (GameBoard.gameBoard[i, j] == userInfo.UserMarker)
                        {
                            num += 1;
                            if (num > 2)
                            {
                                result = true;
                            }
                        }
                    }

                }
                counter += 1;
                num = 0;
            }

            return result;
        }

        public bool WonDiagonal(UserInfo userInfo)
        {
            bool result = false;
            int num = 0;

            if (GameBoard.gameBoard[0, 2] == userInfo.UserMarker && GameBoard.gameBoard[2, 0] == userInfo.UserMarker && GameBoard.gameBoard[1, 1] == userInfo.UserMarker)
                num += 3;

            else if (GameBoard.gameBoard[0, 0] == userInfo.UserMarker && GameBoard.gameBoard[2, 2] == userInfo.UserMarker && GameBoard.gameBoard[1, 1] == userInfo.UserMarker)
                num += 3;

            if (num == 3)
            {
                result = true;
            }
            return result;
        }

        public bool IsItATie()
        {
            bool result = false;
            int num = 0;
            int randomNum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!int.TryParse(GameBoard.gameBoard[i, j], out randomNum))
                        num += 1;
                }
                if (num > 8)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
