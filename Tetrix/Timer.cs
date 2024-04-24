using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
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
