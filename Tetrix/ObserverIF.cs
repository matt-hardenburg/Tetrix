namespace Tetrix
{
    public interface ObserverIF
    {
        void notify(Board.Events _event);
    }
}
