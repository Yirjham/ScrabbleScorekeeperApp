using ScorekeeperLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.RoundForms;

namespace WinFormsUI
{
    public static class GameHelper
    {
        public static void InitialiseFourPlayerForm(GameModel game)
        {
            RoundFormsFourPlayers roundForm = new RoundFormsFourPlayers(game);
            roundForm.Show();
        }
        public static void InitialiseThreePlayerForm(GameModel game)
        {
            RoundFormsThreePlayers roundForm = new RoundFormsThreePlayers(game);
            roundForm.Show();
        }
        public static void InitialiseTwoPlayerForm(GameModel game)
        {
            RoundFormsTwoPlayers roundForm = new RoundFormsTwoPlayers(game);
            roundForm.Show();
        }
    }
}
