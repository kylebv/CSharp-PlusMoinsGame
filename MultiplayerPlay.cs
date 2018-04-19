using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFT2012_PlusMoins
{
    public partial class MultiplayerPlay : Form
    {
        String player1, player2;
        int player1Score, player2Score, targetScore,currentScore,firstToPlay;
        RollForFirst frmRollForFirst = new RollForFirst();

        public MultiplayerPlay()
        {
            InitializeComponent();
            player1Score = 0;
            player2Score = 0;
        }

        public void setPlayer1(String player1)
        {
            this.player1 = player1;
        }

        public void setPlayer2(String player2)
        {
            this.player2 = player2;
        }

        private void MultiplayerPlay_Load(object sender, EventArgs e)
        {
            frmRollForFirst.setPlayer1(player1);
            frmRollForFirst.setPlayer2(player2);
            this.Hide();
            frmRollForFirst.ShowDialog();
            firstToPlay = frmRollForFirst.getFirst();
            this.Show();
            if (firstToPlay == null) { this.Close(); }
        }

        public String getPlayer1()
        {
            return player1;
        }

        public String getPlayer2()
        {
            return player2;
        }

        public void setTargetScore(int targetScore)
        {
            this.targetScore = targetScore;
        }
    }
}
