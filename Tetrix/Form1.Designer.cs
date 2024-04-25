namespace Tetrix
{
    partial class Form1
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
            highScorePanel = new Panel();
            highScoreReturnBtn = new Button();
            highScoresLabel = new Label();
            highScoreTitle = new Label();
            mainMenuPanel.SuspendLayout();
            highScorePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuPanel
            // 
            mainMenuPanel.Controls.Add(changeModeBox);
            mainMenuPanel.Controls.Add(exitBtn);
            mainMenuPanel.Controls.Add(highScoreBtn);
            mainMenuPanel.Controls.Add(startGameBtn);
            mainMenuPanel.Controls.Add(titleLabel);
            mainMenuPanel.Location = new Point(40, 12);
            mainMenuPanel.Name = "mainMenuPanel";
            mainMenuPanel.Size = new Size(640, 422);
            mainMenuPanel.TabIndex = 0;
            // 
            // changeModeBox
            // 
            changeModeBox.FormattingEnabled = true;
            changeModeBox.Location = new Point(252, 181);
            changeModeBox.Name = "changeModeBox";
            changeModeBox.Size = new Size(151, 28);
            changeModeBox.TabIndex = 5;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(282, 325);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // highScoreBtn
            // 
            highScoreBtn.Location = new Point(268, 250);
            highScoreBtn.Name = "highScoreBtn";
            highScoreBtn.Size = new Size(121, 29);
            highScoreBtn.TabIndex = 3;
            highScoreBtn.Text = "High Scores";
            highScoreBtn.UseVisualStyleBackColor = true;
            highScoreBtn.Click += highScoreBtn_Click;
            // 
            // startGameBtn
            // 
            startGameBtn.Location = new Point(282, 112);
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
            titleLabel.Location = new Point(306, 50);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(45, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Tetrix";
            // 
            // highScoreReturnBtn
            // 
            highScoreReturnBtn.Location = new Point(301, 265);
            highScoreReturnBtn.Name = "highScoreReturnBtn";
            highScoreReturnBtn.Size = new Size(94, 29);
            highScoreReturnBtn.TabIndex = 2;
            highScoreReturnBtn.Text = "Main Menu";
            highScoreReturnBtn.UseVisualStyleBackColor = true;
            highScoreReturnBtn.Click += highScoreReturnBtn_Click;
            // 
            // highScoresLabel
            // 
            highScoresLabel.AutoSize = true;
            highScoresLabel.Location = new Point(306, 100);
            highScoresLabel.Name = "highScoresLabel";
            highScoresLabel.Size = new Size(0, 20);
            highScoresLabel.TabIndex = 1;
            // 
            // highScoreTitle
            // 
            highScoreTitle.AutoSize = true;
            highScoreTitle.Location = new Point(301, 39);
            highScoreTitle.Name = "highScoreTitle";
            highScoreTitle.Size = new Size(88, 20);
            highScoreTitle.TabIndex = 0;
            highScoreTitle.Text = "High Scores";
            // 
            // highScorePanel
            // 
            highScorePanel.Controls.Add(highScoreReturnBtn);
            highScorePanel.Controls.Add(highScoresLabel);
            highScorePanel.Controls.Add(highScoreTitle);
            highScorePanel.Location = new Point(0, 0);
            highScorePanel.Name = "highScorePanel";
            highScorePanel.Size = new Size(682, 422);
            highScorePanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(highScorePanel);
            Controls.Add(mainMenuPanel);
            Name = "Form1";
            Text = "Form1";
            mainMenuPanel.ResumeLayout(false);
            mainMenuPanel.PerformLayout();
            highScorePanel.ResumeLayout(false);
            highScorePanel.PerformLayout();
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
    }
}
