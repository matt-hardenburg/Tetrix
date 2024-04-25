using Tetrix.src.Components.Block;

namespace Tetrix.src.Components.Shape
{
    public class ShapeBuilder : ShapeBuilderAC
    {
        protected override string generateColor()
        {
            Random rand = new Random();
            switch (rand.Next(1, 7))
            {
                case 1:
                    return "green";
                case 2:
                    return "red";
                case 3:
                    return "blue";
                case 4:
                    return "cyan";
                case 5:
                    return "yellow";
                case 6:
                    return "purple";
                case 7:
                    return "orange";
                default:
                    return "null";
            }
        }

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
                int nextRow;
                do
                {
                    nextRow = rand.Next(0, 3);
                } while (!(nextRow >= row - 1) && !(nextRow <= row + 1));
                int nextCol;
                do
                {
                    nextCol = rand.Next(0, 1);
                } while (!(nextCol >= col - 1) && !(nextCol <= col + 1));
                row = nextRow;
                col = nextCol;
            }
            return blocks;
        }
    }
}
