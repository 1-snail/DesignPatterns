using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObseverPattern
{
    internal class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).state <= 3)
            {
                Console.WriteLine("ConcreteObserverB: receive an  Event, state <= 3");
            }
        }
    }
}
