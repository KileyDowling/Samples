using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class GamePlay
    {
        private string[,] _gameBoard = new string[3, 3] { { "1", "2", "3", }, { "4", "5", "6" }, { "7", "8", "9" } };

        public void UpdateGameBoard(string userSelection)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_gameBoard[i, j] == userSelection)
                    {
                        _gameBoard[i, j] = "X";
                    }
                }
            }
            DisplayGameBoard();

        }

        public string RequestPlayerMove()
        {
            string userInput = "";

            Console.WriteLine("Please enter the space you would like to select");
            userInput = Console.ReadLine();

            return userInput;
        }

        public void DisplayGameBoard()
        {
            int num = 0;
            Console.WriteLine("\n");
            while (num < 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (_gameBoard[num, i] == "3" || _gameBoard[num, i] == "6" || _gameBoard[num, i] == "9")
                    {
                        Console.Write("{0}", _gameBoard[num, i]);
                    }
                    else
                    {
                        Console.Write("{0}  |  ", _gameBoard[num, i]);
                    }

                }
                if (num != 2)
                {
                    Console.WriteLine("\n--------------\n   |     |");
                }
                else
                {
                    Console.WriteLine("\n\n");
                }
                num += 1;
            }

        }

        public void GetUserInfo()
        {
            string playerOne = "";
            string playerTwo = "";

            Console.Write("Please enter the name for player one: ");
            playerOne = Console.ReadLine();


            Console.Write("Please enter the name for player two: ");
            playerTwo = Console.ReadLine();

            Console.WriteLine("Welcome {0} and {1}! Let's play!", playerOne, playerTwo);

        }

        public bool WonOrTie()
        {
            bool result = false;
            int num = 0;
            result = IsItATie();

            return result;


        }

        public bool WonAcrossOrDiagonal()
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
                        if (_gameBoard[i, j] == "X")
                        {
                            num += 1;
                            if (num > 2)
                            {
                                result = true;
                                Console.WriteLine("Congrats you won across!");
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
                        if (_gameBoard[i, j] == "X")
                        {
                            num += 1;
                            if (num > 2)
                            {
                                result = true;
                                Console.WriteLine("Congrats you won up & down");
                            }
                        }
                    }

                }
                counter += 1;
                num = 0;
            }



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_gameBoard[i, j] == "X" && i == j)
                    {
                        num += 1;

                        if (num == 3)
                        {
                            result = true;
                            Console.WriteLine("Congrats you won diagonal");
                        }
                    }

                    else if (_gameBoard[i, j] == "X")
                    {
                        if (i == 2 && j == 0)
                            num += 1;
                        if (i == 0 && j == 2)
                            num += 1;

                        if (num == 3)
                        {
                            result = true;
                            Console.WriteLine("Congrats you won diagonal");
                        }
                    }
                }
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
                    if (_gameBoard[i, j] == "X" || _gameBoard[i, j] == "O")
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
    }
}
