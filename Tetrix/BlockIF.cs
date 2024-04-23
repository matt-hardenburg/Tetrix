using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public interface BlockIF : GameElementIF
    {
        int getGridLocationX();
        int getGridLocationY();
    }
}
