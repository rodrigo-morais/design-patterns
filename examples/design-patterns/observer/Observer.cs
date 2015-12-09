using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.observer
{
    public class Observer
    {
        private string name = "";
        private double value = 0;

        public Observer(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        public void notify()
        {
            Console.WriteLine(this.name + " - " + this.value.ToString());
        }
    }
}
