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
    public partial class frmMainMenu : Form
    {
        Instructions frmInstructions = new Instructions();
        MultiplayerSetup frmMultiplayerSetup = new MultiplayerSetup();
        public frmMainMenu()
        {
            InitializeComponent();
        }

        public Boolean isSequenceOfFive(int die1, int die2, int die3, int die4, int die5)
        {
            int[] dice = { die1, die2, die3, die4, die5 };
            sortDice(ref dice);
            return dice[1] == dice[0] + 1 && dice[2] == dice[1] + 1 && dice[3] == dice[2] + 1 && dice[4] == dice[3] + 1;

        }

        public Boolean isSequenceOfFour(int die1, int die2, int die3, int die4, int die5)
        {
            int[] dice = { die1, die2, die3, die4, die5 };
            sortDice(ref dice);
            int seqMax=0, seqCount=1;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i + 1] == dice[i] + 1) { seqCount++; }
                else { seqMax = seqCount; seqCount = 1; }
                if (i == 4 && seqCount > seqMax) { seqMax = seqCount; }
            }
            return seqMax == 4;
        }

        public Boolean isSequenceOfThree(int die1, int die2, int die3, int die4, int die5)
        {
            int[] dice = { die1, die2, die3, die4, die5 };
            sortDice(ref dice);
            int seqMax = 0, seqCount = 1;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i + 1] == dice[i] + 1) { seqCount++; }
                else { seqMax = seqCount; seqCount = 1; }
                if (i == 4 && seqCount > seqMax) { seqMax = seqCount; }
            }
            return seqMax == 3;
        }

        public Boolean isEven(int die1, int die2, int die3, int die4, int die5)
        {
            return (die1 + die2 + die3 + die4 + die5) % 2 == 0;
        }

        public Boolean isFiveOfAKind(int die1, int die2, int die3, int die4, int die5)
        {
            int[] dice = { die1, die2, die3, die4, die5 };
            sortDice(ref dice);
            return dice[1] == dice[0] && dice[2] == dice[1] && dice[3] == dice[2] && dice[4] == dice[3];

        }

        public Boolean isFourOfAKind(int die1, int die2, int die3, int die4, int die5)
        {
            int[] dice = { die1, die2, die3, die4, die5 };
            sortDice(ref dice);
            int countMax = 0, count = 1;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i + 1] == dice[i]) { count++; }
                else { countMax = count; count = 1; }
                if (i == 4 && count > countMax) { countMax = count; }
            }
            return countMax == 4;
        }

        public Boolean isThreeOfAKind(int die1, int die2, int die3, int die4, int die5)
        {
            int[] dice = { die1, die2, die3, die4, die5 };
            sortDice(ref dice);
            int countMax = 0, count = 1;
            for (int i = 0; i < 5; i++)
            {
                if (dice[i + 1] == dice[i]) { count++; }
                else { countMax = count; count = 1; }
                if (i == 4 && count > countMax) { countMax = count; }
            }
            return countMax == 3;
        }

        public void sortDice(ref int[] dice)
        {
            for(int i=0;i<5;i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(dice[j]>dice[j+1])
                    {
                        int temp = dice[j];
                        dice[j] = dice[j + 1];
                        dice[j + 1] = temp;
                    }
                }
            }
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {

        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInstructions.ShowDialog();
            this.Show();
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMultiplayerSetup.ShowDialog();
            this.Show();
            
        }
    }
}
