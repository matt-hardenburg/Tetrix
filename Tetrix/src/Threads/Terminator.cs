namespace Tetrix.src.Threads
{
    public class Terminator
    {
        private static bool shutDownRequested = false;

        public static bool isShutDownRequested()
        {
            return shutDownRequested;
        }

        public static void doShutDown()
        {
            shutDownRequested = true;
        }

        public static void resetShutDown()
        {
            shutDownRequested = false;
        }
    }
}
