using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary.Models
{
    public class RoundModel
    {
        public List<PlayerModel> Players { get; set; }
        public int RoundNumber { get; set; }
        public PlayerModel RoundWinner { get; set; }
        public PlayerModel currentWinner { get; set; }
    }
}
