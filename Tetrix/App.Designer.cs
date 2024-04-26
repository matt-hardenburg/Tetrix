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
            changeModeBox = new ComboBox();
            exitBtn = new Button();
            highScoreBtn = new Button();
            startGameBtn = new Button();
            titleLabel = new Label();
            highScoreTitle = new Label();
            highScoreReturnBtn = new Button();
            highScorePanel = new Panel();
            highScoresLabel = new Label();
            gamePanel = new Panel();
            gameExitButton = new Button();
            scoreValueLabel = new Label();
            scoreLabel = new Label();
            timerValueLabel = new Label();
            timerLabel = new Label();
            boardPanel = new Panel();
            mainMenuPanel.SuspendLayout();
            highScorePanel.SuspendLayout();
            gamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuPanel
            // 
            mainMenuPanel.Controls.Add(changeModeBox);
            mainMenuPanel.Controls.Add(exitBtn);
            mainMenuPanel.Controls.Add(highScoreBtn);
            mainMenuPanel.Controls.Add(startGameBtn);
            mainMenuPanel.Controls.Add(titleLabel);
            mainMenuPanel.Location = new Point(73, 24);
            mainMenuPanel.Name = "mainMenuPanel";
            mainMenuPanel.Size = new Size(494, 365);
            mainMenuPanel.TabIndex = 0;
            // 
            // changeModeBox
            // 
            changeModeBox.FormattingEnabled = true;
            changeModeBox.Location = new Point(174, 141);
            changeModeBox.Name = "changeModeBox";
            changeModeBox.Size = new Size(151, 28);
            changeModeBox.TabIndex = 5;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(206, 255);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // highScoreBtn
            // 
            highScoreBtn.Location = new Point(192, 192);
            highScoreBtn.Name = "highScoreBtn";
            highScoreBtn.Size = new Size(121, 29);
            highScoreBtn.TabIndex = 3;
            highScoreBtn.Text = "High Scores";
            highScoreBtn.UseVisualStyleBackColor = true;
            highScoreBtn.Click += highScoreBtn_Click;
            // 
            // startGameBtn
            // 
            startGameBtn.Location = new Point(206, 81);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(94, 29);
            startGameBtn.TabIndex = 1;
            startGameBtn.Text = "Start Game";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += startGameBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(233, 39);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(45, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Tetrix";
            // 
            // highScoreTitle
            // 
            highScoreTitle.AutoSize = true;
            highScoreTitle.Location = new Point(279, 23);
            highScoreTitle.Name = "highScoreTitle";
            highScoreTitle.Size = new Size(88, 20);
            highScoreTitle.TabIndex = 0;
            highScoreTitle.Text = "High Scores";
            // 
            // highScoreReturnBtn
            // 
            highScoreReturnBtn.Location = new Point(279, 356);
            highScoreReturnBtn.Name = "highScoreReturnBtn";
            highScoreReturnBtn.Size = new Size(94, 29);
            highScoreReturnBtn.TabIndex = 2;
            highScoreReturnBtn.Text = "Main Menu";
            highScoreReturnBtn.UseVisualStyleBackColor = true;
            highScoreReturnBtn.Click += highScoreReturnBtn_Click;
            // 
            // highScorePanel
            // 
            highScorePanel.Controls.Add(highScoreTitle);
            highScorePanel.Controls.Add(highScoresLabel);
            highScorePanel.Controls.Add(highScoreReturnBtn);
            highScorePanel.Location = new Point(66, 20);
            highScorePanel.Name = "highScorePanel";
            highScorePanel.Size = new Size(663, 416);
            highScorePanel.TabIndex = 1;
            // 
            // highScoresLabel
            // 
            highScoresLabel.AutoSize = true;
            highScoresLabel.Location = new Point(306, 100);
            highScoresLabel.Name = "highScoresLabel";
            highScoresLabel.Size = new Size(0, 20);
            highScoresLabel.TabIndex = 1;
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(gameExitButton);
            gamePanel.Controls.Add(scoreValueLabel);
            gamePanel.Controls.Add(scoreLabel);
            gamePanel.Controls.Add(timerValueLabel);
            gamePanel.Controls.Add(timerLabel);
            gamePanel.Controls.Add(boardPanel);
            gamePanel.Location = new Point(-1, 0);
            gamePanel.Margin = new Padding(3, 4, 3, 4);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(803, 444);
            gamePanel.TabIndex = 1;
            gamePanel.Visible = false;
            // 
            // gameExitButton
            // 
            gameExitButton.Location = new Point(752, 4);
            gameExitButton.Margin = new Padding(3, 4, 3, 4);
            gameExitButton.Name = "gameExitButton";
            gameExitButton.Size = new Size(48, 31);
            gameExitButton.TabIndex = 6;
            gameExitButton.Text = "Exit";
            gameExitButton.UseVisualStyleBackColor = true;
            gameExitButton.Visible = false;
            gameExitButton.Click += gameExitButton_Click;
            // 
            // scoreValueLabel
            // 
            scoreValueLabel.AutoSize = true;
            scoreValueLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreValueLabel.Location = new Point(66, 205);
            scoreValueLabel.Name = "scoreValueLabel";
            scoreValueLabel.Size = new Size(0, 37);
            scoreValueLabel.TabIndex = 5;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(66, 165);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(82, 37);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "Score";
            // 
            // timerValueLabel
            // 
            timerValueLabel.AutoSize = true;
            timerValueLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerValueLabel.Location = new Point(640, 205);
            timerValueLabel.Name = "timerValueLabel";
            timerValueLabel.Size = new Size(0, 37);
            timerValueLabel.TabIndex = 3;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(640, 165);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(92, 37);
            timerLabel.TabIndex = 2;
            timerLabel.Text = "Timer";
            // 
            // boardPanel
            // 
            boardPanel.BorderStyle = BorderStyle.FixedSingle;
            boardPanel.Location = new Point(234, 48);
            boardPanel.Margin = new Padding(3, 4, 3, 4);
            boardPanel.Name = "boardPanel";
            boardPanel.Size = new Size(313, 361);
            boardPanel.TabIndex = 1;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(highScorePanel);
            Controls.Add(mainMenuPanel);
            Controls.Add(gamePanel);
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
    }
}
