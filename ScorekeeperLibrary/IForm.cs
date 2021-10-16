using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary
{
    public interface IForm
    {
        void UpdatePlayersRoundScores();
        void UpdateDisplayedSubtotals();
        void UpdateDisplayedCurrentRound();
        void ClearDisplayedScores();
    }
}
