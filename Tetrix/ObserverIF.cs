using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public interface ObserverIF
    {
        void notify(int eventNum);
    }
}
