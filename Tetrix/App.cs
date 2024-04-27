using System.Drawing.Design;
using System.Threading;
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
        InputThread inputThread;
        src.Game game;
        uint[] currentHighScores, tempHighScores;
        bool highScoresRetreived;
        public App()
        {
            InitializeComponent();
            parseHighScores("Data\\highscores.txt");

            this.KeyPreview = true;
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

            gameDirector = new NormalGameDirector(scoreValueLabel, timerValueLabel, boardPanel, currentHighScores);
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
            parseHighScores("Data\\highscores.txt"); //ensure latest information
            this.SuspendLayout();
            mainMenuPanel.Visible = false;
            highScorePanel.Visible = true;
            this.ResumeLayout();

            int scoreCounter = 1;
            highScoresLabel.Text = "";

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
            mainMenuPanel.Visible = false;
            string currentMode;

            if (changeModeBox.SelectedItem == null ||
                changeModeBox.SelectedItem.ToString().Equals("")) currentMode = "Normal";
            else currentMode = changeModeBox.SelectedItem.ToString();
            game = gameDirector.build(currentMode);

            foreach (GameElementIF component in game.getGameComponents()) if (component is Board b) board = b;

            threads = game.start();
            this.inputThread = new InputThread(board);
            Thread inputThread = new Thread(new ThreadStart(this.inputThread.run));
            inputThread.Name = "Input";
            threads.Add(inputThread);
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

        private void App_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                inputThread.setDirection("down");
            }
            else if(e.KeyCode == Keys.Left)
            {
                inputThread.setDirection("left");
            }
            else if (e.KeyCode == Keys.Right)
            {
                inputThread.setDirection("right");
            }
        }

        private void parseHighScores(string path)
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
            }
            catch (IOException) { Console.Error.WriteLine("Unable to retrieve scores.");
                highScoresRetreived = false;
            }
        }
    }
}
