namespace Tetrix.src.Components
{
    public class Timer : GameElementIF
    {
        private uint currentTime;
        private Label timerValueLabel;

        public Timer(Label timerValueLabel)
        {
            this.timerValueLabel = timerValueLabel;
        }

        public uint getCurrentTime()
        {
            return currentTime;
        }

        public void setCurrentTime(uint currentTime)
        {
            this.currentTime = currentTime;
        }

        public void draw()
        {
            if (timerValueLabel.InvokeRequired)
            {
                timerValueLabel.Invoke((MethodInvoker)(() => { timerValueLabel.Text = currentTime.ToString(); }));
            }
        }
    }
}
