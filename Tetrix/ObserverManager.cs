﻿namespace Tetrix
{
    public class ObserverManager : ObservableIF
    {
        private List<ObserverIF> observers = new List<ObserverIF>();

        public void addObserver(ObserverIF observer)
        {
            observers.Add(observer);
        }

        public void notifyObservers(Board.Events _event)
        {
            foreach (ObserverIF observer in observers) {
                observer.notify(_event);
            }
        }

        public void removeObserver(ObserverIF observer)
        {
            observers.Remove(observer);
        }
    }
}
