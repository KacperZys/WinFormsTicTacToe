namespace WinFormsTest
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameTitle = new Label();
            turnLabel = new Label();
            displayPlayer = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            playerLabel = new Label();
            displayTurn = new Label();
            SuspendLayout();
            // 
            // gameTitle
            // 
            gameTitle.AutoSize = true;
            gameTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            gameTitle.Location = new Point(236, 33);
            gameTitle.Name = "gameTitle";
            gameTitle.Size = new Size(219, 40);
            gameTitle.TabIndex = 0;
            gameTitle.Text = "TicTacToe Game";
            // 
            // turnLabel
            // 
            turnLabel.AutoSize = true;
            turnLabel.Font = new Font("Segoe UI", 18F);
            turnLabel.Location = new Point(236, 91);
            turnLabel.Name = "turnLabel";
            turnLabel.Size = new Size(68, 32);
            turnLabel.TabIndex = 1;
            turnLabel.Text = "Turn:";
            // 
            // displayPlayer
            // 
            displayPlayer.AutoSize = true;
            displayPlayer.Font = new Font("Segoe UI", 18F);
            displayPlayer.Location = new Point(331, 136);
            displayPlayer.Name = "displayPlayer";
            displayPlayer.Size = new Size(0, 32);
            displayPlayer.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(218, 189);
            button1.Name = "button1";
            button1.Size = new Size(75, 70);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(312, 189);
            button2.Name = "button2";
            button2.Size = new Size(75, 70);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(410, 189);
            button3.Name = "button3";
            button3.Size = new Size(75, 70);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(218, 277);
            button4.Name = "button4";
            button4.Size = new Size(75, 70);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(312, 277);
            button5.Name = "button5";
            button5.Size = new Size(75, 70);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(410, 277);
            button6.Name = "button6";
            button6.Size = new Size(75, 70);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(218, 363);
            button7.Name = "button7";
            button7.Size = new Size(75, 70);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(312, 363);
            button8.Name = "button8";
            button8.Size = new Size(75, 70);
            button8.TabIndex = 10;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(410, 363);
            button9.Name = "button9";
            button9.Size = new Size(75, 70);
            button9.TabIndex = 11;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("Segoe UI", 18F);
            playerLabel.Location = new Point(236, 136);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(83, 32);
            playerLabel.TabIndex = 12;
            playerLabel.Text = "Player:";
            // 
            // displayTurn
            // 
            displayTurn.AutoSize = true;
            displayTurn.Font = new Font("Segoe UI", 18F);
            displayTurn.Location = new Point(331, 91);
            displayTurn.Name = "displayTurn";
            displayTurn.Size = new Size(0, 32);
            displayTurn.TabIndex = 13;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 661);
            Controls.Add(displayTurn);
            Controls.Add(playerLabel);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(displayPlayer);
            Controls.Add(turnLabel);
            Controls.Add(gameTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(350, 500);
            Name = "TicTacToe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameTitle;
        private Label turnLabel;
        private Label displayPlayer;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label playerLabel;
        private Label displayTurn;
    }
}
