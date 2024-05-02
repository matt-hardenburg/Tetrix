namespace Tetrix.src.Components.Block
{
    public interface BlockTypeIF
    {
        void draw(Graphics graphics, int x, int y, int height, int width);

        string getBlockTypeName();
    }
}
