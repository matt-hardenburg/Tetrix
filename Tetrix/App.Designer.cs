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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            mainMenuPanel = new Panel();
            tutorialButton = new Button();
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
            tutorialPanel = new Panel();
            tutorialMessage = new Label();
            returnFromTutorialBtn = new Button();
            tutorialLabel = new Label();
            mainMenuPanel.SuspendLayout();
            highScorePanel.SuspendLayout();
            gamePanel.SuspendLayout();
            tutorialPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuPanel
            // 
            mainMenuPanel.Controls.Add(tutorialButton);
            mainMenuPanel.Controls.Add(exitBtn);
            mainMenuPanel.Controls.Add(highScoreBtn);
            mainMenuPanel.Controls.Add(startGameBtn);
            mainMenuPanel.Controls.Add(titleLabel);
            mainMenuPanel.Controls.Add(changeModeBox);
            mainMenuPanel.Location = new Point(73, 32);
            mainMenuPanel.Name = "mainMenuPanel";
            mainMenuPanel.Size = new Size(646, 487);
            mainMenuPanel.TabIndex = 0;
            // 
            // tutorialButton
            // 
            tutorialButton.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tutorialButton.Location = new Point(264, 286);
            tutorialButton.Name = "tutorialButton";
            tutorialButton.Size = new Size(109, 29);
            tutorialButton.TabIndex = 6;
            tutorialButton.Text = "Tutorial";
            tutorialButton.UseVisualStyleBackColor = true;
            tutorialButton.Click += tutorialButton_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(273, 344);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // highScoreBtn
            // 
            highScoreBtn.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highScoreBtn.Location = new Point(248, 223);
            highScoreBtn.Name = "highScoreBtn";
            highScoreBtn.Size = new Size(141, 29);
            highScoreBtn.TabIndex = 3;
            highScoreBtn.Text = "High Scores";
            highScoreBtn.UseVisualStyleBackColor = true;
            highScoreBtn.Click += highScoreBtn_Click;
            // 
            // startGameBtn
            // 
            startGameBtn.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startGameBtn.Location = new Point(268, 108);
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
            titleLabel.BackColor = Color.Black;
            titleLabel.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Cyan;
            titleLabel.Location = new Point(248, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(141, 35);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Tetrix";
            // 
            // changeModeBox
            // 
            changeModeBox.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changeModeBox.FormattingEnabled = true;
            changeModeBox.Location = new Point(238, 168);
            changeModeBox.Name = "changeModeBox";
            changeModeBox.Size = new Size(151, 27);
            changeModeBox.TabIndex = 5;
            // 
            // highScorePanel
            // 
            highScorePanel.Controls.Add(highScoresLabel);
            highScorePanel.Controls.Add(highScoreReturnBtn);
            highScorePanel.Controls.Add(highScoreTitle);
            highScorePanel.Location = new Point(66, 27);
            highScorePanel.Name = "highScorePanel";
            highScorePanel.Size = new Size(767, 555);
            highScorePanel.TabIndex = 1;
            // 
            // highScoresLabel
            // 
            highScoresLabel.AutoSize = true;
            highScoresLabel.Font = new Font("OCR A Extended", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highScoresLabel.Location = new Point(288, 118);
            highScoresLabel.Name = "highScoresLabel";
            highScoresLabel.Size = new Size(0, 24);
            highScoresLabel.TabIndex = 1;
            // 
            // highScoreReturnBtn
            // 
            highScoreReturnBtn.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highScoreReturnBtn.Location = new Point(280, 326);
            highScoreReturnBtn.Name = "highScoreReturnBtn";
            highScoreReturnBtn.Size = new Size(94, 29);
            highScoreReturnBtn.TabIndex = 2;
            highScoreReturnBtn.Text = "Main Menu";
            highScoreReturnBtn.UseVisualStyleBackColor = true;
            highScoreReturnBtn.Click += highScoreReturnBtn_Click;
            // 
            // highScoreTitle
            // 
            highScoreTitle.AutoSize = true;
            highScoreTitle.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            highScoreTitle.Location = new Point(205, 40);
            highScoreTitle.Name = "highScoreTitle";
            highScoreTitle.Size = new Size(257, 35);
            highScoreTitle.TabIndex = 0;
            highScoreTitle.Text = "High Scores";
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(gameExitButton);
            gamePanel.Controls.Add(scoreValueLabel);
            gamePanel.Controls.Add(scoreLabel);
            gamePanel.Controls.Add(timerValueLabel);
            gamePanel.Controls.Add(timerLabel);
            gamePanel.Controls.Add(boardPanel);
            gamePanel.Controls.Add(returnToMainMenuButton);
            gamePanel.Controls.Add(gameOverLabel);
            gamePanel.Location = new Point(-1, 0);
            gamePanel.Margin = new Padding(3, 4, 3, 4);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(803, 444);
            gamePanel.TabIndex = 1;
            // 
            // gameExitButton
            // 
            gameExitButton.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameExitButton.Location = new Point(726, 4);
            gameExitButton.Margin = new Padding(3, 4, 3, 4);
            gameExitButton.Name = "gameExitButton";
            gameExitButton.Size = new Size(63, 31);
            gameExitButton.TabIndex = 6;
            gameExitButton.Text = "Exit";
            gameExitButton.UseVisualStyleBackColor = true;
            gameExitButton.Visible = false;
            gameExitButton.Click += gameExitButton_Click;
            // 
            // scoreValueLabel
            // 
            scoreValueLabel.AutoSize = true;
            scoreValueLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreValueLabel.Location = new Point(66, 205);
            scoreValueLabel.Name = "scoreValueLabel";
            scoreValueLabel.Size = new Size(0, 32);
            scoreValueLabel.TabIndex = 5;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(66, 165);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(109, 32);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "Score";
            // 
            // timerValueLabel
            // 
            timerValueLabel.AutoSize = true;
            timerValueLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerValueLabel.Location = new Point(640, 205);
            timerValueLabel.Name = "timerValueLabel";
            timerValueLabel.Size = new Size(0, 32);
            timerValueLabel.TabIndex = 3;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(640, 165);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(109, 32);
            timerLabel.TabIndex = 2;
            timerLabel.Text = "Timer";
            // 
            // boardPanel
            // 
            boardPanel.Location = new Point(241, 47);
            boardPanel.Margin = new Padding(3, 4, 3, 4);
            boardPanel.Name = "boardPanel";
            boardPanel.Size = new Size(313, 361);
            boardPanel.TabIndex = 1;
            // 
            // returnToMainMenuButton
            // 
            returnToMainMenuButton.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnToMainMenuButton.Location = new Point(312, 241);
            returnToMainMenuButton.Margin = new Padding(3, 4, 3, 4);
            returnToMainMenuButton.Name = "returnToMainMenuButton";
            returnToMainMenuButton.Size = new Size(176, 31);
            returnToMainMenuButton.TabIndex = 7;
            returnToMainMenuButton.Text = "Main Menu";
            returnToMainMenuButton.UseVisualStyleBackColor = true;
            returnToMainMenuButton.Click += returnToMainMenuButton_Click;
            // 
            // gameOverLabel
            // 
            gameOverLabel.AutoSize = true;
            gameOverLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameOverLabel.ForeColor = Color.Red;
            gameOverLabel.Location = new Point(312, 165);
            gameOverLabel.Name = "gameOverLabel";
            gameOverLabel.Size = new Size(185, 32);
            gameOverLabel.TabIndex = 3;
            gameOverLabel.Text = "GAME OVER";
            // 
            // tutorialPanel
            // 
            tutorialPanel.Controls.Add(tutorialMessage);
            tutorialPanel.Controls.Add(returnFromTutorialBtn);
            tutorialPanel.Controls.Add(tutorialLabel);
            tutorialPanel.Location = new Point(0, 0);
            tutorialPanel.Name = "tutorialPanel";
            tutorialPanel.Size = new Size(799, 453);
            tutorialPanel.TabIndex = 3;
            // 
            // tutorialMessage
            // 
            tutorialMessage.AutoSize = true;
            tutorialMessage.Font = new Font("OCR A Extended", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tutorialMessage.Location = new Point(71, 116);
            tutorialMessage.Name = "tutorialMessage";
            tutorialMessage.Size = new Size(655, 234);
            tutorialMessage.TabIndex = 2;
            tutorialMessage.Text = resources.GetString("tutorialMessage.Text");
            // 
            // returnFromTutorialBtn
            // 
            returnFromTutorialBtn.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnFromTutorialBtn.Location = new Point(324, 379);
            returnFromTutorialBtn.Name = "returnFromTutorialBtn";
            returnFromTutorialBtn.Size = new Size(116, 29);
            returnFromTutorialBtn.TabIndex = 1;
            returnFromTutorialBtn.Text = "Main Menu";
            returnFromTutorialBtn.UseVisualStyleBackColor = true;
            returnFromTutorialBtn.Click += returnFromTutorialBtn_Click;
            // 
            // tutorialLabel
            // 
            tutorialLabel.AutoSize = true;
            tutorialLabel.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tutorialLabel.Location = new Point(304, 47);
            tutorialLabel.Name = "tutorialLabel";
            tutorialLabel.Size = new Size(183, 35);
            tutorialLabel.TabIndex = 0;
            tutorialLabel.Text = "Tutorial";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(mainMenuPanel);
            Controls.Add(tutorialPanel);
            Controls.Add(gamePanel);
            Controls.Add(highScorePanel);
            Name = "App";
            Text = "Tetrix";
            KeyDown += App_KeyDown;
            mainMenuPanel.ResumeLayout(false);
            mainMenuPanel.PerformLayout();
            highScorePanel.ResumeLayout(false);
            highScorePanel.PerformLayout();
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            tutorialPanel.ResumeLayout(false);
            tutorialPanel.PerformLayout();
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
        private Panel tutorialPanel;
        private Label tutorialLabel;
        private Label tutorialMessage;
        private Button returnFromTutorialBtn;
        private Button tutorialButton;
    }
}
