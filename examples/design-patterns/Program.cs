using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
            var sumProxy = new MathProxy(Operations.SUM);
            var subProxy = new MathProxy(Operations.SUBTRACTION);


            Console.WriteLine("Sum 3 + 8: {0}", sumProxy.calc(3, 8));
            Console.WriteLine("Subtraction 13 + 8: {0}", subProxy.calc(13, 8));
        }
    }
}
