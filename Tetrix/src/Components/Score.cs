using Tetrix.src.Settings;
using Tetrix.src.Observer;

namespace Tetrix.src.Components
{
    public class Score : GameElementIF, ObserverIF
    {
        private uint currentScore;
        private ReadOnlyGameSettingsIF gameSettings;
        private Label scoreValueLabel;

        public Score(ReadOnlyGameSettingsIF gameSettings, Label scoreValueLabel)
        {
            currentScore = 0;
            this.gameSettings = gameSettings;
            this.scoreValueLabel = scoreValueLabel;
        }

        public void draw()
        {
            if (scoreValueLabel.InvokeRequired)
                scoreValueLabel.Invoke((MethodInvoker)(() => { scoreValueLabel.Text = currentScore.ToString(); }));
        }

        public uint getCurrentScore()
        {
            return currentScore;
        }

        public Label getScoreValueLabel()
        {
            return scoreValueLabel;
        }

        public void setScoreValueLabel(Label scoreValueLabel)
        {
            this.scoreValueLabel = scoreValueLabel;
        }

        public void setCurrentScore(uint currentScore)
        {
            this.currentScore = currentScore;
        }

        public void notify(Board.Events _event)
        {
            switch (_event)
            {
                case Board.Events.LineCleared:
                    currentScore += (uint)(100 * gameSettings.getPointMultiplier());
                    break;
            }
        }
    }
}
