using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class ColoredBlock : BlockTypeIF
    {
        private Color color;

        public ColoredBlock(Color color) { this.color = color; }

        void BlockTypeIF.draw()
        {
            throw new NotImplementedException();
        }
    }
}
