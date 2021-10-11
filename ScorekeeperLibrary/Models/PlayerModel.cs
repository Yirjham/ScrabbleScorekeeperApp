using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary.Models
{
    public class PlayerModel
    {
        public string PlayerName { get; set; }
        private int _currentScore;

        public int MyProperty
        {
            get { return _currentScore; }
            set
            {
                if (value < 0 || value > 130)
                {
                    throw new ArgumentOutOfRangeException("_currentScore", _currentScore, "Invalid current score value");
                }
                _currentScore = value; 
            }
        }

        public int CurrentScore { get; set; } = 0;
        public int Subtotal { get; set; } = 0;
    }
}
