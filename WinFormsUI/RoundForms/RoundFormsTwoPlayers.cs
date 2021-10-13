using ScorekeeperLibrary.DataValidation;
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

namespace WinFormsUI.RoundForms
{
    public partial class RoundFormsTwoPlayers : Form
    {
        GameModel game;
        public RoundFormsTwoPlayers(GameModel currentGame)
        {
            game = currentGame;
            InitializeComponent();
            lblPlayer1Name.Text = game.Players[0].PlayerName;
            lblPlayer2Name.Text = game.Players[1].PlayerName;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isValidEntryScoreP1 = DataValidation.isValidNumericData(txtScorePlayer1.Text);
            bool isValidEntryScoreP2 = DataValidation.isValidNumericData(txtScorePlayer2.Text);
            if (isValidEntryScoreP1 == true && isValidEntryScoreP2 == true)
            {
                game.Players[0].RoundScore = int.Parse(txtScorePlayer1.Text);
                game.Players[1].RoundScore = int.Parse(txtScorePlayer2.Text);

                game.Players[0].UpdateRoundSubtotal();
                game.Players[1].UpdateRoundSubtotal();

                txtSubtotalPlayer1.Text = game.Players[0].ScoreSubtotal.ToString();
                txtSubtotalPlayer2.Text = game.Players[1].ScoreSubtotal.ToString();
            }
            else
            {
                MessageBox.Show("Invalid entry. Please try again");
            }
        }
    }
}
