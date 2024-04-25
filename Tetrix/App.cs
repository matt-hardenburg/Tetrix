using Tetrix.src.Director;

namespace Tetrix
{
    public partial class App : Form
    {
        GameDirectorAC gameDirector;
        public App()
        {
            InitializeComponent();
            highScorePanel.Visible = false;
            try
            {
                //Change to relative path
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
            gameDirector = new NormalGameDirector();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void highScoreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Change to relative path
                StreamReader scoreReader = new StreamReader("Data\\highscores.txt");
                string score;
                this.SuspendLayout();
                mainMenuPanel.Visible = false;
                highScorePanel.Visible = true;
                this.ResumeLayout();
                int scoreCounter = 1;
                highScoresLabel.Text = "";
                while ((score = scoreReader.ReadLine()) != null && scoreCounter <= 5)
                {
                    highScoresLabel.Text += scoreCounter + ". " + score + "\n";
                    scoreCounter++;
                }
            }
            catch (IOException)
            {
                highScoresLabel.Text = "Unable to retrieve scores.";
            }
        }

        private void highScoreReturnBtn_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            mainMenuPanel.Visible = true;
            highScorePanel.Visible = false;
            this.ResumeLayout();
            mainMenuPanel.BringToFront();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            string currentMode = changeModeBox.SelectedItem.ToString();
            if (currentMode == null || currentMode.Equals(""))
                currentMode = "Normal";
            src.Game game = gameDirector.build(currentMode);
            game.start();
            BufferedGraphicsContext currentContext;
            BufferedGraphics myBuffer;
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with Form1, and with
            // dimensions the same size as the drawing surface of Form1.
            myBuffer = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
        }
    }
}
