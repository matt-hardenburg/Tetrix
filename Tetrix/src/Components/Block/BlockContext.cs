﻿namespace Tetrix.src.Components.Block
{
    public class BlockContext : BlockIF
    {
        private int gridLocationX;
        private int gridLocationY;
        private BlockTypeIF blockType;
        private static BlockFactory blockFactory;

        public BlockContext(int gridLocationX, int gridLocationY, string blockType)
        {
            this.gridLocationX = gridLocationX;
            this.gridLocationY = gridLocationY;

            if (blockFactory == null) blockFactory = new BlockFactory();

            this.blockType = blockFactory.getBlockType(blockType);
        }

        void GameElementIF.draw()
        {
            throw new NotImplementedException();
        }

        public int getGridLocationX()
        {
            return gridLocationX;
        }

        public int getGridLocationY()
        {
            return gridLocationY;
        }

        public void setGridLocationX(int x)
        {
            gridLocationX = x;
        }

        public void setGridLocationY(int y)
        {
            gridLocationY = y;
        }
    }
}