using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI.Workflow
{
    class GameBoard
    {
        //generic gameboard:
        int[,] _gameBoard = new int[10, 10];

        string[] letterArray = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        private int[] numArray = {1, 2, 3, 4, 5, 6, 7, 8, 9,10};

       
        //display gameboard
        public void PrintGameBoard(string userName)

        {
            Console.WriteLine(userName);

            for (int i = 0; i < 10; i++)
            {
              
                for (int j = 0; j < 10; j++)
                {
                    if (j == 0 && i < 10)
                    {
                        //labeling numbers on Y axis
                        if(i==0)
                            Console.Write(numArray[9 - i] + " | ");
                        else
                            Console.Write(" " +numArray[9-i] + " | ");
                    }                   
                    Console.Write(_gameBoard[i,j] + " ");
                    
                }
                Console.WriteLine();
            }

            for (int k = 0; k < 10; k++)
            {
                //labeling letters on X axis
                if(letterArray[k]=="A")
                    Console.Write("     " + letterArray[k]);
                else
                Console.Write(" " +letterArray[k]);

            }
            Console.WriteLine("\n");
        }


    }
}
