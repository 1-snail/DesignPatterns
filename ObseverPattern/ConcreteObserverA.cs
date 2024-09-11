using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObseverPattern
{
    internal class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if((subject as Subject).state > 3)
            {
                Console.WriteLine("ConcreteObserverA: receive an  Event, state > 3");
            }
        }
    }
}
