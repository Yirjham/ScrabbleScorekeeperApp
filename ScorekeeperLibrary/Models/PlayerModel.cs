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
        private int _roundScore = 0;
        private int _scoreSubtotal = 0;

        public int CurrentScore
        {
            get { return _roundScore; }
            set
            {
                if (value < 0 || value > 130)
                {
                    throw new ArgumentOutOfRangeException("_currentScore", _roundScore, "Invalid entry for current score value");
                }
                else
                {
                    _roundScore = value;  
                }
            }
        }
        public int ScoreSubTotal
        {
            get { return _scoreSubtotal; }
            private set
            {
                if (_roundScore < 0)
                {
                    throw new ArgumentOutOfRangeException("_scoreSubtotal", _scoreSubtotal, "Invalid current subtotal value");
                }
                else
                {
                    _scoreSubtotal = currentSubtotalCalculator(_roundScore, _scoreSubtotal);

                }
            }
        }
        private int currentSubtotalCalculator(int _roundScore, int _scoreSubtotal)
        {
            int output = _scoreSubtotal + _roundScore;

            return output;
        }

        
    }
}
