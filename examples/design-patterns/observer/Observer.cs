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
        private decimal value = 0;

        public Observer(string name, decimal value)
        {
            this.name = name;
            this.value = value;
        }

        public void notify()
        {
            Console.WriteLine(this.name + " - " + this.value);
        }
    }
}
