using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using design_patterns.iterato;
using design_patterns.observer;
using design_patterns.proxy;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = "";
            Type type = typeof(Program);
            MethodInfo method;

            do
            {
                pattern = "";
                Console.Write("Inform what design pattern have to run: ");
                pattern = Console.ReadLine();

                method = type.GetMethod(pattern);
                if (method != null)
                {
                    method.Invoke(null, new Object[] { });
                    Console.ReadLine();
                    Console.Clear();
                }                
            } while (pattern.ToLower() != "exit");
        }

        public static void observer()
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
        }

        public static void proxy()
        {
            var mathProxy = new MathProxy();


            Console.WriteLine("Sum 3 + 8: {0}", mathProxy.sum(3, 8));
            Console.WriteLine("Subtraction 13 + 8: {0}", mathProxy.subtraction(13, 8));
        }

        public static void iterator()
        {
            var tasks = new Tasks();
            var iterator = tasks.GetIterator();
            var item = "";

            tasks[0] = "Wake up";
            tasks[1] = "Take a shower";
            tasks[2] = "Take a bus";
            tasks[3] = "Work";
            tasks[4] = "Have lunch";
            tasks[5] = "Go home";

            item = iterator.FirstItem;

            while (!iterator.IsDone)
            {
                Console.WriteLine(item);
                item = iterator.NextItem;
            }
        }
    }
}
