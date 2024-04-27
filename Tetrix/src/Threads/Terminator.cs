namespace Tetrix.src.Threads
{
    public class Terminator
    {
        private static bool shutDownRequested = false;
        private static bool normalShutDown = true;

        public static bool isShutDownRequested()
        {
            return shutDownRequested;
        }

        public static bool isNormalShutdown()
        {
            return normalShutDown;
        }

        public static void doShutDown(bool normal)
        {
            shutDownRequested = true;
            normalShutDown = normal;
        }
    }
}
