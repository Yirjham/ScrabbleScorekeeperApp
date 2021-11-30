using DataAccessLibrary;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Scoreboard : Form
    {
        private Crud _sqlDb;
        public Scoreboard()
        {
            InitializeComponent();
            _sqlDb = new Crud(DataAccessHelper.GetConnectionString());
        }
        private void Scoreboard_Load(object sender, EventArgs e)
        {
            DisplayPlayerScoarboard();
        }
        private void DisplayPlayerScoarboard()
        {
            scoreBoardGrid.Columns.Clear();
            var players = _sqlDb.LoadAllPlayers().OrderByDescending(s => s.HighestScore).ToList();


            scoreBoardGrid.DataSource = players;
            scoreBoardGrid.Columns.RemoveAt(0);
            scoreBoardGrid.AutoResizeColumns();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
