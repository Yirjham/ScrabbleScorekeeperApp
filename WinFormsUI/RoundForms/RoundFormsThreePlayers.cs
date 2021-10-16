using ScorekeeperLibrary;
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
    public partial class RoundFormsThreePlayers : Form
    {
        GameModel game;
        PlayerModel player1;
        PlayerModel player2;
        PlayerModel player3;

        public RoundFormsThreePlayers(GameModel currentGame)
        {
            game = currentGame;
            player1 = game.Players[0];
            player2 = game.Players[1];
            player3 = game.Players[2];

            InitializeComponent();

            lblPlayer1Name.Text = player1.PlayerName;
            lblPlayer2Name.Text = player2.PlayerName;
            lblPlayer3Name.Text = player3.PlayerName;

            game.TotalRounds = 0;
            lblCurrentRoundNumber.Text = game.TotalRounds.ToString();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (DataValidation.IsUserEntryEmpty(txtScorePlayer1.Text, txtScorePlayer2.Text, txtScorePlayer3.Text) == true)
            {
                MessageBox.Show("Empty entry. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataValidation.isValidNumber(txtScorePlayer1.Text, txtScorePlayer2.Text, txtScorePlayer3.Text) == false)
            {
                MessageBox.Show("Invalid entry. Please try whole numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataValidation.isValidRange(txtScorePlayer1.Text, txtScorePlayer2.Text, txtScorePlayer3.Text) == false)
            {
                MessageBox.Show("Invalid range. Please try whole numbers between 0 and 130", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateScoresAllPlayers(game, this);
            }
        }

        private void btnFinishGame_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Are you sure you want to finish the game?", "Scrabble Scorekeeper",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (button == DialogResult.Yes)
            {
                if (Calculations.isThereAWinner(game.Players[0].ScoreSubtotal, game.Players[1].ScoreSubtotal, game.Players[2].ScoreSubtotal))
                {
                    game.GameWinner = Calculations.DeterminesWinner(player1, player2, player3);

                    MessageBox.Show(ScorekeeperLibrary.Models.UIMessages.GameWinnerMessage(game, player1, player2, player3), "WINNER!!!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"After { game.TotalRounds } rounds there is no winner as the top score is shared by two or more players.");
                } 
            }
        }
        private static void UpdateScoresAllPlayers(GameModel game, RoundFormsThreePlayers form)
        {
            PlayerModel player1 = game.Players[0];
            PlayerModel player2 = game.Players[1];
            PlayerModel player3 = game.Players[2];

            player1.RoundScore = int.Parse(form.txtScorePlayer1.Text);
            player2.RoundScore = int.Parse(form.txtScorePlayer2.Text);
            player3.RoundScore = int.Parse(form.txtScorePlayer3.Text);

            player1.UpdateRoundSubtotal();
            player2.UpdateRoundSubtotal();
            player3.UpdateRoundSubtotal();

            form.txtSubtotalPlayer1.Text = player1.ScoreSubtotal.ToString();
            form.txtSubtotalPlayer2.Text = player2.ScoreSubtotal.ToString();
            form.txtSubtotalPlayer3.Text = player3.ScoreSubtotal.ToString();

            game.TotalRounds++;
            form.lblCurrentRoundNumber.Text = game.TotalRounds.ToString();

            form.txtScorePlayer1.Clear();
            form.txtScorePlayer2.Clear();
            form.txtScorePlayer3.Clear();

            form.txtScorePlayer1.Focus();
        }
    }
}
