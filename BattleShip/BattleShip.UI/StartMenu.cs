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

        public string Execute(int userNum)
        {
            //display menu, accept user input, assign player1 & player2 names
            string player="";

            DisplayMenu(userNum);
            player = Console.ReadLine();

            Console.Clear();
            return player;
        }


        private void DisplayMenu(int num)
        {
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine("\n===================\n");
            Console.WriteLine("Please {0} enter your name", num );

        }

       

     
    }
}
