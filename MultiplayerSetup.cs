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
    public partial class MultiplayerSetup : Form
    {
        MultiplayerPlay frmPlay = new MultiplayerPlay();

        public MultiplayerSetup()
        {
            InitializeComponent();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtPlayer1.Text=="")
            {
                MessageBox.Show("Please enter a name for Player 1.", "Error");
            }
            else if(txtPlayer2.Text=="")
            {
                MessageBox.Show("Please enter a name for Player 2.", "Error");

            }
            else if(txtPlayer1.Text==txtPlayer2.Text)
            {
                MessageBox.Show("Player names cannot be identical.", "Error");
            }
            else
            {
                frmPlay.setPlayer1(txtPlayer1.Text);
                frmPlay.setPlayer2(txtPlayer2.Text);
                frmPlay.setTargetScore(Convert.ToInt32(numTxtTargetScore.Text));
                this.Hide();
                frmPlay.ShowDialog();
                this.Show();
            }
        }
    }
}
