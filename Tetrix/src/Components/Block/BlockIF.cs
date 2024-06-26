﻿namespace Tetrix.src.Components.Block
{
    public interface BlockIF
    {
        int getGridLocationX();
        int getGridLocationY();
        BlockTypeIF getBlockType();
        void setGridLocationX(int x);
        void setGridLocationY(int y);
        void draw(Graphics graphics, int height, int width);
    }
}
