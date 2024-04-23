using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class NullBlock : BlockTypeIF
    {
        void BlockTypeIF.draw()
        {
            throw new NotImplementedException();
        }
    }
}
