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
    public partial class RoundFormsTwoPlayers : Form, IForm
    {
        GameModel game;
        PlayerModel player1;
        PlayerModel player2;
        private Crud _sqlDb;
        private List<PlayerMapperModel> _players;
        private List<string> _playersNames;

        public RoundFormsTwoPlayers(GameModel currentGame)
        {
            _sqlDb = new Crud(DataAccessHelper.GetConnectionString());
            _players = _sqlDb.LoadAllPlayers();
            _playersNames = _players.Select(p => p.Name).ToList();

            game = currentGame;
            player1 = game.Players[0];
            player2 = game.Players[1];

            InitializeComponent();

            lblPlayer1Name.Text = player1.PlayerName;
            lblPlayer2Name.Text = player2.PlayerName;

            game.TotalRounds = 0;
            lblCurrentRoundNumber.Text = game.TotalRounds.ToString();
        }
        // The event below has conditional statements for validating the users' data entries. Updates the subtotal scores if data is valid
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (DataValidation.IsUserEntryEmpty(txtScorePlayer1.Text, txtScorePlayer2.Text) == true)
            {
                MessageBox.Show("Empty entry. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataValidation.isValidNumber(txtScorePlayer1.Text, txtScorePlayer2.Text) == false)
            {
                MessageBox.Show("Invalid entry. Please try whole numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataValidation.isValidRange(txtScorePlayer1.Text, txtScorePlayer2.Text) == false)
            {
                MessageBox.Show("Invalid range. Please try whole numbers between 0 and 130", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Calculations.UpdateScoresAllPlayers(game, this);
                txtScorePlayer1.Focus();
            }
        }
        // The event below processes what happens if the user wants to finish the game
        private void btnFinishGame_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Are you sure you want to finish the game?", "Scrabble Scorekeeper", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (button == DialogResult.Yes)
            {
                PlayerModel loser = null; 
                
                if (Calculations.IsThereAWinner(game.Players[0].ScoreSubtotal, game.Players[1].ScoreSubtotal))
                {
                    game.GameWinner = Calculations.DeterminesWinner(player1, player2);
                    game.GameWinner.UpdateFinalScore();

                    MessageBox.Show(ScorekeeperLibrary.Models.UIMessages.GameWinnerMessage(game, player1, player2), "WINNER!!!", MessageBoxButtons.OK);
                }
                // itsATieScore its the final score of either player1 or player2
                else
                {
                    int itsATieScore = player1.ScoreSubtotal;
                    MessageBox.Show($"After { game.TotalRounds } rounds there is no winner as { player1.PlayerName } and { player2.PlayerName } both scored { itsATieScore } points.");
                }

                // New code for assigning a loser and hence updating details
                loser = Calculations.ReturnsLowestScorer(player1, player2);

                if (Calculations.IsThereAWinner(player1.TotalScore, player2.TotalScore) == true)
                {
                    // All the code below
                }
              

                // New code for updating the database with data from new game 
                if (DataAccessHelper.PlayerAlreadyInDB(_playersNames, game.GameWinner))
                {
                    //Load player by name
                    PlayerMapperModel winnerMapper = _sqlDb.ReadPlayer(game.GameWinner.PlayerName);

                    // check if score is higher and add one to games played and won
                    if (winnerMapper != null)
                    {
                        winnerMapper.GamesPlayed++;
                        winnerMapper.GamesWon++;

                        if (game.GameWinner.TotalScore > winnerMapper.HighestScore)
                        {
                            winnerMapper.HighestScore = game.GameWinner.TotalScore;
                        }

                    }

                    // update the database 
                    _sqlDb.UpdatePlayerData(winnerMapper.Id, winnerMapper);
                }
                else if (DataAccessHelper.PlayerAlreadyInDB(_playersNames, loser))
                {
                    //Load player by name
                    PlayerMapperModel notWinnerMapper = _sqlDb.ReadPlayer(loser.PlayerName);

                    // check if score is higher
                    if (notWinnerMapper != null)
                    {
                        notWinnerMapper.GamesPlayed++;

                        if (loser.TotalScore > notWinnerMapper.HighestScore)
                        {
                            notWinnerMapper.HighestScore = loser.TotalScore;
                        }

                    }

                    // update the database by adding one to games played and update score if highest than recorded
                    _sqlDb.UpdatePlayerData(notWinnerMapper.Id, notWinnerMapper);
                }
                
                // no winner, hence players null
                if(Calculations.IsThereAWinner(player1.TotalScore, player2.TotalScore) == false)
                {
                    PlayerMapperModel winnerMapper = _sqlDb.ReadPlayer(game.GameWinner.PlayerName);
                    PlayerMapperModel notWinnerMapper = _sqlDb.ReadPlayer(loser.PlayerName);

                    if (winnerMapper != null || notWinnerMapper != null)
                    {
                        winnerMapper.GamesPlayed++;
                        notWinnerMapper.GamesPlayed++;
                    }

                    _sqlDb.UpdatePlayerData(winnerMapper.Id, winnerMapper);
                    _sqlDb.UpdatePlayerData(notWinnerMapper.Id, notWinnerMapper);

                }

            }
        }
        public void UpdatePlayersRoundScores()
        {
            player1.RoundScore = int.Parse(txtScorePlayer1.Text);
            player2.RoundScore = int.Parse(txtScorePlayer2.Text);
        }
        public void UpdateDisplayedSubtotals()
        {
            txtSubtotalPlayer1.Text = player1.ScoreSubtotal.ToString();
            txtSubtotalPlayer2.Text = player2.ScoreSubtotal.ToString();
        }

        public void UpdateDisplayedCurrentRound()
        {
            lblCurrentRoundNumber.Text = game.TotalRounds.ToString();
        }

        public void ClearDisplayedScores()
        {
            txtScorePlayer1.Clear();
            txtScorePlayer2.Clear();
        }
    }
}
