using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class TimerThread : ThreadAC
    {
        private Timer timer;

        public TimerThread(Timer timer)
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
