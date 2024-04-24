using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
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
    }
}
