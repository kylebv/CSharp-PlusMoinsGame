using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; using NAudio.Wave;

namespace INFT2012_PlusMoins
{
    public partial class RollForFirst : Form
    {
        public String player1, player2;
        public int player1Roll, player2Roll,first;
        Random r = new Random();
        public RollForFirst()
        {
            InitializeComponent();
        }

        public void setPlayer1(String player1)
        {
            this.player1 = player1;
        }

        public void setPlayer2(String player2)
        {
            this.player2 = player2;
        }

        public int getFirst()
        {
            return first;
        }

        private void RollForFirst_Load(object sender, EventArgs e)
        {
            lblPlayer1.Text = player1;
            lblPlayer2.Text = player2;
            lblPlayer1.Enabled = true;
            lblPlayer2.Enabled = false;
            btnRollPlayer1.Enabled = true;
            btnRollPlayer2.Enabled = false;
            pbxDice1.Image = null;
            pbxDice2.Image = null;
            lblWinner.Visible = false;
            btnOK.Enabled = false;
        }

        private void btnRollPlayer2_Click(object sender, EventArgs e)
        {
            //WaveStream comes from the Naudio library, a .dll file I imported in order to reduce sound latency after button clicks
            WaveStream reader = new WaveFileReader("../../sounds/dice1.wav");
            var waveOut = new WaveOutEvent();
            waveOut.Init(reader);
            waveOut.Play();

            //the program sleeps for 600 milliseconds so that the sound file syncs up the sound of dice hitting the table with the
            //generation of the picture box dice
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);

            int die1 = roll();
            int die2 = roll();
            player2Roll = die1 + die2;

            instantiateDie(pbxDice2, 0, 0, 89, 89, die1);
            instantiateDie(pbxDice2, 94, 0, 184, 89, die2);

            lblPlayer2.Enabled = false;
            btnRollPlayer2.Enabled = false;
            lblWinner.Visible = true;

            if(player1Roll>player2Roll)
            {
                lblWinner.Text = player1 + " wins the dice roll";
                first = 1;
                btnOK.Enabled = true;
            }
            else if(player2Roll>player1Roll)
            {
                lblWinner.Text = player2 + " wins the dice roll";
                first = 2;
                btnOK.Enabled = true;
            }
            else
            {
                lblWinner.Text = "Tie, roll again";
                lblPlayer1.Enabled = true;
                btnRollPlayer1.Enabled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void instantiateDie(PictureBox pbx, int xOrigin, int yOrigin, int xDiagonal, int yDiagonal, int dieNumber)
        {
            //method takes a picture box and draws a die in it, with origin of xOrigin, yOrigin, and bottom right corner of xDiagonal, yDiagonal
            //die scales and stretches according to input (i.e. can be rectangular)

            //midway through designing this form, it was discovered that pressing the tab button would unexpectedly erase all picture box data on
            //the form. To make this data persistent, I had to draw within an image and use that image as the background image of the picture box
            Bitmap bmp = null;
            if (pbx.Image == null)
            {
                bmp = new Bitmap(pbx.Width, pbx.Height);
            }
            else
            {
                bmp = new Bitmap(pbx.Image);
            }
            Graphics g = Graphics.FromImage(bmp);

            int xWidth = xDiagonal - xOrigin;
            int yHeight = yDiagonal - yOrigin;
            int xSectioner = xWidth / 4;
            int ySectioner = yHeight / 4;
            int circleWidth = xWidth / 6;
            int circleHeight = yHeight / 6;

            g.DrawRectangle(new Pen(Color.Black), xOrigin, yOrigin, xWidth, yHeight);
            g.FillRectangle(Brushes.White, xOrigin+1, yOrigin+1, xWidth-2, yHeight-2);
            

            //if dienumber is 4, 5, or 6, draw the top left and bottom right dots of the die
            if (dieNumber >= 4) {
                g.FillEllipse(Brushes.Black, xOrigin + xSectioner-circleWidth/2, yOrigin + ySectioner-circleHeight/2, circleWidth, circleHeight);
                g.FillEllipse(Brushes.Black, xOrigin + 3 * xSectioner - circleWidth / 2, yOrigin + 3 * ySectioner - circleHeight / 2, circleWidth, circleHeight);
            }

            //if dienumber is 2, 3, 4, 5 or 6, draw the top right and bottom left dots of the die
            if (dieNumber >= 2) {
                g.FillEllipse(Brushes.Black, xOrigin + 3 * xSectioner - circleWidth / 2, yOrigin + ySectioner - circleHeight / 2, circleWidth, circleHeight);
                g.FillEllipse(Brushes.Black, xOrigin + xSectioner - circleWidth / 2, yOrigin + 3 * ySectioner - circleHeight / 2, circleWidth, circleHeight);
            }

            //if the dienumber is 6, draw the middle left and right dots of the die
            if (dieNumber == 6) {
                g.FillEllipse(Brushes.Black, xOrigin + xSectioner - circleWidth / 2, yOrigin + 2 * ySectioner - circleHeight / 2, circleWidth, circleHeight);
                g.FillEllipse(Brushes.Black, xOrigin + 3 * xSectioner - circleWidth / 2, yOrigin + 2 * ySectioner - circleHeight / 2, circleWidth, circleHeight);
            }
            //easy way to see if dienumber equals 1,3, or 5, then draws the centre dot of the die
            if (dieNumber % 2 == 1) { g.FillEllipse(Brushes.Black, xOrigin + 2 * xSectioner - circleWidth / 2, yOrigin + 2 * ySectioner - circleHeight / 2, circleWidth, circleHeight); }
            pbx.Image = bmp;
        }

        private void btnRollPlayer1_Click(object sender, EventArgs e)
        {
            pbxDice1.Image = null;
            pbxDice2.Image = null;
            lblWinner.Visible = false;
            WaveStream reader = new WaveFileReader("../../sounds/dice1.wav");
            var waveOut = new WaveOutEvent();
            waveOut.Init(reader);
            waveOut.Play();
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);
            int die1 = roll();
            int die2 = roll();
            player1Roll = die1 + die2;
            instantiateDie(pbxDice1, 0, 0, 89, 89, die1);
            instantiateDie(pbxDice1, 94, 0, 184, 89, die2);
            btnRollPlayer1.Enabled = false;
            lblPlayer1.Enabled = false;
            btnRollPlayer2.Enabled = true;
            lblPlayer2.Enabled = true;
        }

        public int roll()
        {
            return r.Next(1, 7);
        }
    }
}
