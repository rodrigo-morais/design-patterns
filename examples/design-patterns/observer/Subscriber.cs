using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.observer
{
    public class Subscriber
    {
        List<Observer> observers = new List<Observer>();


        public void subscribe(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void unsubscribe(Observer observer)
        {
            this.observers.Remove(observer);
        }

        public void update()
        {
            this.observers.ForEach(o => o.notify());
        }

    }
}
