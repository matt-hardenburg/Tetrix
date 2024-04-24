using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
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

        }

        protected abstract void doJob();
    }
}
