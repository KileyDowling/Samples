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
                                Console.Write("H ");
                                break;
                            case ShotHistory.Miss:
                                Console.Write("M ");
                                break;
                            default:
                                Console.Write("U ");
                                break;

                        }
                    }
                    else
                    {
                        Console.Write(" U ");
                    }
                    
                }
                Console.Write("\n");
            }
        }

        public void PlayTheGame(PlayerInfo playerInfo, GameBoard gameBoard)
        {
            Console.WriteLine("\n\t--- PLAYER {0}'s TURN ---", NextTurn(playerInfo.UserTurn));

            //get X & Y
            Console.WriteLine("\n**Currently Displaying Player {0}'s Board**\n", playerInfo.UserTurn);
            DisplayBoardDuringGamePlay(playerInfo);

            Console.Write("\nPlayer {0}, Please enter the X & Y coordinate you would like to hit(Ex: A1): ", NextTurn(playerInfo.UserTurn));
            FireShotResponse response = playerInfo.MyBoard.FireShot(ConvertX.AcceptUserCoordinate(playerInfo, gameBoard));

            if (response.ShotStatus != ShotStatus.Hit || response.ShotStatus != ShotStatus.HitAndSunk)
            {
                Console.WriteLine("Sorry, you did not hit anything");
            }
            
        }

        public int NextTurn(int playersTurn)
        {
            int result = 0;

            if (playersTurn == 1)
                 result = 2;
            else
                 result = 1;
            return result;
        }

    }
}
