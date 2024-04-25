using Tetrix.src.Components;

namespace Tetrix.src.Observer
{
    public interface ObserverIF
    {
        void notify(Board.Events _event);
    }
}
