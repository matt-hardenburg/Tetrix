using Tetrix.src.Settings;
using Tetrix.src.Components;

namespace Tetrix.src.Threads
{
    public class GameThread : ThreadAC
    {
        private ReadOnlyGameSettingsIF gameSettings;
        private Board board;
        private double currentFallingSpeed;
        private double speedIncrement;
        private int rampUpCounter;
        private uint[] highScores;
        private Label scoreLabelValue;
        private bool updatedScores;

        public GameThread(ReadOnlyGameSettingsIF gameSettings, Board board, uint[] highScores, Label scoreValueLabel)
        {
            this.gameSettings = gameSettings;
            this.board = board;
            this.highScores = highScores;
            this.scoreLabelValue = scoreValueLabel;
            updatedScores = false;
            currentFallingSpeed = gameSettings.getMinFallingSpeed();
            speedIncrement = gameSettings.getSpeedIncrement();
            rampUpCounter = 0;
        }

        protected override void doJob()
        {
            Thread.Sleep((int) (currentFallingSpeed * 1000));
            board.moveCurrentShape("down");
            if (currentFallingSpeed > gameSettings.getMaxFallingSpeed())
            {
                rampUpCounter++;
                if (rampUpCounter == gameSettings.getRampUp())
                {
                    rampUpCounter = 0;
                    currentFallingSpeed -= speedIncrement;
                }
            }
        }

        //Should work, but is untested 
        protected override void shutDown()
        {
            //get score from label
            uint newScore = uint.Parse(scoreLabelValue.Text);

            //cascading add if greater than existing
            for (int i = 0; i < highScores.Length; i++)
            {
                if (newScore > highScores[i])
                {
                    if (!updatedScores) updatedScores = true;
                    uint temp = highScores[i];
                    highScores[i] = newScore;
                    newScore = temp;
                }
            }
            //write to file and continue shutdown
            writeToFile("Data\\highscores.txt");
            base.shutDown();
        }

        private void writeToFile(string path)
        {
            if (!updatedScores) return; //no need to update file

            try
            {
                StreamWriter scoreWriter = new("Data\\highscores.txt", false);
                for (int i = 0; i < highScores.Length; i++) scoreWriter.WriteLine(highScores[i].ToString());
                scoreWriter.Close();
            }
            catch (IOException){ Console.Error.WriteLine("Unable to open highscores file."); }
        }
    }
}
