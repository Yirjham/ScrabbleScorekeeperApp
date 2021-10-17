using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperUniversalLibrary.Models
{
    public class GameModel
    {
        public List<PlayerModel> Players { get; set; } = new List<PlayerModel>();
        public int TotalRounds { get; set; }
        public PlayerModel GameWinner { get; set; }
    }
}
