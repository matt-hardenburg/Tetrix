namespace Tetrix.src.Components
{
    public class Timer : GameElementIF
    {
        private uint currentTime;

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
            throw new NotImplementedException();
        }
    }
}
