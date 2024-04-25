namespace Tetrix
{
    public class Board : GameElementIF, ObservableIF
    {
        private BlockIF[,] blockGrid;
        private ShapeIF currentShape;
        private ObservableIF observerManager;
        
        public enum Events : int
        {
            LineCleared = 1,
            PieceStopped = 2,
            TopOfScreen = 3
        }

        public Board(int gridHeight, int gridWidth)
        {
            blockGrid = new BlockIF[gridHeight, gridWidth];
            observerManager = new ObserverManager();

            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    blockGrid[i, j] = new BlockContext(j, i, "null");
                }
            }
        }

        void GameElementIF.draw()
        {
            lock (this)
            {
                throw new NotImplementedException();
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
                    if (!(block is NullBlock))
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
                        if (blockGrid[gridY, gridX] is NullBlock)
                        {
                            block.setGridLocationX(gridX);
                            block.setGridLocationY(gridY);
                            blockGrid[gridY, gridX] = block;
                        }
                        else
                        {
                            this.notifyObservers((int)Events.TopOfScreen);
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
                if (direction.Equals("down"))
                {
                    BlockIF[,] shapeBlocks = currentShape.getBlocks();
                    for (int i = shapeBlocks.GetLength(0); i >= 0; i--)
                    {
                        for (int j = shapeBlocks.GetLength(1); j >= 0; j--)
                        {
                            BlockIF block = shapeBlocks[i, j];
                            if (!(block is NullBlock))
                            {
                                int currentX = block.getGridLocationX();
                                int currentY = block.getGridLocationY();
                                if (!(currentY < blockGrid.GetLength(0) - 1 && (blockGrid[currentY + 1, currentX] is NullBlock || shapeContainsBlock(currentY + 1, currentX))))
                                {
                                    moveTrue = false;
                                    break;
                                }
                            }
                        }
                    }

                    if (moveTrue)
                    {
                        for (int i = shapeBlocks.GetLength(0); i >= 0; i--)
                        {
                            for (int j = shapeBlocks.GetLength(1); j >= 0; j--)
                            {
                                BlockIF block = shapeBlocks[i, j];
                                if (!(block is NullBlock))
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
                        this.notifyObservers((int)Events.PieceStopped);
                    }
                }
                else if (direction.Equals("left"))
                {
                    BlockIF[,] shapeBlocks = currentShape.getBlocks();
                    for (int i = shapeBlocks.GetLength(0); i >= 0; i--)
                    {
                        for (int j = shapeBlocks.GetLength(1); j >= 0; j--)
                        {
                            BlockIF block = shapeBlocks[i, j];
                            if (!(block is NullBlock))
                            {
                                int currentX = block.getGridLocationX();
                                int currentY = block.getGridLocationY();
                                if (!(currentX > 1 && (blockGrid[currentY, currentX - 1] is NullBlock || shapeContainsBlock(currentY, currentX - 1))))
                                {
                                    moveTrue = false;
                                    break;
                                }
                            }
                        }
                    }

                    if (moveTrue)
                    {
                        for (int i = shapeBlocks.GetLength(0); i >= 0; i--)
                        {
                            for (int j = shapeBlocks.GetLength(1); j >= 0; j--)
                            {
                                BlockIF block = shapeBlocks[i, j];
                                if (!(block is NullBlock))
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
                    for (int i = shapeBlocks.GetLength(0); i >= 0; i--)
                    {
                        for (int j = shapeBlocks.GetLength(1); j >= 0; j--)
                        {
                            BlockIF block = shapeBlocks[i, j];
                            if (!(block is NullBlock))
                            {
                                int currentX = block.getGridLocationX();
                                int currentY = block.getGridLocationY();
                                if (!(currentX < blockGrid.GetLength(1) - 1 && (blockGrid[currentY, currentX + 1] is NullBlock || shapeContainsBlock(currentY, currentX + 1))))
                                {
                                    moveTrue = false;
                                    break;
                                }
                            }
                        }
                    }

                    if (moveTrue)
                    {
                        for (int i = shapeBlocks.GetLength(0); i >= 0; i--)
                        {
                            for (int j = shapeBlocks.GetLength(1); j >= 0; j--)
                            {
                                BlockIF block = shapeBlocks[i, j];
                                if (!(block is NullBlock))
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
                        if (blockGrid[i, j] is NullBlock)
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
                                if (!(block is NullBlock))
                                {
                                    int currentX = block.getGridLocationX();
                                    int currentY = block.getGridLocationY();
                                    blockGrid[currentY + 1, currentX] = block;
                                    blockGrid[currentY, currentX] = new BlockContext(currentX, currentY, "null");
                                    block.setGridLocationY(currentY + 1);
                                }
                            }
                        }
                        this.notifyObservers((int)Events.LineCleared);
                    }
                }
            }
        }

        public void checkBoardStatus()
        {
            lock (this) {
                for (int i = 0; i < blockGrid.GetLength(1); i++)
                {
                    BlockIF block = blockGrid[0, i];
                    if (!(block is NullBlock))
                    {
                        this.notifyObservers((int)Events.TopOfScreen);
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

        public void notifyObservers(int eventNum)
        {
            observerManager.notifyObservers(eventNum);
        }
    }
}
