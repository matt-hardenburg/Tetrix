namespace Tetrix
{
    partial class App
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
            mainMenuPanel = new Panel();
            exitBtn = new Button();
            highScoreBtn = new Button();
            startGameBtn = new Button();
            titleLabel = new Label();
            changeModeBox = new ComboBox();
            highScorePanel = new Panel();
            highScoresLabel = new Label();
            highScoreReturnBtn = new Button();
            highScoreTitle = new Label();
            gamePanel = new Panel();
            gameExitButton = new Button();
            scoreValueLabel = new Label();
            scoreLabel = new Label();
            timerValueLabel = new Label();
            timerLabel = new Label();
            boardPanel = new Panel();
            returnToMainMenuButton = new Button();
            gameOverLabel = new Label();
            mainMenuPanel.SuspendLayout();
            highScorePanel.SuspendLayout();
            gamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuPanel
            // 
            mainMenuPanel.Controls.Add(exitBtn);
            mainMenuPanel.Controls.Add(highScoreBtn);
            mainMenuPanel.Controls.Add(startGameBtn);
            mainMenuPanel.Controls.Add(titleLabel);
            mainMenuPanel.Controls.Add(changeModeBox);
            mainMenuPanel.Location = new Point(64, 24);
            mainMenuPanel.Margin = new Padding(3, 2, 3, 2);
            mainMenuPanel.Name = "mainMenuPanel";
            mainMenuPanel.Size = new Size(565, 365);
            mainMenuPanel.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(258, 189);
            exitBtn.Margin = new Padding(3, 2, 3, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(82, 22);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // highScoreBtn
            // 
            highScoreBtn.Location = new Point(246, 141);
            highScoreBtn.Margin = new Padding(3, 2, 3, 2);
            highScoreBtn.Name = "highScoreBtn";
            highScoreBtn.Size = new Size(106, 22);
            highScoreBtn.TabIndex = 3;
            highScoreBtn.Text = "High Scores";
            highScoreBtn.UseVisualStyleBackColor = true;
            highScoreBtn.Click += highScoreBtn_Click;
            // 
            // startGameBtn
            // 
            startGameBtn.Location = new Point(258, 58);
            startGameBtn.Margin = new Padding(3, 2, 3, 2);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(82, 22);
            startGameBtn.TabIndex = 1;
            startGameBtn.Text = "Start Game";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += startGameBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(282, 26);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(35, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Tetrix";
            // 
            // changeModeBox
            // 
            changeModeBox.FormattingEnabled = true;
            changeModeBox.Location = new Point(230, 103);
            changeModeBox.Margin = new Padding(3, 2, 3, 2);
            changeModeBox.Name = "changeModeBox";
            changeModeBox.Size = new Size(133, 23);
            changeModeBox.TabIndex = 5;
            // 
            // highScorePanel
            // 
            highScorePanel.Controls.Add(highScoresLabel);
            highScorePanel.Controls.Add(highScoreReturnBtn);
            highScorePanel.Controls.Add(highScoreTitle);
            highScorePanel.Location = new Point(58, 20);
            highScorePanel.Margin = new Padding(3, 2, 3, 2);
            highScorePanel.Name = "highScorePanel";
            highScorePanel.Size = new Size(671, 416);
            highScorePanel.TabIndex = 1;
            // 
            // highScoresLabel
            // 
            highScoresLabel.AutoSize = true;
            highScoresLabel.Location = new Point(268, 75);
            highScoresLabel.Name = "highScoresLabel";
            highScoresLabel.Size = new Size(0, 15);
            highScoresLabel.TabIndex = 1;
            // 
            // highScoreReturnBtn
            // 
            highScoreReturnBtn.Location = new Point(244, 267);
            highScoreReturnBtn.Margin = new Padding(3, 2, 3, 2);
            highScoreReturnBtn.Name = "highScoreReturnBtn";
            highScoreReturnBtn.Size = new Size(82, 22);
            highScoreReturnBtn.TabIndex = 2;
            highScoreReturnBtn.Text = "Main Menu";
            highScoreReturnBtn.UseVisualStyleBackColor = true;
            highScoreReturnBtn.Click += highScoreReturnBtn_Click;
            // 
            // highScoreTitle
            // 
            highScoreTitle.AutoSize = true;
            highScoreTitle.Location = new Point(230, 23);
            highScoreTitle.Name = "highScoreTitle";
            highScoreTitle.Size = new Size(70, 15);
            highScoreTitle.TabIndex = 0;
            highScoreTitle.Text = "High Scores";
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(mainMenuPanel);
            gamePanel.Controls.Add(highScorePanel);
            gamePanel.Controls.Add(gameExitButton);
            gamePanel.Controls.Add(scoreValueLabel);
            gamePanel.Controls.Add(scoreLabel);
            gamePanel.Controls.Add(timerValueLabel);
            gamePanel.Controls.Add(timerLabel);
            gamePanel.Controls.Add(boardPanel);
            gamePanel.Controls.Add(returnToMainMenuButton);
            gamePanel.Controls.Add(gameOverLabel);
            gamePanel.Location = new Point(-1, 0);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(703, 333);
            gamePanel.TabIndex = 1;
            // 
            // gameExitButton
            // 
            gameExitButton.Location = new Point(658, 3);
            gameExitButton.Name = "gameExitButton";
            gameExitButton.Size = new Size(42, 23);
            gameExitButton.TabIndex = 6;
            gameExitButton.Text = "Exit";
            gameExitButton.UseVisualStyleBackColor = true;
            gameExitButton.Visible = false;
            gameExitButton.Click += gameExitButton_Click;
            // 
            // scoreValueLabel
            // 
            scoreValueLabel.AutoSize = true;
            scoreValueLabel.Font = new Font("Segoe UI", 15.75F);
            scoreValueLabel.Location = new Point(58, 154);
            scoreValueLabel.Name = "scoreValueLabel";
            scoreValueLabel.Size = new Size(0, 30);
            scoreValueLabel.TabIndex = 5;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(58, 124);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(70, 30);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "Score";
            // 
            // timerValueLabel
            // 
            timerValueLabel.AutoSize = true;
            timerValueLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerValueLabel.Location = new Point(560, 154);
            timerValueLabel.Name = "timerValueLabel";
            timerValueLabel.Size = new Size(0, 30);
            timerValueLabel.TabIndex = 3;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(560, 124);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(69, 30);
            timerLabel.TabIndex = 2;
            timerLabel.Text = "Timer";
            // 
            // boardPanel
            // 
            boardPanel.Location = new Point(211, 35);
            boardPanel.Name = "boardPanel";
            boardPanel.Size = new Size(274, 271);
            boardPanel.TabIndex = 1;
            // 
            // returnToMainMenuButton
            // 
            returnToMainMenuButton.Location = new Point(273, 181);
            returnToMainMenuButton.Name = "returnToMainMenuButton";
            returnToMainMenuButton.Size = new Size(154, 23);
            returnToMainMenuButton.TabIndex = 7;
            returnToMainMenuButton.Text = "Main Menu";
            returnToMainMenuButton.UseVisualStyleBackColor = true;
            returnToMainMenuButton.Click += returnToMainMenuButton_Click;
            // 
            // gameOverLabel
            // 
            gameOverLabel.AutoSize = true;
            gameOverLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameOverLabel.ForeColor = Color.Red;
            gameOverLabel.Location = new Point(273, 124);
            gameOverLabel.Name = "gameOverLabel";
            gameOverLabel.Size = new Size(154, 32);
            gameOverLabel.TabIndex = 3;
            gameOverLabel.Text = "GAME OVER";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(gamePanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "App";
            Text = "Tetrix";
            KeyDown += App_KeyDown;
            mainMenuPanel.ResumeLayout(false);
            mainMenuPanel.PerformLayout();
            highScorePanel.ResumeLayout(false);
            highScorePanel.PerformLayout();
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainMenuPanel;
        private Label titleLabel;
        private Button exitBtn;
        private Button highScoreBtn;
        private Button startGameBtn;
        private ComboBox changeModeBox;
        private Button highScoreReturnBtn;
        private Label highScoresLabel;
        private Label highScoreTitle;
        private Panel highScorePanel;
        private Panel gamePanel;
        private Panel boardPanel;
        private Label scoreLabel;
        private Label timerValueLabel;
        private Label timerLabel;
        private Label scoreValueLabel;
        private Button gameExitButton;
        private Label gameOverLabel;
        private Button returnToMainMenuButton;
    }
}
