﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperUniversalLibrary.Models
{
    public class PlayerModel
    {
        public PlayerModel(string name)
        {
            PlayerName = name;
        }
        public string PlayerName { get; set; }
        public int RoundScore { get; set; } = 0;
        public int ScoreSubtotal { get; set; } = 0;
        public int TotalScore { get; private set; }

        public void UpdateRoundSubtotal()
        {
            ScoreSubtotal = ScoreSubtotal + RoundScore;
            RoundScore = 0;
        }
        public void UpdateFinalScore()
        {
            UpdateRoundSubtotal();
            TotalScore = ScoreSubtotal;
        }
    }
}
