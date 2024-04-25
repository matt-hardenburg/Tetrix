namespace Tetrix.src.Threads
{
    public class TimerThread : ThreadAC
    {
        private Components.Timer timer;

        public TimerThread(Components.Timer timer)
        {
            this.timer = timer;
        }

        protected override void doJob()
        {
            Thread.Sleep(1000);
            timer.setCurrentTime(timer.getCurrentTime() + 1);
        }
    }
}