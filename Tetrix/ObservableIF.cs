namespace Tetrix
{
    public interface ObservableIF
    {
        void addObserver(ObserverIF observer);
        void removeObserver(ObserverIF observer);
        void notifyObservers(Board.Events _event);
    }
}
