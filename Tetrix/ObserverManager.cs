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

        void ObservableIF.addObserver(ObserverIF observer)
        {
            observers.Add(observer);
        }

        void ObservableIF.notifyObservers(int eventNum)
        {
            foreach (ObserverIF observer in observers) {
                observer.notify(eventNum);
            }
        }

        void ObservableIF.removeObserver(ObserverIF observer)
        {
            observers.Remove(observer);
        }
    }
}
