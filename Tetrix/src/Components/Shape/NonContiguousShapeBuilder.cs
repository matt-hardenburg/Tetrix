using Tetrix.src.Components.Block;

namespace Tetrix.src.Components.Shape
{
    public class NonContiguousShapeBuilder : ShapeBuilder
    {
        protected override BlockIF[,] generateStructure(string color)
        {
            BlockIF[,] blocks = new BlockIF[4, 2];

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    blocks[i, j] = new BlockContext(-1, -1, "null");


            Random rand = new Random();
            int numOfBlocks = rand.Next(1, 9);
            int row;
            int col;

            for (int num = 1; num <= numOfBlocks; num++)
            {
                do
                {
                    row = rand.Next(0, 4);
                    col = rand.Next(0, 2);
                } 
                while (!blocks[row, col].getBlockType().getBlockTypeName().Equals("null"));

                blocks[row, col] = new BlockContext(col, row, color);
            }

            return blocks;
        }
    }
}
