namespace Tetrix.src.Threads
{
    public abstract class ThreadAC : ThreadIF
    {
        public void run()
        {
            while (!Terminator.isShutDownRequested()) doJob();
            shutDown();
        }

        protected virtual void shutDown()
        {
            //override as needed
        }

        protected abstract void doJob();
    }
}
