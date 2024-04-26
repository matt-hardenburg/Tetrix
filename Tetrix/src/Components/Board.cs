using Tetrix.src.Components.Block;
using Tetrix.src.Components.Shape;
using Tetrix.src.Observer;

namespace Tetrix.src.Components
{
    public class Board : GameElementIF, ObservableIF
    {
        private BlockIF[,] blockGrid;
        private ShapeIF currentShape;
        private ObservableIF observerManager;
        private Panel boardPanel;

        public enum Events : int
        {
            LineCleared = 1,
            PieceStopped = 2,
            TopOfScreen = 3
        }

        public Board(int gridHeight, int gridWidth, Panel boardPanel)
        {
            blockGrid = new BlockIF[gridHeight, gridWidth];
            observerManager = new ObserverManager();

            for (int i = 0; i < gridHeight; i++)
                for (int j = 0; j < gridWidth; j++)
                    blockGrid[i, j] = new BlockContext(j, i, "null");
            this.boardPanel = boardPanel;
        }

        void GameElementIF.draw()
        {
            lock (this)
            {
                Graphics g = boardPanel.CreateGraphics();
                int blockHeight = boardPanel.Height / blockGrid.GetLength(0);
                int blockWidth = boardPanel.Width / blockGrid.GetLength(1);
                foreach (BlockIF block in blockGrid)
                    block.draw(g, blockHeight, blockWidth);
            }
        }

        public void addShapeToBoard(ShapeIF shape)
        {
            currentShape = shape;
            bool firstBlock = true;
            int firstX = 0;
            int firstY = 0;
            int offsetX = 0;
            int offsetY = 0;
            lock (this)
            {
                foreach (BlockIF block in currentShape.getBlocks())
                {
                    if (!(block.getBlockType().getBlockTypeName().Equals("null")))
                    {
                        if (firstBlock)
                        {
                            firstX = block.getGridLocationX();
                            firstY = block.getGridLocationY();
                            firstBlock = false;
                        }
                        offsetX = block.getGridLocationX() - firstX;
                        offsetY = block.getGridLocationY() - firstY;
                        int gridX = (blockGrid.GetLength(1) / 2) + offsetX;
                        int gridY = offsetY;
                        if (blockGrid[gridY, gridX].getBlockType().getBlockTypeName().Equals("null"))
                        {
                            block.setGridLocationX(gridX);
                            block.setGridLocationY(gridY);
                            blockGrid[gridY, gridX] = block;
                        }
                        else
                        {
                            notifyObservers(Events.TopOfScreen);
                            break;
                        }
                    }
                }
            }
        }

