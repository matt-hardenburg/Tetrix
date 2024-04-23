using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public interface ObservableIF
    {
        void addObserver(ObserverIF observer);
        void removeObserver(ObserverIF observer);
        void notifyObservers(int eventNum);
    }
}
