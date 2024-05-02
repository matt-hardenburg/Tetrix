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
            int numOfBlocks = rand.Next(1, 9);
            int row = rand.Next(0, 4);
            int col = rand.Next(0, 2);
            List<Point> options = new List<Point>();

            for (int num = 1; num <= numOfBlocks; num++)
            {
                blocks[row, col] = new BlockContext(col, row, color);

                if (row - 1 >= 0 && blocks[row - 1, col].getBlockType().getBlockTypeName().Equals("null"))
                    options.Add(new Point(col, row - 1));
                if (row + 1 < blocks.GetLength(0) && blocks[row + 1, col].getBlockType().getBlockTypeName().Equals("null"))
                    options.Add(new Point(col, row + 1));
                if (col - 1 >= 0 && blocks[row, col - 1].getBlockType().getBlockTypeName().Equals("null"))
                    options.Add(new Point(col - 1, row));
                if (col + 1 < blocks.GetLength(1) && blocks[row, col + 1].getBlockType().getBlockTypeName().Equals("null"))
                    options.Add(new Point(col + 1, row));
                if (options.Count <= 0)
                    break;
                else
                {
                    int selection = rand.Next(0, options.Count);
                    Point newPoint = options[selection];

                    row = newPoint.Y;
                    col = newPoint.X;
                    options.Clear();
                }
            }

            return blocks;
        }
    }
}
