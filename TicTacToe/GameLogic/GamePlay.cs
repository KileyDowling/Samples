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
        public int WonOrTie(int playersTurn, string marker1, string marker2)
        {
            bool wonAcross = WonAcross(playersTurn, marker1, marker2);
            bool wonUpAndDown = WonUpAndDown(playersTurn, marker1, marker2);
            bool wonDiagonal = WonDiagonal(playersTurn, marker1, marker2);
            bool itIsATie = IsItATie(marker1, marker2);
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

        public bool KeepPlaying(int playersTurn, string marker1, string marker2)
        {
            bool result = false;

            result = WonAcross(playersTurn, marker1, marker2);
            if (!result)
            {
                result = WonUpAndDown(playersTurn, marker1, marker2);
                if (!result)
                {
                    result = WonDiagonal(playersTurn, marker1, marker2);
                    if (!result)
                    {
                        result = IsItATie(marker1, marker2);
                    }
                }

            }
            return result;
        }

        public bool WonAcross(int playersTurn, string marker1, string marker2)
        {
            bool result = false;
            int num = 0;
            int counter = 0;
            string playersMarker = "";
            if (playersTurn == 1)
                playersMarker = "X";
            else
                playersMarker = "O";


            while (counter < 3)
            {
                for (int i = counter; i < counter + 1; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (GameBoard.gameBoard[i, j] == playersMarker)
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

        public bool WonUpAndDown(int playersTurn, string marker1, string marker2)
        {
            bool result = false;
            int num = 0;
            int counter = 0;
            string playersMarker = "";
            if (playersTurn == 1)
                playersMarker = "X";
            else
                playersMarker = "O";

            //won up & down
            while (counter < 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = counter; j < counter + 1; j++)
                    {
                        if (GameBoard.gameBoard[i, j] == playersMarker)
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

        public bool WonDiagonal(int playersTurn, string marker1, string marker2)
        {
            bool result = false;
            int num = 0;

            string playersMarker = "";
            if (playersTurn == 1)
                playersMarker = "X";
            else
                playersMarker = "O";

            if (GameBoard.gameBoard[0, 2] == playersMarker && GameBoard.gameBoard[2, 0] == playersMarker && GameBoard.gameBoard[1, 1] == playersMarker)
                num += 3;

            else if (GameBoard.gameBoard[0, 0] == playersMarker && GameBoard.gameBoard[2, 2] == playersMarker && GameBoard.gameBoard[1, 1] == playersMarker)
                num += 3;


            if (num == 3)
            {
                result = true;
            }
            return result;
        }

        public bool IsItATie(string marker1, string marker2)
        {
            bool result = false;
            int num = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (GameBoard.gameBoard[i, j] == marker1 || GameBoard.gameBoard[i, j] == marker2)
                        num += 1;
                }
                if (num > 8)
                {
                    result = true;
                }
            }
            return result;
        }

        public int NextPlayersTurn(int lastPlayersTurn)
        {
            int result;
            if (lastPlayersTurn == 1)
                result = 2;
            else
                result = 1;

            return result;

        }
    }
}
