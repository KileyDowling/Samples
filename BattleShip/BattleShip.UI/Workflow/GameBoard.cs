using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.UI.Models;

namespace BattleShip.UI.Workflow
{
    public class GameBoard
    {
        public Dictionary<string, Coordinate> BoardDictionary;

        public GameBoard()
        {
            BoardDictionary = SetupBoardDictionary();
        }

        public Dictionary<string,Coordinate> SetupBoardDictionary()
        {
            

            Dictionary<string, Coordinate> BoardDictionary = new Dictionary<string, Coordinate>();

            BoardDictionary.Add("A10", new Coordinate(1, 1));
            BoardDictionary.Add("B10", new Coordinate(2, 1));
            BoardDictionary.Add("C10", new Coordinate(3, 1));
            BoardDictionary.Add("D10", new Coordinate(4, 1));
            BoardDictionary.Add("E10", new Coordinate(5, 1));
            BoardDictionary.Add("F10", new Coordinate(6, 1));
            BoardDictionary.Add("G10", new Coordinate(7, 1));
            BoardDictionary.Add("H10", new Coordinate(8, 1));
            BoardDictionary.Add("I10", new Coordinate(9, 1));
            BoardDictionary.Add("J10", new Coordinate(10, 1));

            BoardDictionary.Add("A9", new Coordinate(1, 2));
            BoardDictionary.Add("B9", new Coordinate(2, 2));
            BoardDictionary.Add("C9", new Coordinate(3, 2));
            BoardDictionary.Add("D9", new Coordinate(4, 2));
            BoardDictionary.Add("E9", new Coordinate(5, 2));
            BoardDictionary.Add("F9", new Coordinate(6, 2));
            BoardDictionary.Add("G9", new Coordinate(7, 2));
            BoardDictionary.Add("H9", new Coordinate(8, 2));
            BoardDictionary.Add("I9", new Coordinate(9, 2));
            BoardDictionary.Add("J9", new Coordinate(10, 2));

            BoardDictionary.Add("A8", new Coordinate(1, 3));
            BoardDictionary.Add("B8", new Coordinate(2, 3));
            BoardDictionary.Add("C8", new Coordinate(3, 3));
            BoardDictionary.Add("D8", new Coordinate(4, 3));
            BoardDictionary.Add("E8", new Coordinate(5, 3));
            BoardDictionary.Add("F8", new Coordinate(6, 3));
            BoardDictionary.Add("G8", new Coordinate(7, 3));
            BoardDictionary.Add("H8", new Coordinate(8, 3));
            BoardDictionary.Add("I8", new Coordinate(9, 3));
            BoardDictionary.Add("J8", new Coordinate(10, 3));

            BoardDictionary.Add("A7", new Coordinate(1, 4));
            BoardDictionary.Add("B7", new Coordinate(2, 4));
            BoardDictionary.Add("C7", new Coordinate(3, 4));
            BoardDictionary.Add("D7", new Coordinate(4, 4));
            BoardDictionary.Add("E7", new Coordinate(5, 4));
            BoardDictionary.Add("F7", new Coordinate(6, 4));
            BoardDictionary.Add("G7", new Coordinate(7, 4));
            BoardDictionary.Add("H7", new Coordinate(8, 4));
            BoardDictionary.Add("I7", new Coordinate(9, 4));
            BoardDictionary.Add("J7", new Coordinate(10, 4));

            BoardDictionary.Add("A6", new Coordinate(1, 5));
            BoardDictionary.Add("B6", new Coordinate(2, 5));
            BoardDictionary.Add("C6", new Coordinate(3, 5));
            BoardDictionary.Add("D6", new Coordinate(4, 5));
            BoardDictionary.Add("E6", new Coordinate(5, 5));
            BoardDictionary.Add("F6", new Coordinate(6, 5));
            BoardDictionary.Add("G6", new Coordinate(7, 5));
            BoardDictionary.Add("H6", new Coordinate(8, 5));
            BoardDictionary.Add("I6", new Coordinate(9, 5));
            BoardDictionary.Add("J6", new Coordinate(10, 5));

            BoardDictionary.Add("A5", new Coordinate(1, 6));
            BoardDictionary.Add("B5", new Coordinate(2, 6));
            BoardDictionary.Add("C5", new Coordinate(3, 6));
            BoardDictionary.Add("D5", new Coordinate(4, 6));
            BoardDictionary.Add("E5", new Coordinate(5, 6));
            BoardDictionary.Add("F5", new Coordinate(6, 6));
            BoardDictionary.Add("G5", new Coordinate(7, 6));
            BoardDictionary.Add("H5", new Coordinate(8, 6));
            BoardDictionary.Add("I5", new Coordinate(9, 6));
            BoardDictionary.Add("J5", new Coordinate(10, 6));

            BoardDictionary.Add("A4", new Coordinate(1, 7));
            BoardDictionary.Add("B4", new Coordinate(2, 7));
            BoardDictionary.Add("C4", new Coordinate(3, 7));
            BoardDictionary.Add("D4", new Coordinate(4, 7));
            BoardDictionary.Add("E4", new Coordinate(5, 7));
            BoardDictionary.Add("F4", new Coordinate(6, 7));
            BoardDictionary.Add("G4", new Coordinate(7, 7));
            BoardDictionary.Add("H4", new Coordinate(8, 7));
            BoardDictionary.Add("I4", new Coordinate(9, 7));
            BoardDictionary.Add("J4", new Coordinate(10, 7));

            BoardDictionary.Add("A3", new Coordinate(1, 8));
            BoardDictionary.Add("B3", new Coordinate(2, 8));
            BoardDictionary.Add("C3", new Coordinate(3, 8));
            BoardDictionary.Add("D3", new Coordinate(4, 8));
            BoardDictionary.Add("E3", new Coordinate(5, 8));
            BoardDictionary.Add("F3", new Coordinate(6, 8));
            BoardDictionary.Add("G3", new Coordinate(7, 8));
            BoardDictionary.Add("H3", new Coordinate(8, 8));
            BoardDictionary.Add("I3", new Coordinate(9, 8));
            BoardDictionary.Add("J3", new Coordinate(10, 8));

            BoardDictionary.Add("A2", new Coordinate(1, 9));
            BoardDictionary.Add("B2", new Coordinate(2, 9));
            BoardDictionary.Add("C2", new Coordinate(3, 9));
            BoardDictionary.Add("D2", new Coordinate(4, 9));
            BoardDictionary.Add("E2", new Coordinate(5, 9));
            BoardDictionary.Add("F2", new Coordinate(6, 9));
            BoardDictionary.Add("G2", new Coordinate(7, 9));
            BoardDictionary.Add("H2", new Coordinate(8, 9));
            BoardDictionary.Add("I2", new Coordinate(9, 9));
            BoardDictionary.Add("J2", new Coordinate(10, 9));

            BoardDictionary.Add("A1", new Coordinate(1, 10));
            BoardDictionary.Add("B1", new Coordinate(2, 10));
            BoardDictionary.Add("C1", new Coordinate(3, 10));
            BoardDictionary.Add("D1", new Coordinate(4, 10));
            BoardDictionary.Add("E1", new Coordinate(5, 10));
            BoardDictionary.Add("F1", new Coordinate(6, 10));
            BoardDictionary.Add("G1", new Coordinate(7, 10));
            BoardDictionary.Add("H1", new Coordinate(8, 10));
            BoardDictionary.Add("I1", new Coordinate(9, 10));
            BoardDictionary.Add("J1", new Coordinate(10, 10));

            //end of method
            return BoardDictionary;
        }

        public void PrintGameBoard()
        {
            foreach (var key in BoardDictionary.Keys)
            {
                if (key.Length > 2)
                    Console.Write("{0} ", key);
                else
                {
                    Console.Write(" {0} ", key);

                }

                if (key.Substring(0, 1) == "J")
                {
                    Console.WriteLine();
                }

            }
            Console.WriteLine();
        }

    }
}
