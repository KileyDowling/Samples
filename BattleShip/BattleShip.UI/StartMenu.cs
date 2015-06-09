using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    public class StartMenu
    {
        //Create a start menu for the game, prompt for each player's name

        public void Execute()
        {
            //display menu, accept user input, assign player1 & player2 names
            string player1="";
            string player2="";

            DisplayMenu(1);
            player1 = Console.ReadLine();

            DisplayMenu(2);
            player2 = Console.ReadLine();


            //players
            Console.WriteLine("\n\n\nPlayer 1: {0}", player1);
            Console.WriteLine("Player 2: {0}", player2);

            Console.Clear();
        }


        private void DisplayMenu(int num)
        {
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine("\n===================\n");
            Console.WriteLine("Please {0} enter your name", num );



        }


    }
}
