namespace Tetrix.src.Components.Block
{
    public class BlockFactory
    {
        private BlockTypeIF[] blockTypes = new BlockTypeIF[8];

        public BlockTypeIF getBlockType(string blockType)
        {
            if (blockType == "green")
            {
                if (blockTypes[1] == null)
                    blockTypes[1] = new ColoredBlock(Color.Green);
                return blockTypes[1];
            }
            else if (blockType == "red")
            {
                if (blockTypes[2] == null)
                    blockTypes[2] = new ColoredBlock(Color.Red);
                return blockTypes[2];
            }
            if (blockType == "blue")
            {
                if (blockTypes[3] == null)
                    blockTypes[3] = new ColoredBlock(Color.Blue);
                return blockTypes[3];
            }
            if (blockType == "cyan")
            {
                if (blockTypes[4] == null)
                    blockTypes[4] = new ColoredBlock(Color.Cyan);
                return blockTypes[4];
            }
            if (blockType == "yellow")
            {
                if (blockTypes[5] == null)
                    blockTypes[5] = new ColoredBlock(Color.Yellow);
                return blockTypes[5];
            }
            if (blockType == "purple")
            {
                if (blockTypes[6] == null)
                    blockTypes[6] = new ColoredBlock(Color.Purple);
                return blockTypes[6];
            }
            if (blockType == "orange")
            {
                if (blockTypes[7] == null)
                    blockTypes[7] = new ColoredBlock(Color.Orange);
                return blockTypes[7];
            }
            else
            {
                if (blockTypes[0] == null)
                    blockTypes[0] = new NullBlock();
                return blockTypes[0];
            }
        }
    }
}
