using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class ObserverManager : ObservableIF
    {
        private List<ObserverIF> observers = new List<ObserverIF>();

        public void addObserver(ObserverIF observer)
        {
            observers.Add(observer);
        }

        public void notifyObservers(int eventNum)
        {
            foreach (ObserverIF observer in observers) {
                observer.notify(eventNum);
            }
        }

        public void removeObserver(ObserverIF observer)
        {
            observers.Remove(observer);
        }
    }
}
