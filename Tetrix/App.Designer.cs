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
            mainMenuPanel.Location = new Point(64, 24);
            mainMenuPanel.Margin = new Padding(3, 2, 3, 2);
            mainMenuPanel.Name = "mainMenuPanel";
            mainMenuPanel.Size = new Size(565, 365);
            mainMenuPanel.TabIndex = 0;
            // 
            // tutorialButton
            // 
            tutorialButton.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tutorialButton.Location = new Point(231, 214);
            tutorialButton.Margin = new Padding(3, 2, 3, 2);
            tutorialButton.Name = "tutorialButton";
            tutorialButton.Size = new Size(95, 22);
            tutorialButton.TabIndex = 6;
            tutorialButton.Text = "Tutorial";
            tutorialButton.UseVisualStyleBackColor = true;
            tutorialButton.Click += tutorialButton_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(239, 258);
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
            highScoreBtn.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highScoreBtn.Location = new Point(217, 167);
            highScoreBtn.Margin = new Padding(3, 2, 3, 2);
            highScoreBtn.Name = "highScoreBtn";
            highScoreBtn.Size = new Size(123, 22);
            highScoreBtn.TabIndex = 3;
            highScoreBtn.Text = "High Scores";
            highScoreBtn.UseVisualStyleBackColor = true;
            highScoreBtn.Click += highScoreBtn_Click;
            // 
            // startGameBtn
            // 
            startGameBtn.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startGameBtn.Location = new Point(234, 81);
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
            titleLabel.BackColor = Color.Black;
            titleLabel.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Cyan;
            titleLabel.Location = new Point(217, 26);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(109, 29);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Tetrix";
            // 
            // changeModeBox
            // 
            changeModeBox.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changeModeBox.FormattingEnabled = true;
            changeModeBox.Location = new Point(208, 126);
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
            highScoresLabel.Font = new Font("OCR A Extended", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highScoresLabel.Location = new Point(252, 88);
            highScoresLabel.Name = "highScoresLabel";
            highScoresLabel.Size = new Size(0, 20);
            highScoresLabel.TabIndex = 1;
            // 
            // highScoreReturnBtn
            // 
            highScoreReturnBtn.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highScoreReturnBtn.Location = new Point(245, 244);
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
            highScoreTitle.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            highScoreTitle.Location = new Point(179, 30);
            highScoreTitle.Name = "highScoreTitle";
            highScoreTitle.Size = new Size(200, 29);
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
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(703, 333);
            gamePanel.TabIndex = 1;
            // 
            // gameExitButton
            // 
            gameExitButton.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameExitButton.Location = new Point(635, 3);
            gameExitButton.Name = "gameExitButton";
            gameExitButton.Size = new Size(55, 23);
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
            scoreValueLabel.Location = new Point(58, 154);
            scoreValueLabel.Name = "scoreValueLabel";
            scoreValueLabel.Size = new Size(0, 25);
            scoreValueLabel.TabIndex = 5;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(58, 124);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(87, 25);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "Score";
            // 
            // timerValueLabel
            // 
            timerValueLabel.AutoSize = true;
            timerValueLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerValueLabel.Location = new Point(560, 154);
            timerValueLabel.Name = "timerValueLabel";
            timerValueLabel.Size = new Size(0, 25);
            timerValueLabel.TabIndex = 3;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(560, 124);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(87, 25);
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
            returnToMainMenuButton.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            gameOverLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameOverLabel.ForeColor = Color.Red;
            gameOverLabel.Location = new Point(273, 124);
            gameOverLabel.Name = "gameOverLabel";
            gameOverLabel.Size = new Size(147, 25);
            gameOverLabel.TabIndex = 3;
            gameOverLabel.Text = "GAME OVER";
            // 
            // tutorialPanel
            // 
            tutorialPanel.Controls.Add(tutorialMessage);
            tutorialPanel.Controls.Add(returnFromTutorialBtn);
            tutorialPanel.Controls.Add(tutorialLabel);
            tutorialPanel.Location = new Point(0, 0);
            tutorialPanel.Margin = new Padding(3, 2, 3, 2);
            tutorialPanel.Name = "tutorialPanel";
            tutorialPanel.Size = new Size(699, 340);
            tutorialPanel.TabIndex = 3;
            // 
            // tutorialMessage
            // 
            tutorialMessage.AutoSize = true;
            tutorialMessage.Font = new Font("OCR A Extended", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tutorialMessage.Location = new Point(62, 87);
            tutorialMessage.Name = "tutorialMessage";
            tutorialMessage.Size = new Size(572, 216);
            tutorialMessage.TabIndex = 2;
            tutorialMessage.Text = resources.GetString("tutorialMessage.Text");
            // 
            // returnFromTutorialBtn
            // 
            returnFromTutorialBtn.Font = new Font("OCR A Extended", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnFromTutorialBtn.Location = new Point(284, 284);
            returnFromTutorialBtn.Margin = new Padding(3, 2, 3, 2);
            returnFromTutorialBtn.Name = "returnFromTutorialBtn";
            returnFromTutorialBtn.Size = new Size(102, 22);
            returnFromTutorialBtn.TabIndex = 1;
            returnFromTutorialBtn.Text = "Main Menu";
            returnFromTutorialBtn.UseVisualStyleBackColor = true;
            returnFromTutorialBtn.Click += returnFromTutorialBtn_Click;
            // 
            // tutorialLabel
            // 
            tutorialLabel.AutoSize = true;
            tutorialLabel.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tutorialLabel.Location = new Point(266, 35);
            tutorialLabel.Name = "tutorialLabel";
            tutorialLabel.Size = new Size(141, 29);
            tutorialLabel.TabIndex = 0;
            tutorialLabel.Text = "Tutorial";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(mainMenuPanel);
            Controls.Add(tutorialPanel);
            Controls.Add(gamePanel);
            Controls.Add(highScorePanel);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(716, 377);
            MinimumSize = new Size(716, 377);
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
