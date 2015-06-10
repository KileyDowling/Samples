using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.UI.Workflow;

namespace BattleShip.UI.Models
{
    public class PlayerInfo
    {

        public string UserName { get; set; }
        public int UserTurn { get; set; }
        GameBoard UserBoard = new GameBoard();

        public GameBoard UserGameBoard
        {
            get { return UserBoard; }
            set { UserBoard = value; }
        }
        
    }
}
