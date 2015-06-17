using BattleShip.BLL.GameLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.UI.Models;

namespace BattleShip.UI.Workflow
{
    class GamePlay
    {

        //gameboard dictionary is not used for display to user, we should be accessing the board (biz logic) shot history
        //so if there is no shot history, there needs to be a blank, have some type of grid placement marks.

        public void DisplayBoardDuringGamePlay(PlayerInfo playerInfo)
        {

            for (int x = 1; x < 11; x++)
            {
                for (int y = 1; y < 11; y++)
                {
                    var thisCoordinate = new Coordinate(x, y);
                    if (playerInfo.MyBoard.ShotHistory.ContainsKey(thisCoordinate))
                    {
                        var state = playerInfo.MyBoard.ShotHistory[thisCoordinate];
                        switch (state)
                        {
                            case ShotHistory.Hit:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("H ");
                                Console.ResetColor();
                                break;
                            case ShotHistory.Miss:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("M ");
                                Console.ResetColor();
                                break;
                            default:
                                Console.Write("U ");
                                break;

                        }
                    }
                    else
                    {
                        Console.Write("U ");
                    }

                }
                Console.Write("\n");
            }
        }

        public void PlayTheGame(PlayerInfo player1, PlayerInfo player2, GameBoard gameBoard)
        {

            FireShotResponse response = new FireShotResponse();
            int userTurn = 1;

            //sets to player2 to start
            PlayerInfo opponentsTurn = NextPlayersTurn(player1, player2, userTurn);
            PlayerInfo currentTurn = NextPlayersTurn(player1, player2, opponentsTurn.UserTurn);

            while (response.ShotStatus != ShotStatus.Victory)
            {
                //assigns currentTurn to player1
                Console.WriteLine("\n\t--- {0}'s TURN ---", currentTurn.UserName.ToUpper());

                //get X & Y
                Console.WriteLine("\n**Currently Displaying {0}'s Board**\n", opponentsTurn.UserName);

                DisplayBoardDuringGamePlay(opponentsTurn);

                Console.Write("\nPlayer {0}, Please enter the X & Y coordinate you would like to hit(Ex: A1): ",
                   currentTurn.UserName);

                response = opponentsTurn.MyBoard.FireShot(ConvertX.AcceptUserCoordinate(opponentsTurn, gameBoard));
                Responses(response);

                opponentsTurn = NextPlayersTurn(player1, player2, opponentsTurn.UserTurn);
                currentTurn = NextPlayersTurn(player1, player2, currentTurn.UserTurn);
                Console.WriteLine("It's now {0}'s turn. Press enter to continue", currentTurn.UserName);
                Console.ReadLine();
                Console.Clear();
            }
        }

        public PlayerInfo NextPlayersTurn(PlayerInfo player1, PlayerInfo player2, int userTurn)
        {
            if (userTurn == 1)
                return player2;
            else
                return player1;
        }


        public void Responses(FireShotResponse response)
        {
            switch (response.ShotStatus)
            {
                case ShotStatus.Victory:
                    Console.WriteLine("You win!");
                    break;

                case ShotStatus.HitAndSunk:
                    Console.WriteLine("{0} Hit & Sunk, Congrats", response.ShipImpacted);
                    break;

                case ShotStatus.Hit:
                    Console.WriteLine("{0} Hit, Congrats", response.ShipImpacted);
                    break;
                case ShotStatus.Duplicate:
                    Console.WriteLine("Duplicate shot try again");

                    break;
                case ShotStatus.Invalid:
                    Console.WriteLine("Invalid shot, try again");
                    break;
                default:
                    Console.WriteLine("Miss shot, sux2bu");
                    break;
            }


        }

    }
}
