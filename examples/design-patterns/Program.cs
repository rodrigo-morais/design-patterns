using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using design_patterns.observer;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var subscriber = new Subscriber();

            for (var counter = 1; counter < 10; counter++)
            {
                var name = "Observer " + counter;
                var value = (counter + 12) * 3.33;
                var observer = new Observer(name, value);

                subscriber.subscribe(observer);
            }

            subscriber.update();

            Console.ReadLine();
        }
    }
}
