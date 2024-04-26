using Tetrix.src.Components;
using Tetrix.src.Director;

namespace Tetrix
{
    public partial class App : Form
    {
        GameDirectorAC gameDirector;
        Board board;
        List<Thread> threads;
        src.Game game;
        public App()
        {
            InitializeComponent();
            highScorePanel.Visible = false;
            gamePanel.Visible = false;
            mainMenuPanel.Visible = true;

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

            gameDirector = new NormalGameDirector(scoreValueLabel, timerValueLabel);
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
            try
            {
                StreamReader scoreReader = new StreamReader("Data\\highscores.txt");
                string score;

                this.SuspendLayout();
                mainMenuPanel.Visible = false;
                highScorePanel.Visible = true;
                this.ResumeLayout();
                //highScorePanel.BringToFront();

                int scoreCounter = 1;
                highScoresLabel.Text = "";
                while ((score = scoreReader.ReadLine()) != null && scoreCounter <= 5)
                {
                    highScoresLabel.Text += scoreCounter + ". " + score + "\n";
                    scoreCounter++;
                }
            }
            catch (IOException) { highScoresLabel.Text = "Unable to retrieve scores."; }
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
            mainMenuPanel.Visible = false;
            string currentMode;

            if (changeModeBox.SelectedItem == null ||
                changeModeBox.SelectedItem.ToString().Equals("")) currentMode = "Normal";
            else currentMode = changeModeBox.SelectedItem.ToString();
            game = gameDirector.build(currentMode);

            foreach (GameElementIF component in game.getGameComponents()) if (component is Board b) board = b;

            threads = game.start();
            this.SuspendLayout();
            mainMenuPanel.Visible = false;
            highScorePanel.Visible = false;
            gamePanel.Visible = true;
            this.ResumeLayout();
            gameExitButton.Visible = true;
            foreach (Thread thread in threads) thread.Start();
        }

        private void gameExitButton_Click(object sender, EventArgs e)
        {
            game.exit(threads);
            highScorePanel.Visible = false;
            mainMenuPanel.Visible = true;
            gameExitButton.Visible = false;
        }
    }
}
