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

        public bool UpdateGameBoard(string userSelection, int playersTurn)
        {
            string playersMarker = "";
            if(playersTurn==1)
                playersMarker = "X";
            else
                   playersMarker = "O";

            bool foundChoice=false;
                
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_gameBoard[i, j] == userSelection)
                    {
                        _gameBoard[i, j] = playersMarker;
                        foundChoice = true;
                    }
                }
            }    
            DisplayGameBoard();
            if(!foundChoice)
                Console.WriteLine("Invalid choice, please try again. ");


            return foundChoice;
            

        }

        public string RequestPlayerMove(int playersTurn,string playerUsername)
        {
            string userInput = "";
            int validNum = -1;

            while (validNum < 0 || validNum > 10)
            {
                Console.WriteLine("{0}, please enter the space you would like to select", playerUsername);
                userInput = Console.ReadLine();
                validNum = int.Parse(userInput);
            }

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

        public string GetUserInfo(int playersTurn)
        {
            string userName = "";

            Console.Write("Please enter the name for player {0}: ", playersTurn);
            userName = Console.ReadLine();
            return userName;
        }

        public bool WonOrTie(int playersTurn, string playersUsername)
        {
            bool result = false;
            bool wonOrTie=false;

            wonOrTie = IsItATie();
            if (!wonOrTie)
            {
                result = WonDiagonal(playersTurn, playersUsername);
                if (!result)
                {
                    result = WonAcross(playersTurn, playersUsername);
                }
            }
            return result;
        }

        public bool WonAcross(int playersTurn,string playersUsername)
        {
            bool result = false;
            int num = 0;
            int counter = 0;
            string playersMarker = GetPlayersMarker(playersTurn);
            while (counter < 3)
            {
                for (int i = counter; i < counter + 1; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (_gameBoard[i, j] == playersMarker)
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
                        if (_gameBoard[i, j] == playersMarker)
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
            string playersMarker = GetPlayersMarker(playersTurn);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_gameBoard[i, j] == playersMarker && i == j)
                    {
                        num += 1;

                        if (num == 3)
                        {
                            result = true;
                            Console.WriteLine("Congrats {0}! You won diagonally", playersUsername);
                        }
                    }

                }
            }
            if(!result)
            {
                num = 0;
            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 3; l++)
                {

                    if (_gameBoard[k, l] == playersMarker)
                    {
                        if (k == 0 && l == 2)
                            num += 1;
                        if (k == 2 && l == 0)
                                num += 2;

                        if (num == 3)
                            { 
                            result = true;
                            Console.WriteLine("Congrats {0}! You won diagonally", playersUsername);
                            }
                       
                    }
                }
               }
            }
            return result;
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
