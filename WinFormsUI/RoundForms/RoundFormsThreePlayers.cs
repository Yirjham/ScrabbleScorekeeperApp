using DataAccessLibrary;
using DataAccessLibrary.Models;
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
    public partial class RoundFormsThreePlayers : Form, IForm
    {
        GameModel game;
        private PlayerModel _player1;
        private PlayerModel _player2;
        private PlayerModel _player3;
        private readonly Crud _crud;
        private List<PlayerMapperModel> _players;
        private List<string> _playersNames; 
        private readonly DataAccessHelper _dataAccessHelper;

        public RoundFormsThreePlayers(GameModel currentGame)
        {
            _crud = new Crud(DataAccessHelper.GetConnectionString());
            _dataAccessHelper = new DataAccessHelper(_crud);
            _players = _crud.LoadAllPlayers();
            _playersNames = _players.Select(p => p.Name).ToList();

            game = currentGame;
            _player1 = game.Players[0];
            _player2 = game.Players[1];
            _player3 = game.Players[2];

            InitializeComponent();

            lblPlayer1Name.Text = _player1.PlayerName;
            lblPlayer2Name.Text = _player2.PlayerName;
            lblPlayer3Name.Text = _player3.PlayerName;

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
                Calculations.UpdateScoresAllPlayers(game, this);
                txtScorePlayer1.Focus();
            }
        }

        private void btnFinishGame_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Are you sure you want to finish the game?", "Scrabble Scorekeeper",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (button == DialogResult.Yes)
            {
                PlayerModel loser1 = null;
                PlayerModel loser2 = null;

                if (Calculations.IsThereAWinner(game.Players[0].ScoreSubtotal, game.Players[1].ScoreSubtotal, game.Players[2].ScoreSubtotal))
                {
                    game.GameWinner = Calculations.DeterminesWinner(_player1, _player2, _player3);
                    game.GameWinner.UpdateFinalScore();

                    MessageBox.Show(ScorekeeperLibrary.Models.UIMessages.GameWinnerMessage(game, _player1, _player2, _player3), 
                        "WINNER!!!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"After { game.TotalRounds } rounds there is no winner as the top score is shared by two or more players.");
                } 
            }
        }

        public void UpdatePlayersRoundScores()
        {
            _player1.RoundScore = int.Parse(txtScorePlayer1.Text);
            _player2.RoundScore = int.Parse(txtScorePlayer2.Text);
            _player3.RoundScore = int.Parse(txtScorePlayer3.Text);
        }

        public void UpdateDisplayedSubtotals()
        {
            txtSubtotalPlayer1.Text = _player1.ScoreSubtotal.ToString();
            txtSubtotalPlayer2.Text = _player2.ScoreSubtotal.ToString();
            txtSubtotalPlayer3.Text = _player3.ScoreSubtotal.ToString();
        }

        public void UpdateDisplayedCurrentRound()
        {
            lblCurrentRoundNumber.Text = game.TotalRounds.ToString();
        }

        public void ClearDisplayedScores()
        {
            txtScorePlayer1.Clear();
            txtScorePlayer2.Clear();
            txtScorePlayer3.Clear();
        }
    }
}
