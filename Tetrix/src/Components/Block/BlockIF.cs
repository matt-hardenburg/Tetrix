namespace Tetrix.src.Components.Block
{
    public interface BlockIF : GameElementIF
    {
        int getGridLocationX();
        int getGridLocationY();
        void setGridLocationX(int x);
        void setGridLocationY(int y);
    }
}
