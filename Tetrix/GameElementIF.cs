﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public interface GameElementIF
    {
        void draw(Graphics graphics, int startX, int startY);
    }
}
