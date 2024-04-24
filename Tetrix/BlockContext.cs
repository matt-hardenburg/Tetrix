using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
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

            if (blockFactory == null)
                blockFactory = new BlockFactory();

            this.blockType = blockFactory.getBlockType(blockType);
        }  

        void GameElementIF.draw()
        {
            throw new NotImplementedException();
        }

        int BlockIF.getGridLocationX()
        {
            return gridLocationX;
        }

        int BlockIF.getGridLocationY()
        {
            return gridLocationY;
        }

        void BlockIF.setGridLocationX(int x)
        {
            this.gridLocationX = x;
        }

        void BlockIF.setGridLocationY(int y)
        {
            this.gridLocationY = y;
        }
    }
}
