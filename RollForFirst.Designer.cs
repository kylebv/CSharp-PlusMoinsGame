namespace INFT2012_PlusMoins
{
    partial class RollForFirst
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.btnRollPlayer1 = new System.Windows.Forms.Button();
            this.btnRollPlayer2 = new System.Windows.Forms.Button();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.pbxDice1 = new System.Windows.Forms.PictureBox();
            this.pbxDice2 = new System.Windows.Forms.PictureBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Let\'s roll some dice to see who goes first. The player with the highest roll gets" +
    " to go first.";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(12, 43);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player1";
            // 
            // btnRollPlayer1
            // 
            this.btnRollPlayer1.Location = new System.Drawing.Point(12, 72);
            this.btnRollPlayer1.Name = "btnRollPlayer1";
            this.btnRollPlayer1.Size = new System.Drawing.Size(75, 23);
            this.btnRollPlayer1.TabIndex = 2;
            this.btnRollPlayer1.Text = "Roll";
            this.btnRollPlayer1.UseVisualStyleBackColor = true;
            this.btnRollPlayer1.Click += new System.EventHandler(this.btnRollPlayer1_Click);
            // 
            // btnRollPlayer2
            // 
            this.btnRollPlayer2.Enabled = false;
            this.btnRollPlayer2.Location = new System.Drawing.Point(354, 72);
            this.btnRollPlayer2.Name = "btnRollPlayer2";
            this.btnRollPlayer2.Size = new System.Drawing.Size(75, 23);
            this.btnRollPlayer2.TabIndex = 4;
            this.btnRollPlayer2.Text = "Roll";
            this.btnRollPlayer2.UseVisualStyleBackColor = true;
            this.btnRollPlayer2.Click += new System.EventHandler(this.btnRollPlayer2_Click);
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Enabled = false;
            this.lblPlayer2.Location = new System.Drawing.Point(387, 43);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player1";
            // 
            // pbxDice1
            // 
            this.pbxDice1.Location = new System.Drawing.Point(12, 128);
            this.pbxDice1.Name = "pbxDice1";
            this.pbxDice1.Size = new System.Drawing.Size(185, 90);
            this.pbxDice1.TabIndex = 5;
            this.pbxDice1.TabStop = false;
            // 
            // pbxDice2
            // 
            this.pbxDice2.Location = new System.Drawing.Point(249, 128);
            this.pbxDice2.Name = "pbxDice2";
            this.pbxDice2.Size = new System.Drawing.Size(185, 90);
            this.pbxDice2.TabIndex = 6;
            this.pbxDice2.TabStop = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(108, 69);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(222, 24);
            this.lblWinner.TabIndex = 7;
            this.lblWinner.Text = "Player 1 wins the dice roll";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWinner.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(184, 231);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // RollForFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 268);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.pbxDice2);
            this.Controls.Add(this.pbxDice1);
            this.Controls.Add(this.btnRollPlayer2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.btnRollPlayer1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.label1);
            this.Name = "RollForFirst";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlusMoins - Roll for First";
            this.Load += new System.EventHandler(this.RollForFirst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Button btnRollPlayer1;
        private System.Windows.Forms.Button btnRollPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.PictureBox pbxDice2;
        public System.Windows.Forms.PictureBox pbxDice1;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnOK;
    }
}