        public void moveCurrentShape(string direction)
        {
            bool moveTrue = true;
            lock (this)
            {
                if (currentShape is null) return;

                if (direction.Equals("down"))
                {
                    BlockIF[,] shapeBlocks = currentShape.getBlocks();
                    for (int i = shapeBlocks.GetLength(0) - 1; i >= 0; i--)
                    {
                        for (int j = shapeBlocks.GetLength(1) - 1; j >= 0; j--)
                        {
                            BlockIF block = shapeBlocks[i, j];
                            if (!block.getBlockType().getBlockTypeName().Equals("null"))
                            {
                                int currentX = block.getGridLocationX();
                                int currentY = block.getGridLocationY();
                                if (!(currentY < blockGrid.GetLength(0) - 1 && (blockGrid[currentY + 1, currentX].getBlockType().getBlockTypeName().Equals("null") || shapeContainsBlock(currentX, currentY + 1))))
                                {
                                    moveTrue = false;
                                    break;
                                }
                            }
                        }
                    }

                    if (moveTrue)
                    {
                        for (int i = shapeBlocks.GetLength(0) - 1; i >= 0; i--)
                        {
                            for (int j = shapeBlocks.GetLength(1) - 1; j >= 0; j--)
                            {
                                BlockIF block = shapeBlocks[i, j];
                                if (!block.getBlockType().getBlockTypeName().Equals("null"))
                                {
                                    int currentX = block.getGridLocationX();
                                    int currentY = block.getGridLocationY();
                                    blockGrid[currentY + 1, currentX] = block;
                                    blockGrid[currentY, currentX] = new BlockContext(currentX, currentY, "null");
                                    block.setGridLocationY(currentY + 1);
                                }
                            }
                        }
                    }
                    else
                    {
                        notifyObservers(Events.PieceStopped);
                    }
                }
                else if (direction.Equals("left"))
                {
                    BlockIF[,] shapeBlocks = currentShape.getBlocks();
                    for (int i = shapeBlocks.GetLength(0) - 1; i >= 0; i--)
                    {
                        for (int j = shapeBlocks.GetLength(1) - 1; j >= 0; j--)
                        {
                            BlockIF block = shapeBlocks[i, j];
                            if (!block.getBlockType().getBlockTypeName().Equals("null"))
                            {
                                int currentX = block.getGridLocationX();
                                int currentY = block.getGridLocationY();
                                if (!(currentX > 1 && (blockGrid[currentY, currentX - 1].getBlockType().getBlockTypeName().Equals("null") || shapeContainsBlock(currentX - 1, currentY))))
                                {
                                    moveTrue = false;
                                    break;
                                }
                            }
                        }
                    }

                    if (moveTrue)
                    {
                        for (int i = shapeBlocks.GetLength(0) - 1; i >= 0; i--)
                        {
                            for (int j = shapeBlocks.GetLength(1) - 1; j >= 0; j--)
                            {
                                BlockIF block = shapeBlocks[i, j];
                                if (!block.getBlockType().getBlockTypeName().Equals("null"))
                                {
                                    int currentX = block.getGridLocationX();
                                    int currentY = block.getGridLocationY();
                                    blockGrid[currentY, currentX - 1] = block;
                                    blockGrid[currentY, currentX] = new BlockContext(currentX, currentY, "null");
                                    block.setGridLocationX(currentX - 1);
                                }
                            }
                        }
                    }
                }
                else if (direction.Equals("right"))
                {
                    BlockIF[,] shapeBlocks = currentShape.getBlocks();
                    for (int i = shapeBlocks.GetLength(0) - 1; i >= 0; i--)
                    {
                        for (int j = shapeBlocks.GetLength(1) - 1; j >= 0; j--)
                        {
                            BlockIF block = shapeBlocks[i, j];
                            if (!block.getBlockType().getBlockTypeName().Equals("null"))
                            {
                                int currentX = block.getGridLocationX();
                                int currentY = block.getGridLocationY();
                                if (!(currentX < blockGrid.GetLength(1) - 1 && (blockGrid[currentY, currentX + 1].getBlockType().getBlockTypeName().Equals("null") || shapeContainsBlock(currentX + 1, currentY))))
                                {
                                    moveTrue = false;
                                    break;
                                }
                            }
                        }
                    }

                    if (moveTrue)
                    {
                        for (int i = shapeBlocks.GetLength(0) - 1; i >= 0; i--)
                        {
                            for (int j = shapeBlocks.GetLength(1) - 1; j >= 0; j--)
                            {
                                BlockIF block = shapeBlocks[i, j];
                                if (!block.getBlockType().getBlockTypeName().Equals("null"))
                                {
                                    int currentX = block.getGridLocationX();
                                    int currentY = block.getGridLocationY();
                                    blockGrid[currentY, currentX + 1] = block;
                                    blockGrid[currentY, currentX] = new BlockContext(currentX, currentY, "null");
                                    block.setGridLocationX(currentX + 1);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void clearedFilledLines()
        {
            lock (this)
            {
                for (int i = 0; i < blockGrid.GetLength(0); i++)
                {
                    bool rowClear = true;
                    for (int j = 0; j < blockGrid.GetLength(1); j++)
                    {
                        if (blockGrid[i, j].getBlockType().getBlockTypeName().Equals("null"))
                        {
                            rowClear = false;
                            break;
                        }
                    }
                    if (rowClear)
                    {
                        for (int j = 0; j < blockGrid.GetLength(1); j++)
                        {
                            blockGrid[i, j] = new BlockContext(j, i, "null");
                        }
                        for (int row = i; row >= 0; row--)
                        {
                            for (int col = blockGrid.GetLength(1); col >= 0; col--)
                            {
                                BlockIF block = blockGrid[row, col];
                                if (!block.getBlockType().getBlockTypeName().Equals("null"))
                                {
                                    int currentX = block.getGridLocationX();
                                    int currentY = block.getGridLocationY();
                                    blockGrid[currentY + 1, currentX] = block;
                                    blockGrid[currentY, currentX] = new BlockContext(currentX, currentY, "null");
                                    block.setGridLocationY(currentY + 1);
                                }
                            }
                        }
                        notifyObservers(Events.LineCleared);
                    }
                }
            }
        }

        public void checkBoardStatus()
        {
            lock (this)
            {
                for (int i = 0; i < blockGrid.GetLength(1); i++)
                {
                    BlockIF block = blockGrid[0, i];
                    if (!block.getBlockType().getBlockTypeName().Equals("null"))
                    {
                        notifyObservers(Events.TopOfScreen);
                        break;
                    }
                }
            }
        }

        private bool shapeContainsBlock(int gridX, int gridY)
        {
            BlockIF[,] blocks = currentShape.getBlocks();
            foreach (BlockIF block in blocks)
            {
                if (block.getGridLocationX() == gridX && block.getGridLocationY() == gridY)
                {
                    return true;
                }
            }
            return false;
        }

        public void addObserver(ObserverIF observer)
        {
            observerManager.addObserver(observer);
        }

        public void removeObserver(ObserverIF observer)
        {
            observerManager.removeObserver(observer);
        }

        public void notifyObservers(Events _event)
        {
            observerManager.notifyObservers(_event);
        }
    }
}
