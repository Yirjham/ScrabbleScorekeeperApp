using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class frmWelcomeWindow : Form
    {
        public frmWelcomeWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (rbtnTwoPlayers.Checked == true)
            {
                PlayersNamesWindowTwoPlayers form = new PlayersNamesWindowTwoPlayers();
                form.Show();
            }
            else if (rbtmThreePlayers.Checked == true)
            {
                PlayersNamesWindowsThreePlayers form = new PlayersNamesWindowsThreePlayers();
                form.Show();
            }
            else if (rbtnFourPlayers.Checked == true)
            {
                PlayerNamesWindowFourPlayers form = new PlayerNamesWindowFourPlayers();
                form.Show();
            }

        }
    }
}
