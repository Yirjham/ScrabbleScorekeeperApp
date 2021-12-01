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
    public partial class RoundFormsFourPlayers : Form, IForm
    {
        private GameModel game;
        private PlayerModel _player1;
        private PlayerModel _player2;
        private PlayerModel _player3;
        private PlayerModel _player4;
        private readonly Crud _crud;
        private List<PlayerMapperModel> _players;
        private List<string> _playersNames;
        private readonly DataAccessHelper _dataAccessHelper;

        public RoundFormsFourPlayers(GameModel currentGame)
        {
            _crud = new Crud(DataAccessHelper.GetConnectionString());
            _dataAccessHelper = new DataAccessHelper(_crud);
            _players = _crud.LoadAllPlayers();
            _playersNames = _players.Select(p => p.Name).ToList();

            game = currentGame;
            _player1 = game.Players[0];
            _player2 = game.Players[1];
            _player3 = game.Players[2];
            _player4 = game.Players[3];

            InitializeComponent();

            lblPlayer1Name.Text = _player1.PlayerName;
            lblPlayer2Name.Text = _player2.PlayerName;
            lblPlayer3Name.Text = _player3.PlayerName;
            lblPlayer4Name.Text = _player4.PlayerName;

            game.TotalRounds = 0;
            lblCurrentRoundNumber.Text = game.TotalRounds.ToString();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (DataValidation.IsUserEntryEmpty(txtScorePlayer1.Text, txtScorePlayer2.Text, txtScorePlayer3.Text, txtScorePlayer4.Text) == true)
            {
                MessageBox.Show("Empty entry. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataValidation.isValidNumber(txtScorePlayer1.Text, txtScorePlayer2.Text, txtScorePlayer3.Text, txtScorePlayer4.Text) == false)
            {
                MessageBox.Show("Invalid entry. Please try whole numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DataValidation.isValidRange(txtScorePlayer1.Text, txtScorePlayer2.Text, txtScorePlayer3.Text, txtScorePlayer4.Text) == false)
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
                PlayerModel loser3 = null;

                if (Calculations.IsThereAWinner(game.Players[0].ScoreSubtotal, game.Players[1].ScoreSubtotal, game.Players[2].ScoreSubtotal, game.Players[3].ScoreSubtotal))
                {
                    game.GameWinner = Calculations.DeterminesWinner(_player1,_player2, _player3, _player4);
                    game.GameWinner.UpdateFinalScore();

                    loser1 = Calculations.ReturnsLosers(_player1, _player2, _player3, _player4)[0];
                    loser2 = Calculations.ReturnsLosers(_player1, _player2, _player3, _player4)[1];
                    loser3 = Calculations.ReturnsLosers(_player1, _player2, _player3, _player4)[2];

                    loser1.UpdateFinalScore();
                    loser2.UpdateFinalScore();
                    loser3.UpdateFinalScore();

                    MessageBox.Show(ScorekeeperLibrary.Models.UIMessages.GameWinnerMessage(game, _player1, _player2, _player3, _player4), "WINNER!!!", MessageBoxButtons.OK);

                    // New section to adapt, code originally from RoundFormsTwoPlayers


                    //Checks if the winner is already in the DB or not
                    if (DataAccessHelper.PlayerAlreadyInDB(_playersNames, game.GameWinner) == true)
                    {
                        _dataAccessHelper.UpdateExistingPlayerData(_playersNames, game.GameWinner, game);
                    }
                    else
                    {

                        _dataAccessHelper.AddNewPlayerToDb(game.GameWinner, true);

                    }

                    //Checks if loser1 is already in the DB or not
                    if ((DataAccessHelper.PlayerAlreadyInDB(_playersNames, loser1) == true))
                    {
                        _dataAccessHelper.UpdateExistingPlayerData(_playersNames, loser1, game);
                    }
                    else
                    {
                        _dataAccessHelper.AddNewPlayerToDb(loser1, false);
                    }

                    //Checks if loser2 is already in the DB or not
                    if ((DataAccessHelper.PlayerAlreadyInDB(_playersNames, loser2) == true))
                    {
                        _dataAccessHelper.UpdateExistingPlayerData(_playersNames, loser2, game);
                    }
                    else
                    {
                        _dataAccessHelper.AddNewPlayerToDb(loser2, false);
                    }

                    //Checks if loser3 is already in the DB or not
                    if ((DataAccessHelper.PlayerAlreadyInDB(_playersNames, loser3) == true))
                    {
                        _dataAccessHelper.UpdateExistingPlayerData(_playersNames, loser3, game);
                    }
                    else
                    {
                        _dataAccessHelper.AddNewPlayerToDb(loser3, false);
                    }
                }
                // No winner, players in a tie
                else
                {
                    MessageBox.Show($"After { game.TotalRounds } rounds there is no winner as the top score is shared by two or more players.");

                    // New code to adapt, code originally from RoundFormsTwoPlayers

                    _player1.UpdateFinalScore();
                    _player2.UpdateFinalScore();
                    _player3.UpdateFinalScore();
                    _player4.UpdateFinalScore();

                    //If player1 exists in DB update details
                    if (DataAccessHelper.PlayerAlreadyInDB(_playersNames, _player1) == true)
                    {
                        PlayerMapperModel player1Mapper = _crud.ReadPlayer(_player1.PlayerName);
                        player1Mapper.GamesPlayed++;
                        Calculations.UpdatePlayerHighestScore(_player1, player1Mapper);
                        _crud.UpdatePlayerData(player1Mapper.Id, player1Mapper);
                    }
                    else // if not add player1 to DB
                    {
                        _dataAccessHelper.AddNewPlayerToDb(_player1, false);
                    }

                    //If player2 exists in DB update details
                    if (DataAccessHelper.PlayerAlreadyInDB(_playersNames, _player2) == true)
                    {
                        PlayerMapperModel player2Mapper = _crud.ReadPlayer(_player2.PlayerName);
                        player2Mapper.GamesPlayed++;
                        Calculations.UpdatePlayerHighestScore(_player2, player2Mapper);
                        _crud.UpdatePlayerData(player2Mapper.Id, player2Mapper);
                    }
                    else // if not add player2 to DB
                    {
                        _dataAccessHelper.AddNewPlayerToDb(_player2, false);
                    }

                    //If player3 exists in DB update details
                    if (DataAccessHelper.PlayerAlreadyInDB(_playersNames, _player3) == true)
                    {
                        PlayerMapperModel player3Mapper = _crud.ReadPlayer(_player3.PlayerName);
                        player3Mapper.GamesPlayed++;
                        Calculations.UpdatePlayerHighestScore(_player3, player3Mapper);
                        _crud.UpdatePlayerData(player3Mapper.Id, player3Mapper);
                    }
                    else // if not add player3 to DB
                    {
                        _dataAccessHelper.AddNewPlayerToDb(_player3, false);
                    }

                    //If player4 exists in DB update details
                    if (DataAccessHelper.PlayerAlreadyInDB(_playersNames, _player4) == true)
                    {
                        PlayerMapperModel player4Mapper = _crud.ReadPlayer(_player4.PlayerName);
                        player4Mapper.GamesPlayed++;
                        Calculations.UpdatePlayerHighestScore(_player3, player4Mapper);
                        _crud.UpdatePlayerData(player4Mapper.Id, player4Mapper);
                    }
                    else // if not add player4 to DB
                    {
                        _dataAccessHelper.AddNewPlayerToDb(_player4, false);
                    }
                }

                this.Close();
            }
        }

        public void UpdatePlayersRoundScores()
        {
            _player1.RoundScore = int.Parse(txtScorePlayer1.Text);
            _player2.RoundScore = int.Parse(txtScorePlayer2.Text);
            _player3.RoundScore = int.Parse(txtScorePlayer3.Text);
            _player4.RoundScore = int.Parse(txtScorePlayer4.Text);
        }

        public void UpdateDisplayedSubtotals()
        {
            txtSubtotalPlayer1.Text = _player1.ScoreSubtotal.ToString();
            txtSubtotalPlayer2.Text = _player2.ScoreSubtotal.ToString();
            txtSubtotalPlayer3.Text = _player3.ScoreSubtotal.ToString();
            txtSubtotalPlayer4.Text = _player4.ScoreSubtotal.ToString();
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
            txtScorePlayer4.Clear();
        }
    }
}
