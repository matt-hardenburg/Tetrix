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
            int numOfBlocks = rand.Next(1, 8);
            int row = rand.Next(0, 3);
            int col = rand.Next(0, 1);
            for (int num = 1; num <= numOfBlocks; num++)
            {
                blocks[row, col] = new BlockContext(col, row, color);
                row = rand.Next(0, 3);
                col = rand.Next(0, 1);
            }
            return blocks;
        }
    }
}
