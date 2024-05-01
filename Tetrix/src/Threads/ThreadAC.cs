namespace Tetrix.src.Threads
{
    public abstract class ThreadAC : ThreadIF
    {
        public void run()
        {
            while (!Terminator.isShutDownRequested())
            {
                doJob();
            }
            shutDown();
        }

        protected virtual void shutDown()
        {
            System.Diagnostics.Debug.WriteLine(this.GetType() + " shutdown called");
        }

        protected abstract void doJob();
    }
}
