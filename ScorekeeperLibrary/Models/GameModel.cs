﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary.Models
{
    public class GameModel
    {
        public List<PlayerModel> Players { get; set; }
        public int TotalRounds { get; set; }
        public PlayerModel GameWinner { get; set; }
        public PlayerModel currentWinner { get; set; }
    }
}
