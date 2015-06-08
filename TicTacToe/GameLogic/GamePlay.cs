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

        public bool WonOrTie(int playersTurn, string playersUsername)
        {
            bool result = false;

            result = WonAcross(playersTurn,playersUsername);
            if (!result)
            {
                result = WonDiagonal(playersTurn, playersUsername);
                if (!result)
                {
                    result = IsItATie();
                }
            }
            return result;
        }

        public bool WonAcross(int playersTurn, string playersUsername)
        {
            bool result = false;
            int num = 0;
            int counter = 0;
            string playersMarker = playersTurn.ToString();
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
                                Console.WriteLine("Congrats {0}! You won across!", playersUsername);
                            }
                        }
                    }

                }
                counter += 1;
                num = 0;
            }


            counter = 0;
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
                                Console.WriteLine("Congrats {0}! You won up & down", playersUsername);
                            }
                        }
                    }

                }
                counter += 1;
                num = 0;
            }

            return result;
        }

        public bool WonDiagonal(int playersTurn, string playersUsername)
        {
            bool result = false;
            int num = 0;
            string playersMarker = playersTurn.ToString();


            if (GameBoard.gameBoard[0, 2] == playersMarker && GameBoard.gameBoard[2, 0] == playersMarker && GameBoard.gameBoard[1, 1] == playersMarker)
                num += 3;

            else if (GameBoard.gameBoard[0,0] == playersMarker && GameBoard.gameBoard[2, 2] == playersMarker && GameBoard.gameBoard[1, 1] == playersMarker)
                num += 3;


            if (num == 3)
            {
                result = true;
                Console.WriteLine("Congrats {0}! You won diagonally", playersUsername);
            }
            return result;
        }

        public bool IsItATie()
        {
            bool result = false;
            int num = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (GameBoard.gameBoard[i, j] == "X" || GameBoard.gameBoard[i, j] == "O")
                        num += 1;
                }
                if (num > 8)
                {
                    result = true;
                    Console.WriteLine("It's a tie!");
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
