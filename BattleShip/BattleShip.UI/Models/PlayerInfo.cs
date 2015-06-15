using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.UI.Workflow;

namespace BattleShip.UI.Models
{
    public class PlayerInfo
    {

        public string UserName { get; set; }
        public int UserTurn { get; set; }
        public Board MyBoard { get; set; }
    }
}
