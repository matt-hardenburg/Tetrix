using Tetrix.src.Components;
using Tetrix.src.Director;
using Tetrix.src.Threads;

namespace Tetrix
{
    public partial class App : Form
    {
        GameDirectorAC gameDirector;
        Board board;
        List<Thread> threads;
        List<InputThread> inputThreads;
        src.Game game;
        uint[] currentHighScores;
        bool highScoresRetreived;

        public App()
        {
            InitializeComponent();
            highScoresRetreived = parseHighScores("Data\\highscores.txt");
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            highScorePanel.Visible = false;
            gamePanel.Visible = false;
            mainMenuPanel.Visible = true;
            tutorialPanel.Visible = false;

            try
            {
                StreamReader scoreReader = new StreamReader("Data\\modes.txt");
                string mode;
                while ((mode = scoreReader.ReadLine()) != null)
                {
                    changeModeBox.Items.Add(mode);
                }
            }
            catch (IOException)
            {
                changeModeBox.Items.Add("Normal");
                changeModeBox.Items.Add("Hard");
            }

            changeModeBox.SelectedIndex = 0;

            gameDirector = new NormalGameDirector(scoreValueLabel, timerValueLabel, boardPanel);
        }

        public List<Thread> getThreads()
        {
            return threads;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void highScoreBtn_Click(object sender, EventArgs e)
        {
            highScoresRetreived = parseHighScores("Data\\highscores.txt"); //ensure latest information

            this.SuspendLayout();
            mainMenuPanel.Visible = false;
            highScorePanel.Visible = true;
            this.ResumeLayout();

            int scoreCounter = 1;
            highScoresLabel.Text = "";

            if (!highScoresRetreived)
            {
                highScoresLabel.Text = "Unable to retrieve scores.";
                return;
            }

            foreach (uint score in currentHighScores)
            {
                highScoresLabel.Text += scoreCounter + ". " + score.ToString() + "\n";
                scoreCounter++;
            }
        }

        private void highScoreReturnBtn_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            mainMenuPanel.Visible = true;
            highScorePanel.Visible = false;
            this.ResumeLayout();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            string currentMode;

            if (changeModeBox.SelectedItem == null || changeModeBox.SelectedItem.ToString().Equals("")) currentMode = "Normal";
            else currentMode = changeModeBox.SelectedItem.ToString();
            game = gameDirector.build(currentMode);

            inputThreads = game.start(currentHighScores, scoreValueLabel, boardPanel, gameOverLabel, returnToMainMenuButton);

            mainMenuPanel.Visible = false;
            highScorePanel.Visible = false;
            gamePanel.Visible = true;
            gameExitButton.Visible = true;
        }

        private void gameExitButton_Click(object sender, EventArgs e)
        {
            game.exit();
            gameExitButton.Visible = false;
        }

        private void App_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                foreach (InputThread inputThread in inputThreads) inputThread.setDirection("down");
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                foreach (InputThread inputThread in inputThreads) inputThread.setDirection("left");
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                foreach (InputThread inputThread in inputThreads) inputThread.setDirection("right");
            }
            else if (e.KeyCode == Keys.R)
            {
                foreach (InputThread inputThread in inputThreads) inputThread.setRotation(true);
            }
        }

        private bool parseHighScores(string path)
        {
            currentHighScores = new uint[5];
            int scoreCounter = 0;

            try
            {
                StreamReader scoreReader = new StreamReader(path);
                string score;


                while ((score = scoreReader.ReadLine()) != null && scoreCounter < 5)
                {
                    currentHighScores[scoreCounter] = uint.Parse(score);
                    scoreCounter++;
                }

                scoreReader.Close();
                return true;
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Unable to retrieve scores.");
                return false;
            }
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            returnToMainMenuButton.Visible = false;
            gameOverLabel.Visible = false;
            gameExitButton.Visible = false;
            boardPanel.Visible = true;
            scoreValueLabel.Text = "";
            timerValueLabel.Text = "";
            boardPanel.CreateGraphics().Clear(Color.Black);
            highScorePanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        private void tutorialButton_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            tutorialPanel.Visible = true;
        }

        private void returnFromTutorialBtn_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = true;
            tutorialPanel.Visible = false;
        }

        private void gameOver(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = true;
            tutorialPanel.Visible = false;
        }
    }
}
